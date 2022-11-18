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
    public partial class uselfdt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                PopulateFields();
            }                
        }

        private void PopulateFields()
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7SNQED0\SQLEXPRESS;Initial Catalog=suraj;Integrated Security=True");
            DataTable dt = new DataTable();
            con.Open();
            SqlDataReader myReader = null;
            SqlCommand cmd = new SqlCommand("select * from register where name='" + Session["name"] + "'", con);
          //  SqlCommand cmd = new SqlCommand("reg", con);
            myReader = cmd.ExecuteReader();
            while (myReader.Read())
            {
                TextBox1.Text = (myReader["name"].ToString());
                TextBox2.Text = (myReader["email"].ToString());
                TextBox3.Text = (myReader["mobile"].ToString());
                RadioButtonList1.SelectedValue = (myReader["gender"].ToString());
            }
            con.Close();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7SNQED0\SQLEXPRESS;Initial Catalog=suraj;Integrated Security=True");
            // SqlCommand cmd = new SqlCommand("update register SET name=@name, email=@email, mobile=@mobile, gender=@gender where name='" +  Session["name"].ToString() + "'", con);
            SqlCommand cmd = new SqlCommand("reg", con);      
            cmd.CommandType = CommandType.StoredProcedure;
            con.Open();
            cmd.Parameters.AddWithValue("@Action", "upuser");
            cmd.Parameters.AddWithValue("@id", Session["id"].ToString());
            cmd.Parameters.AddWithValue("@name", TextBox1.Text);
            cmd.Parameters.AddWithValue("@email", TextBox2.Text);
            cmd.Parameters.AddWithValue("@mobile", TextBox3.Text);
            cmd.Parameters.AddWithValue("@gender", RadioButtonList1.Text);
            cmd.ExecuteNonQuery();
            con.Close();
            Response.Write("<script>alert('Data Update Sucessful')</script>");
            if (IsPostBack)
            {
                Response.Redirect("home.aspx");
            }
            else
            {
                Response.Write("<script>alert('Data Update UnSucessful')</script>");
            }
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
}