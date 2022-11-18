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
    public partial class masterpg : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lb1.Text = " Wellcome "   + Session["name"];
            if (!this.IsPostBack)
            {
                bindgrid();
            }
        }
            private void bindgrid()
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
                    Image2.ImageUrl = url;
                }


                con.Close();
            }
        }
    
}