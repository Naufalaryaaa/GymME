<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="GymMe.Page.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    <link href="../Style/LoginPageStyle.css" rel="stylesheet" />

</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h1>Login</h1>
            <div class="form">
                <asp:Label ID="UsernameLbl" runat="server" Text="Username" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="UsernameTxt" runat="server" placeholder="Input Your Username" CssClass="input-box"></asp:TextBox>
            </div>
            <div class="form">
                <asp:Label ID="PasswordLbl" runat="server" Text="Password" CssClass="form-label"></asp:Label>
                <asp:TextBox ID="PasswordTxt" runat="server" TextMode="Password" placeholder="Input Your Password" CssClass="input-box"></asp:TextBox>
            </div>
            <div class="form-check">
                <asp:CheckBox ID="RememberCb" runat="server" />
                <asp:Label ID="RememberLbl" runat="server" Text="Remember me"></asp:Label>
            </div>
            <div>
                <asp:Label ID="ErrorLbl" runat="server"></asp:Label>
            </div>
            <div>
                <asp:Button ID="LoginBtn" runat="server" Text="Login" OnClick="LoginBtn_Click" CssClass="LoginBtn"/>
            </div>
            <div class="sign-up">
                <asp:Label ID="dont_have_accountLbl" runat="server" Text="Don't have an account?"></asp:Label>
                <asp:LinkButton ID="dont_have_accountLb" runat="server" OnClick="dont_have_accountLb_Click">Sign Up</asp:LinkButton>
            </div>
        </div>
    </form>
</body>
</html>
