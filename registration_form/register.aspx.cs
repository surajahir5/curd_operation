using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace registration_form
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //if (!FileUpload1.HasFile) //Validation  
          //  {
              //  Response.Write("No file Selected"); return;
           // }
           // else
            {
                //string filepath = @"E:\suraj\registration_form\registration_form\image.jpg"; 
               // string filename = FileUpload1.PostedFile.FileName;
              //  byte[] imageByte = System.IO.File.ReadAllBytes(@"E:\suraj\registration_form\registration_form\image");
                // using (SqlConnection connection = new SqlConnection())
                SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7SNQED0\SQLEXPRESS;Initial Catalog=suraj;Integrated Security=True");
                {
                    con.Open();
                    // SqlCommand cmd = new SqlCommand("insert into register values(@name,@email,@password,@mobile,@gender,@usertype,@image)", con);
                    SqlCommand cmd = new SqlCommand("reg",con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@Action", "Insert");
                    cmd.Parameters.AddWithValue("@name", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@email", TextBox2.Text);
                    cmd.Parameters.AddWithValue("@password", TextBox3.Text);
                    cmd.Parameters.AddWithValue("@mobile", TextBox4.Text);
                    cmd.Parameters.AddWithValue("@gender", RadioButtonList1.SelectedValue);
                    cmd.Parameters.AddWithValue("@usertype", "User");
                    cmd.Parameters.AddWithValue("@image", "~/image/profile.jpg");
                    cmd.ExecuteNonQuery();
                    Response.Write("<script> alert('Registration sucessful')</script>");
                }
                Response.Redirect("login.aspx");
            }
        }
        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("showdata.aspx");
        }
    }
}
