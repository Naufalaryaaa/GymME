<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Main.Master" AutoEventWireup="true" CodeBehind="ProfilePage.aspx.cs" Inherits="GymMe.Page.ProfilePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h2>Profile</h2>
    <div class="profile">
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
            <asp:Label ID="DOBLbl" runat="server" Text="Date of Birth"></asp:Label>
            <asp:TextBox ID="DOBTxt" runat="server" TextMode="Date"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="ErrorLbl" runat="server" ></asp:Label>
        </div>    

        <div>
            <asp:Button ID="UpdateBtn" runat="server" Text="Update Profile" OnClick="UpdateBtn_Click" />
        </div>
    </div>

    <h2>Update Password</h2>
    <div class="password">
        <div>
            <asp:Label ID="OldPasswordLbl" runat="server" Text="Old Password"></asp:Label>
            <asp:TextBox ID="OldPasswordTxt" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="NewPasswordLbl" runat="server" Text="New Password"></asp:Label>
            <asp:TextBox ID="NewPasswordTxt" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Button ID="UpdatePasswordBtn" runat="server" Text="Update Password" />
        </div>
    </div>
</asp:Content>
