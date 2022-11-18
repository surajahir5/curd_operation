using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Net;
using System.Net.Mail;
using System.Drawing;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace registration_form
{
    public partial class forgertpass : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          try
                {
                    DataSet ds = new DataSet();
                    using (SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7SNQED0\SQLEXPRESS;Initial Catalog=suraj;Integrated Security=True"))
                    {
                        con.Open();
                        SqlCommand cmd = new SqlCommand("SELECT name,password FROM register Where email= '" + TextBox1.Text.Trim() + "'", con);
                        SqlDataAdapter da = new SqlDataAdapter(cmd);
                        da.Fill(ds);
                        con.Close();
                    }
                    if (ds.Tables[0].Rows.Count > 0)
                    {
                        MailMessage Msg = new MailMessage();
                        // Sender e-mail address.
                        Msg.From = new MailAddress(TextBox1.Text);
                        // Recipient e-mail address.
                        Msg.To.Add(TextBox1.Text);
                        Msg.Subject = "Your Password Details";
                        Msg.Body = "Hi, <br/>Please check your Login Detailss<br/><br/>Your name: " + ds.Tables[0].Rows[0]["name"] + "<br/><br/>Your password: " + ds.Tables[0].Rows[0]["password"] + "<br/><br/>";
                        Msg.IsBodyHtml = true;
                        // your remote SMTP server IP.
                        SmtpClient smtp = new SmtpClient();
                        smtp.Host = "smtp.gmail.com";
                        smtp.Port = 587;
                    smtp.UseDefaultCredentials = false;
                    smtp.Credentials = new System.Net.NetworkCredential("yourusername@gmail.com", "yourpassword");
                        smtp.EnableSsl = true;
                        smtp.Send(Msg);
                    Response.Write("<script>alert('Password has been sent to your email address.');window.location ='../login.aspx';</script>");
                    //Msg = null;
                    // lbltxt.Text = "Your Password Details Sent to your mail";
                    // Clear the textbox valuess
                    TextBox1.Text = "";
                    }
                    else
                    {
                    Response.Write("<script>alert('This email address does not match our records.')</script>");
                    //lbltxt.Text = "The Email you entered not exists.";
                }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("{0} Exception caught.", ex);
                }
            }
            //string name = string.Empty;
            //string password = string.Empty;
            //SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-7SNQED0\SQLEXPRESS;Initial Catalog=suraj;Integrated Security=True");
            //{
            //    SqlCommand cmd = new SqlCommand("SELECT email, [password] FROM register WHERE email = @email");
            //    {
            //        cmd.Parameters.AddWithValue("@email", TextBox1.Text.Trim());

            //        cmd.Connection = con;
            //        con.Open();
            //        using (SqlDataReader sdr = cmd.ExecuteReader())
            //        {
            //            if (sdr.Read())
            //            {
            //                string username = sdr["email"].ToString();
            //               password = sdr["password"].ToString();
            //            }
            //        }
            //        con.Close();
            //    }

            //    if (!string.IsNullOrEmpty(password))
            //    {
            //        MailMessage mm = new MailMessage("sender@gmail.com", TextBox1.Text.Trim());

            //        mm.Subject = "Password Recovery";
            //        mm.Body = string.Format("Hi {0},<br /><br />Your password is {1}.<br /><br />Thank You.", name, password);
            //        mm.IsBodyHtml = true;
            //        SmtpClient smtp = new SmtpClient();
            //        smtp.Host = "smtp.office365.com";
            //        smtp.EnableSsl = true;

            //        NetworkCredential NetworkCred = new NetworkCredential("email", "password");
            //        NetworkCred.UserName = "sender@gmail.com";
            //       NetworkCred.Password = "<Password>";
            //        smtp.UseDefaultCredentials = true;
            //        smtp.Credentials = NetworkCred;
            //        smtp.Port = 587;

            //        smtp.Send(mm);


            //        Response.Write("<script>alert('Password has been sent to your email address.');window.location ='../login.aspx';</script>");
            //       // Response.Redirect("login.aspx");
            //        //Label2.ForeColor = Color.Green;
            //        //Label2.Text = "Password has been sent to your email address.";
            //    }
            //    else
            //    {
            //        Response.Write("<script>alert('This email address does not match our records.')</script>");
            //        //Label2.ForeColor = Color.Red;
            //        //Label2.Text = "This email address does not match our records.";
            //    }
            //}

        }
    }
