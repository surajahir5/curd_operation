using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace registration_form
{
    public partial class changpic : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
           
            if (!this.IsPostBack)
            {
                imagedata();
            }
        }

        private void imagedata()
        {
            string UserName = (string)Session["name"];
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7SNQED0\SQLEXPRESS;Initial Catalog=suraj;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("Select register.Id,register.image from register where id= '" + Session["id"].ToString() + "'", con);
            //cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            //GridView1.DataSource = ds;
            //GridView1.DataBind();
            for (int i = 0; i < ds.Tables.Count; i++)
            {
                string url = ds.Tables[0].Rows[i]["image"].ToString();
                Image1.ImageUrl = url;
            }


            con.Close();
        }
    

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.PostedFile != null)
            {
                string strpath = Path.GetExtension(FileUpload1.FileName);
                if (strpath != ".jpg" && strpath != ".jpeg" && strpath != ".png")
                {
                    Label1.Text = "Only images files Allowed(jpg,jpeg,png) !";
                    Label1.ForeColor = System.Drawing.Color.Red;
                }

                string fileimg = Path.GetFileName(FileUpload1.PostedFile.FileName);
                FileUpload1.SaveAs(Server.MapPath("~/image/") + fileimg);

                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7SNQED0\SQLEXPRESS;Initial Catalog=suraj;Integrated Security=True");
                // string query = "update register set image='" + "~/image/" + fileimg + "' where id= '" + Session["id"].ToString() + "' ";
                string query = "reg";
                con.Open();
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Action", "imageup");   
                cmd.Parameters.AddWithValue("@id", Session["id"].ToString());
                cmd.Parameters.AddWithValue("@image", "~/image/" + fileimg);
                cmd.ExecuteNonQuery();
                //Label1.Text = "User Profile image" + Session["name"].ToString() + "has Successfull change";
                //imageupdate();
                Response.Redirect("home.aspx");

            }
            else
            {
               // Label1.Text = "User Profile Image" + Session["name"].ToString() + "has Not Successfull change";
            }


        }
    }
}

