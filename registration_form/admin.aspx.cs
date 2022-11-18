using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.SqlClient;

namespace registration_form
{
    public partial class admin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                getdata();
            }
        }

        private void getdata()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7SNQED0\SQLEXPRESS;Initial Catalog=suraj;Integrated Security=True");
            SqlCommand cmd = new SqlCommand("select * from register", con);
          //  cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            SqlDataAdapter sda = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            sda.Fill(ds);
            GridView1.DataSource = ds;
            GridView1.DataBind();
            con.Close();
        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            getdata();
        }

        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            getdata();
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
         {
            Label id = GridView1.Rows[e.RowIndex].FindControl("Label1") as Label;
            TextBox name = GridView1.Rows[e.RowIndex].FindControl("TextBox1") as TextBox;
            TextBox mobile = GridView1.Rows[e.RowIndex].FindControl("TextBox4") as TextBox;
            RadioButtonList gender = GridView1.Rows[e.RowIndex].FindControl("RadioButtonList1") as RadioButtonList;
            DropDownList usertype = GridView1.Rows[e.RowIndex].FindControl("DropDownList1") as DropDownList;
            Image image = GridView1.Rows[e.RowIndex].FindControl("Image2") as Image;
            FileUpload FileUpload1 = (FileUpload)GridView1.Rows[e.RowIndex].FindControl("FileUpload1");
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7SNQED0\SQLEXPRESS;Initial Catalog=suraj;Integrated Security=True");
            con.Open();
            string path = "~/Image/";
            if(FileUpload1.HasFile)
            {
                path += FileUpload1.FileName;
                FileUpload1.SaveAs(MapPath(path));
               
            }
            else
            {
                // use previous user image if new image is not changed
                Image img = (Image)GridView1.Rows[e.RowIndex].FindControl("Image2");
                path = img.ImageUrl;
            }

            // SqlCommand cmd = new SqlCommand("Update register set name='" + name.Text + "',mobile='" + mobile.Text + "',gender='" + gender.SelectedValue + "',usertype='" + usertype.SelectedValue + "' ,image='" + path + "' where Id =" + Convert.ToInt32(id.Text), con);
            SqlCommand cmd = new SqlCommand("reg",con);
            cmd.Parameters.AddWithValue("@Action", "adminup");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(id.Text)); /*Convert.ToInt32(id.Text));*/
            cmd.Parameters.AddWithValue("@name", name.Text);
            cmd.Parameters.AddWithValue("@mobile",mobile.Text);
            cmd.Parameters.AddWithValue("@gender", gender.SelectedValue);
            cmd.Parameters.AddWithValue("@usertype", usertype.SelectedValue);
            cmd.Parameters.AddWithValue("@image", path);
            cmd.ExecuteNonQuery();   
            Response.Write("<script> alert('Data Update sucessfuly')</script>");
            con.Close();
            getdata();

        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            foreach (GridViewRow gvrow in GridView1.Rows)
            {

                CheckBox chck = gvrow.FindControl("CheckBox1") as CheckBox;
                if (chck.Checked)
                {
                    var Label = gvrow.FindControl("Label1") as Label;
                    SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7SNQED0\SQLEXPRESS;Initial Catalog=suraj;Integrated Security=True");
                    con.Open();
                    SqlCommand cmd = new SqlCommand("delete from register where id=@id", con);
                    cmd.Parameters.AddWithValue("id", int.Parse(Label.Text));     
                    int id = cmd.ExecuteNonQuery();
                    con.Close();
                    getdata();


                }
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("login.aspx");
        }
    }
}