<%@ Page Title="" Language="C#" MasterPageFile="~/Master/Customer.Master" AutoEventWireup="true" CodeBehind="OrderPage.aspx.cs" Inherits="GymMe.Page.OrderPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>
        Product
    </h1>

    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
        <Columns>
            <asp:BoundField DataField="MsSupplementType.SupplementTypeName" HeaderText="Supplement Type Name" SortExpression="MsSupplementType.SupplementTypeName"></asp:BoundField>
            <asp:BoundField DataField="SupplementID" HeaderText="Supplement ID" SortExpression="SupplementID"></asp:BoundField>
            <asp:BoundField DataField="SupplementName" HeaderText="Supplement Name" SortExpression="SupplementName"></asp:BoundField>
            <asp:BoundField DataField="SupplementExpiryDate" HeaderText="Expired Date" SortExpression="SupplementExpiryDate"></asp:BoundField>
            <asp:BoundField DataField="SupplementPrice" HeaderText="Price" SortExpression="SupplementPrice"></asp:BoundField>
            

            
            <asp:TemplateField HeaderText="Order">
                <ItemTemplate>
                    <asp:Button ID="AddBtn" runat="server" Text="Order" UseSubmitBehavior="false" CommandName="Select" />                  
                </ItemTemplate>
            </asp:TemplateField>
       
            
        </Columns>
    </asp:GridView>

    <div>
        <asp:Label ID="supplementTypeNameLbl" runat="server" Text="Suplement Type Name: "></asp:Label>
        <asp:TextBox ID="supplementTypeNametxt" runat="server"></asp:TextBox>
    </div>
    <div>
        <asp:Label ID="supplementIdLbl" runat="server" Text="Supplement Id: "></asp:Label>
        <asp:TextBox ID="supplementIdtxt" runat="server"></asp:TextBox>
    </div>
     <div>
         <asp:Label ID="supplementNameLbl" runat="server" Text="Supplement Name: "></asp:Label>
         <asp:TextBox ID="supplementNametxt" runat="server"></asp:TextBox>
     </div>
    
     <div>
         <asp:Label ID="Quantitytxt" runat="server" Text="Label"></asp:Label>
         <asp:TextBox ID="quantitytxtkedua" runat="server" TextMode="Number"></asp:TextBox>
     </div>

    <div>
        <asp:Button ID="AddCartBtn" runat="server" Text="Add To Chart" OnClick="AddCartBtn_Click" />
    </div>
     
    <div>
        <asp:Label ID="ErrorLbl" runat="server"></asp:Label>
    </div>

    <br />
    <br />

    <h1>Cart</h1>
    <div>
        <asp:Button ID="CheckOutBtn" runat="server" Text="Check Out" OnClick="CheckOutBtn_Click" />
        <asp:Button ID="ClearBtn" runat="server" Text="Clear" OnClick="ClearBtn_Click" />
    </div>
    <br />
    <asp:GridView ID="GridView2" runat="server" AutoGenerateColumns="false"> 
        <Columns>
            <asp:BoundField DataField="UserID" HeaderText="User Id" SortExpression="UserID"></asp:BoundField>
            <asp:BoundField DataField="CartID" HeaderText="Cart Id" SortExpression="CartID"></asp:BoundField>
            <asp:BoundField DataField="SuplementID" HeaderText="Supplement id" SortExpression="SuplementID"></asp:BoundField>
            <asp:BoundField DataField="Quantity" HeaderText="Quantity" SortExpression="Quantity"></asp:BoundField>
        </Columns>
    </asp:GridView>
   
    
</asp:Content>
