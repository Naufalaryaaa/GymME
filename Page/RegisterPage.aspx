<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RegisterPage.aspx.cs" Inherits="GymMe.Page.RegisterPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
</head>
<body>
    <form id="form1" runat="server">
        <h1>Register</h1>
        <div>
            <asp:Label ID="UsernameLbl" runat="server" Text="Username"></asp:Label>
            <asp:TextBox ID="UsernameTxt" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="EmailLbl" runat="server" Text="Email"></asp:Label>
            <asp:TextBox ID="EmailTxt" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="GenderLbl" runat="server" Text="Gender"></asp:Label>
            <asp:RadioButtonList ID="GenderRbl" runat="server">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
        </asp:RadioButtonList>
        </div>

        <div>
            <asp:Label ID="PasswordLbl" runat="server" Text="Password"></asp:Label>
            <asp:TextBox ID="PasswordTxt" runat="server" TextMode="Password"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="ConfirmPasswordLbl" runat="server" Text="Confirmation Password"></asp:Label>
            <asp:TextBox ID="ConfirmPasswordTxt" runat="server" TextMode="Password"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="DOBLbl" runat="server" Text="Date of Birth"></asp:Label>
            <asp:TextBox ID="DOBTxt" runat="server" TextMode="Date"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="ErrorLbl" runat="server"></asp:Label>
        </div>

        <div>
            <asp:Button ID="RegisterBtn" runat="server" Text="Register" OnClick="RegisterBtn_Click" />
        </div>

        <div class="sign-in">
            <asp:Label ID="have_accountLbl" runat="server" Text="Have an account?"></asp:Label>
            <asp:LinkButton ID="have_accountLb" runat="server" >Sign In</asp:LinkButton>
        </div>
    </form>
</body>
</html>
