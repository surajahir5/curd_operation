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
    public partial class changepass : System.Web.UI.Page
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7SNQED0\SQLEXPRESS;Initial Catalog=suraj;Integrated Security=True");
        string str = null;
        SqlCommand com;
        byte up;
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
 
                con.Open();
                str = "select * from register where id='" + Session["id"].ToString() + "'";
                com = new SqlCommand(str, con);
                SqlDataReader reader = com.ExecuteReader();
                while (reader.Read())
                {
                    if (TextBox1.Text == reader["password"].ToString())
                    {
                        up = 1;
                    }
                }
                reader.Close();
                con.Close();
                if (up == 1)
                {
                    con.Open();
                // str = "update register set password=@password where name='" + Session["name"].ToString() + "'";
                // com = new SqlCommand("update register set password=@password where name='" + Session["name"].ToString() + "'", con);
                com = new SqlCommand("reg", con);
                com.CommandType = CommandType.StoredProcedure;
                com.Parameters.AddWithValue("@Action", "changepass");
                com.Parameters.AddWithValue("@name", Session["name"].ToString());
                com.Parameters.Add(new SqlParameter("@Password", SqlDbType.VarChar, 50));
                com.Parameters["@Password"].Value = TextBox2.Text;
                com.ExecuteNonQuery();
                con.Close();
                Response.Write("<script>alert('assword changed Successfully')</script>");
               
                }
                else
                {
                Response.Write("<script>alert('Please enter correct Old password')</script>");
            }
            }
        }

}               //object obj = null;
                //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7SNQED0\SQLEXPRESS;Initial Catalog=suraj;Integrated Security=True");
                //{
                //    con.Open();
                //    Session["name"] = TextBox1.Text;
                //    SqlCommand cmd = new SqlCommand("select * from register where name=name and password =password", con);
                //    cmd.Parameters.AddWithValue("name", Session["name"]);
                //    cmd.Parameters.AddWithValue("password", TextBox2.Text);
                //    cmd.CommandType = CommandType.Text;
                //     //int i = cmd.ExecuteNonQuery();
                //    obj = cmd.ExecuteScalar();
                //    if (((int)(obj)) != 0)
                //    {
                //        Response.Redirect("login.aspx");
                //    }
                //    else
                //    {
                //        Label4.Text = "Invalid Username and Password";
                //    }
                //    con.Close();
                //}

