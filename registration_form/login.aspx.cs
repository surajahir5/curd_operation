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
    public partial class login : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("register.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7SNQED0\SQLEXPRESS;Initial Catalog=suraj;Integrated Security=True");
            {
                con.Open();
               // SqlCommand cmd = new SqlCommand("select * from register where name=@name and password=@password ", con);
                SqlCommand cmd = new SqlCommand("login_pro", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@name", TextBox1.Text);
                cmd.Parameters.AddWithValue("@password", TextBox2.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Session["id"] = dr.GetValue(0).ToString();
                        Session["usertype"] = dr.GetValue(6).ToString();
                        Session["name"] = dr.GetValue(1).ToString();
                        Response.Write("<script> alert('login sucessful')</script>");
                    }
                    if (Session["usertype"].Equals("Admin"))
                    {
                        Response.Redirect("admin.aspx");
                    }
                    else
                    {
                        Response.Redirect("home.aspx");
                    }

                }
                else
                {
                    Response.Write("<script> alert('Invalid Credentials')</script>");
                }

                dr.Close();
                cmd.ExecuteNonQuery();



            }
        }
    }
}