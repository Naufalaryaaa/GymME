<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Customer.Master" AutoEventWireup="true" CodeBehind="ProfilePageCustomer.aspx.cs" Inherits="GymMe.Page.ProfilePageCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      <h2>Profile</h2>
          <div>
              <strong>Username: </strong>
              <asp:Label ID="UsernameLbl" runat="server"></asp:Label>
          </div>

          <div>
              <strong>Email: </strong>
              <asp:Label ID="EmailLbl" runat="server"></asp:Label>
          </div>

          <div>
              <strong>Gender: </strong>
              <asp:Label ID="GenderLbl" runat="server"></asp:Label>
          </div>

          <div>
              <strong>Date of Birth: </strong>
              <asp:Label ID="DOBLbl" runat="server"></asp:Label>
          </div>

          <div>
              <asp:Button ID="UpdateBtn" runat="server" Text="Update Profile"/>
          </div>
</asp:Content>
