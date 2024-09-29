<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Customer.Master" AutoEventWireup="true" CodeBehind="HistoryPage.aspx.cs" Inherits="GymMe.Page.HistoryPage1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
             <asp:BoundField DataField="TransactionHeader.TransactionID" HeaderText="Transaction Id" SortExpression="TransactionHeader.TransactionID"></asp:BoundField>
             <asp:BoundField DataField="UserID" HeaderText="User Id" SortExpression="UserID"></asp:BoundField>
             <asp:BoundField DataField="TransactionDate" HeaderText="Transaction Date" SortExpression="TransactionDate"></asp:BoundField>
             <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status"></asp:BoundField>
             <asp:TemplateField HeaderText="Detail">
                <ItemTemplate>
                    <asp:Button ID="DetailBtn" runat="server" Text="Order" UseSubmitBehavior="false" CommandName="Select" />
                </ItemTemplate> 
             </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
