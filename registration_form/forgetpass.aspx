<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="forgetpass.aspx.cs" Inherits="registration_form.forgertpass" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
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
   <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="card mx-auto mt-5 mb-2 d-flex" style="width: 25rem; background-color:transparent">
            <div class="card-body">
             
                <div class="co-md-6 card-text col-sm-12">
                    <div class="Login-form"></div>
                    <div class="form-group">
                        <asp:Label ID="Label1" runat="server" Text="Enter Email"></asp:Label>
                        <br />
                        <asp:TextBox ID="TextBox1" class="form-control" runat="server"></asp:TextBox>
                     </div>
                    <div>
                    </div>
                   <%-- <div class="form-group">
                        <asp:Label ID="Label2" runat="server" Text="New Password"></asp:Label>
                         <br />
                         <asp:TextBox ID="TextBox2" class="form-control" runat="server"></asp:TextBox>

                    </div>

                    <div class="form-group ">
                        <asp:Label ID="Label3" runat="server" Text="Confirm Password"></asp:Label>
                        <br />
                        <asp:TextBox ID="TextBox3" class="form-control" runat="server"></asp:TextBox>
                    </div>--%>
                    <br />
                    <div class="form-group">
                      
                        <asp:Button ID="Button1" runat="server" CssClass="btn btn-success  btn-block" Text="Submit" OnClick="Button1_Click" />
                    </div>
                    <br />
                    <div class="form-group">
                       <asp:Button ID="Button2" runat="server" CssClass="btn btn-success  btn-block" Text="Back to Login" />
                    </div>
                    </div>
                </div>
            </div>
          
       <%-- <asp:Label ID="Label1" runat="server" Text="Enter Email"></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label2" runat="server" Text="New Password"></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <br />
        <asp:Label ID="Label3" runat="server" Text="Confirm Password"></asp:Label>
        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="Button1" runat="server" Text="Button" Width="62px" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Button" />
          --%>
    </form>
</body>
</html>

