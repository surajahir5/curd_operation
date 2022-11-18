<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="register.aspx.cs" Inherits="registration_form.WebForm1" %>
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
         <style>
        .btn-block{
            width:100%;
        }
 body::before{ 
            content: '';
    position: absolute;
    top: 0px;
    height: 700px;
    overflow:hidden;
    left: 0px;
    z-index: -9;
    width: 100%;
    background: url(image/regback.jpg)no-repeat center center/cover;

        }
 .card-body{
         background: linear-gradient(45deg, #0d6efd, #0dcaf0f2);
 }
    </style>   
</head>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous"/>
<body>
    <form id="form1" runat="server">
        <div class="card mx-auto mt-5 mb-2 d-flex" style="width: 25rem; background-color:transparent">
            <div class="card-body">
                <h5 class="card-title">Registration Form</h5>
                <div class="co-md-6 card-text col-sm-12">
                    <div class="Login-form"></div>
                    <div class="form-group">
                        <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label>
                        <asp:TextBox ID="TextBox1" runat="server" CssClass="form-control" ValidationGroup="reg"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Name is required" ForeColor="Red" ValidationGroup="reg">Enter Your Name</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator4" runat="server" ControlToValidate="TextBox1" ErrorMessage="Allow only character" ForeColor="Red" ValidationExpression="^[a-zA-Z''-'\s]{1,40}$" ValidationGroup="reg"></asp:RegularExpressionValidator>
                    </div>
                    <div class="form-group" style="margin-top: -10px;">
                        <asp:Label ID="Label8" runat="server" Text="Email"></asp:Label>
                        <asp:TextBox ID="TextBox2" runat="server" CssClass="form-control" TextMode="Email" ValidationGroup="reg"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="Please enter proper email" ForeColor="Red" ValidationGroup="reg">Enter Your Email </asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="email is required" ForeColor="Red" ValidationExpression="^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$" ValidationGroup="reg"></asp:RegularExpressionValidator>
                    </div>

                    <div class="form-group">
                        <asp:Label ID="Label9" runat="server" Text="password"></asp:Label>
                        <asp:TextBox ID="TextBox3" runat="server" CssClass="form-control" TextMode="Password" ValidationGroup="reg"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="Enter Password" ForeColor="Red" ValidationGroup="reg"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox3" Display="Dynamic" ErrorMessage="8 characters including 1 uppercase letter, 1 special character, alphanumeric characters" ForeColor="Red" ValidationExpression="^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^A-Za-z0-9]).{6,}$" ValidationGroup="reg"></asp:RegularExpressionValidator>
                    </div>


                    <div class="form-group">
                        <asp:Label ID="Label10" runat="server" Text="Mobile No"></asp:Label>
                        <asp:TextBox ID="TextBox4" runat="server" MaxLength="10" CssClass="form-control" TextMode="Phone" ValidationGroup="reg"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="Please enter 10 digit Mobile No." ForeColor="Red" ValidationGroup="reg">Enter Your Mobile</asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox4" Display="Dynamic" ErrorMessage="Please enter 10 digit Mobile No" ForeColor="Red" ValidationExpression="\d{10}" ValidationGroup="reg"></asp:RegularExpressionValidator>
                    </div>

                    <div class="form-group ">
                        <asp:Label ID="Label11" runat="server" Text="Gender"></asp:Label>
                        <asp:RadioButtonList ID="RadioButtonList1" CssClass="form-control" runat="server" RepeatDirection="Horizontal" ValidationGroup="reg">
                            <asp:ListItem class="me-3">Male</asp:ListItem>
                            <asp:ListItem class="me-3">Female</asp:ListItem>
                            <asp:ListItem class="me-3">Others</asp:ListItem>
                        </asp:RadioButtonList>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="RadioButtonList1" Display="Dynamic" ErrorMessage="Gender is required" ForeColor="Red" ValidationGroup="reg">Select Your Gender</asp:RequiredFieldValidator>
                    </div>
                    <br />
                    <div class="form-group">
                        <asp:Button ID="Button1" runat="server" CssClass="btn btn-success  btn-block" OnClick="Button1_Click" Text="Submit" ValidationGroup="reg" />
                    </div>
                    <br />
                    <div class="form-group">
                        <asp:Button ID="Button2" runat="server" CssClass="btn btn-success  btn-block" CausesValidation="False" OnClientClick="this.form.reset();return false;" Text="Reset" ValidationGroup="reg" />

                    </div>
                   
                </div>
            </div>
        </div>
    </form>
</body>
</html>



  


  
