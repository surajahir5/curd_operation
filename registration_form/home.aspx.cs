
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
    public partial class home : System.Web.UI.Page
    {
        [Obsolete]
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!this.IsPostBack)
            {
                databind();
            }
        }
        [Obsolete]
        private void databind()
        {

            SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7SNQED0\SQLEXPRESS;Initial Catalog=suraj;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("seleuser", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", Session["id"].ToString());
            SqlDataAdapter ad = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            ad.Fill(ds);
            GridView2.DataSource = ds;
            GridView2.DataBind();
            con.Close();
            // string idd = Session["id"].ToString();

            // SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7SNQED0\SQLEXPRESS;Initial Catalog=suraj;Integrated Security=True");
            // // string query = "Select * from register where id != @Id and  usertype = 'user'";
            // string query = "user_update";
            // SqlCommand cmd = new SqlCommand(query, con);
            // cmd.CommandType = CommandType.StoredProcedure;
            // //cmd.CommandText = query;
            // //cmd.CommandType = CommandType.Text;
            // //cmd.Connection = con;          
            // con.Open();
            // SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            // //cmd.Parameters.Add("@Id", SqlDbType.Int).Value = idd;
            // //cmd.Parameters.Add("@Id",idd);
            //// cmd.ExecuteNonQuery();
            // //int io = Convert.ToInt32(idd);
            // DataSet ds = new DataSet();
            // //adapter.Fill(ds);
            // GridView2.DataSource = ds;
            // GridView2.DataBind();
            // con.Close();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("changepass.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("uselfdt.aspx");
        }
    }
}