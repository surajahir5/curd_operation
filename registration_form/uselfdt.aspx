<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/masterPg.Master" CodeBehind="uselfdt.aspx.cs" Inherits="registration_form.uselfdt" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <!DOCTYPE html>

<html>
<head>
    <title></title>
    <style type="text/css">

        body{
            background-image:url('/image/chngepass.jpg');
            background-repeat:no-repeat;
            background-size:cover;
        }
        .card{
             margin-left:auto;
            margin-right:auto;
            margin-top: 3rem;
            /*position:absolute;*/
            top:50%;
            left:50%;
            transform:translate(-50,-50);
            width:350px;
            height:420px;
            padding:80px 40px;
            box-sizing:border-box;
            background: linear-gradient(45deg, #0dbff1, #0000004f););
           
        }
    </style>
</head>
<body>
    <form id="form1">
        <div class="card mx-auto mt-5 mb-2 d-flex">
          
             <div class="form-group">
                 <asp:Label ID="Label3" runat="server" Text="Name"></asp:Label>
                        <br />
                        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>      
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Enter Name" ForeColor="Red" Display="Dynamic" ValidationGroup="reg"></asp:RequiredFieldValidator>
                   
             </div>
                   <div class="form-group">     
                   <asp:Label ID="Label1" runat="server" Text="Email"></asp:Label>
                  
                        <br />
                  
                        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter Email" ForeColor="Red" Display="Dynamic" ValidationGroup="reg"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="email is required" ForeColor="Red" ValidationExpression="^[a-zA-Z0-9+_.-]+@[a-zA-Z0-9.-]+$" Display="Dynamic" ValidationGroup="reg"></asp:RegularExpressionValidator>
                   </div>
               <div class="form-group">
                     <asp:Label ID="Label2" runat="server" Text="Mobile No"></asp:Label>
                        <br />
                        <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Enter Mobile number" ForeColor="Red" Display="Dynamic" ValidationGroup="reg"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="TextBox3" ErrorMessage="Invalid Number" ForeColor="Red" ValidationExpression="(^[0-9]{10}$)|(^\+[0-9]{2}\s+[0-9]{2}[0-9]{8}$)|(^[0-9]{3}-[0-9]{4}-[0-9]{4}$)" Display="Dynamic" ValidationGroup="reg"></asp:RegularExpressionValidator>
                 </div>
               <div class="form-group">
                   <asp:Label ID="Label4" runat="server" Text="Gender"></asp:Label>
                        <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                            <asp:ListItem>Male</asp:ListItem>
                            <asp:ListItem>Female</asp:ListItem>
                            <asp:ListItem>Other</asp:ListItem>
                        </asp:RadioButtonList>
            </div>
                 
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Update" Width="89px" />
        </div>
    </form>
</body>
</html>
</asp:Content>