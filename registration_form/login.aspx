<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="registration_form.login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
      /* .center{
           margin-left:auto;
           margin-right:auto;
       }*/
        
        .auto-style1 {
            height: 26px;
            width: 100px;
            color:aquamarine;
        }
        
        .auto-style2 {
            width: 390px;
        }
        .auto-style3 {
            height: 26px;
            width: 390px;
        }  
        .loginbox{
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
            background: linear-gradient(45deg, #0000008f, transparent);
            color: aqua;
     }
        .auto-style4 {
            width: 100px;
            color:aquamarine;

        }
        .Label3{
            padding:0;
            margin:0;
            text-align:center;
            color:springgreen
        }
        .user{
            width:50%;
            height:50%;
            margin-top:-2rem;
            overflow:hidden;
            top:calc(-100px/2);
            left:calc(50% - 50px);
           position:center;
        }
        #TextBox1 , #TextBox2{
            background-color:transparent;
            width: 194px;
            border-bottom:solid 2px black;
    padding: 6px;
    margin-left: 19px;
    overflow:hidden;
}
        #Button1{    
    height: 28px;
    width: 88px;
    margin-top: 17px;
    margin-left: -61px
        }
        #Button2{
            height: 28px;
    width: 88px;
    margin-left: -44px
        }
        
    </style>
</head>
<body style="margin-left: auto; margin-right: auto; position:relative; background-size:cover; text-align: center; background-image: url('image/login.png'); background-repeat: no-repeat;" >
      
        <div class="loginbox">
            <img src="image/cus.jpg" class="user" />
            <br />
    <asp:Label ID="Label3" runat="server" Text="Login form" Font-Bold="true" Font-Size="X-Large"
        CssClass="StrongText"></asp:Label>
  <form id="form1" runat="server">
     <br />
            <table>
                <tr>
                   <%-- <td class="auto-style4">Enter Name</td>--%>
                   
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox1" runat="server" Width="166px" placeholder="Enter Name" ValidationGroup="reg"  ForeColor="Black"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="Enter Your Name" ForeColor="Red" ValidationGroup="reg"></asp:RequiredFieldValidator>
                    &nbsp;</td>
                    
                </tr>
                <tr>
                    <%--<td class="auto-style1">EnterPassword</td>--%>
                    <td class="auto-style2">
                        <asp:TextBox ID="TextBox2" runat="server" TextMode="Password" Width="165px" placeholder="Enter Password" ValidationGroup="reg"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" Display="Dynamic" ErrorMessage="Enter Your Password" ForeColor="Red" ValidationGroup="reg"></asp:RequiredFieldValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:Button ID="Button1" runat="server" Height="25px" Text="Login" Width="93px" OnClick="Button1_Click" ValidationGroup="reg" BackColor="#009933" ForeColor="Black" />
                        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                    </td>
                    <td class="auto-style2">&nbsp;&nbsp;
                        <asp:Button ID="Button2" runat="server" Height="28px" Text="Register" Width="88px" OnClick="Button2_Click" BackColor="#009933" />
                    </td>
                </tr>
                
            </table>
            <asp:LinkButton ID="LinkButton1" href="forgetpass.aspx" runat="server" ForeColor="Red">Forget Password?</asp:LinkButton>
            <br />
           &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        </div>
    </form>
</body>
</html>
