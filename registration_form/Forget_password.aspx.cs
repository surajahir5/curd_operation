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
                    string to = TextBox1.Text; //To address
                    string from = "rahulpaljobs@gmail.com"; //From address
                    MailMessage message = new MailMessage(from, to);

                    string mailbody = "Hi, <br/>Please check your Login Detailss<br/><br/>Your name: " + ds.Tables[0].Rows[0]["name"] + "<br/><br/>Your password: " + ds.Tables[0].Rows[0]["password"] + "<br/><br/>";
                    message.Subject = "Forget Password";
                    message.Body = mailbody;
                    message.BodyEncoding = Encoding.UTF8;
                    message.IsBodyHtml = true;
                    SmtpClient client = new SmtpClient("smtp.gmail.com", 587); //Gmail smtp
                    System.Net.NetworkCredential basicCredential1 = new
                    System.Net.NetworkCredential("rahulpaljobs@gmail.com", "kbvhmihftjmnwquc");
                    client.EnableSsl = true;
                    client.UseDefaultCredentials = false;
                    client.Credentials = basicCredential1;
                    try
                    {
                        client.Send(message);
                        Response.Write("<script>alert('Password has been sent to your email address.');window.location ='../login.aspx';</script>");
                    }

                    catch (Exception ex)
                    {
                        throw ex;
                    }
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
