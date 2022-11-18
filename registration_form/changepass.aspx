<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/masterPg.Master" CodeBehind="changepass.aspx.cs" Inherits="registration_form.changepass" %>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<!DOCTYPE html>
<html>
<head>
    <style>
    .btn-block {
        width: 100%;
    }
    .card-text{
        margin-left: 500px
    }
    .card-text{
        background: #35477c61;
    }
    body::before {
        content: '';
        position: absolute;
        top: 0px;
        height: 700px;
        overflow: hidden;
        left: 0px;
        z-index: -9;
        width: 100%;
        background: url(image/chngepass.jpg)no-repeat center center/cover;
    }
</style>
</head>
<body>
    <form id="form1">
        <div class="card mx-auto mt-5 mb-2 d-flex" style="width: 25rem; background-color: transparent">
            <div class="card-body" >
                <h5 class="card-title">Change Password</h5>
                <div class="co-md-6 card-text col-sm-12">
                    <div class="Login-form"></div>
                    <div class="form-group" style="margin-left: 20px;">
                        <asp:Label ID="Label3" runat="server" Text="Old Password"></asp:Label>
                        <asp:TextBox ID="TextBox1" runat="server" Width="155px" TextMode="Password"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" Display="Dynamic" ErrorMessage="invalid Password" ForeColor="Red"></asp:RequiredFieldValidator>
                    </div>
                    <div class="form-group" style="margin-left: 20px;">
                        <asp:Label ID="Label8" runat="server" Text="New Password"></asp:Label>
                        <asp:TextBox ID="TextBox2" runat="server" Width="154px" TextMode="Password"></asp:TextBox>
                        <br />
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter Password" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox2" ErrorMessage="8 characters including 1 uppercase letter, 1 special character, alphanumeric characters" ForeColor="Red" ValidationExpression="^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[^A-Za-z0-9]).{6,}$"></asp:RegularExpressionValidator>
                    </div>
                    <div class="form-group" style="margin-top: -82px; margin-left: 20px;">
                        <asp:Label ID="Label9" runat="server" Text="Comfirm Password"></asp:Label>
                        <asp:TextBox ID="TextBox3" runat="server" Width="153px" TextMode="Password"></asp:TextBox>
                        <br />
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TextBox2" ControlToValidate="TextBox3" ErrorMessage="Password do not match" ForeColor="Red"></asp:CompareValidator>
                    </div>
                    <div class="form-group">
                        <asp:Button ID="Button1" runat="server" CssClass="btn btn-success  btn-block" Text="Submit" OnClick="Button1_Click" />
                    </div>
                      <br />    
                    <div class="form-group">
                        <asp:Button ID="Button2" runat="server" CssClass="btn btn-success  btn-block" Text="Reset" />
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>
</html>
        </asp:Content>  