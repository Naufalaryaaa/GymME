<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Customer.Master" AutoEventWireup="true" CodeBehind="HomePageCustomer.aspx.cs" Inherits="GymMe.Page.HomePageCustomer" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        Welcome
    </h1>

    <div>
        <strong>Role: </strong>
        <asp:Label ID="RoleLbl" runat="server"></asp:Label>
    </div>
</asp:Content>
