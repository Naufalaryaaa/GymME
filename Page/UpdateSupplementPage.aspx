<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateSupplementPage.aspx.cs" Inherits="GymMe.Page.UpdateSupplement" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <h2>Update Supplement</h2>
        <div>
            <asp:Button ID="BackBtn" runat="server" Text="Back" OnClick="BackBtn_Click" />
        </div>

        <div>
            <asp:Label ID="NameLbl" runat="server" Text="Name"></asp:Label>
            <asp:TextBox ID="NameTxt" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="ExpiryDateLbl" runat="server" Text="Expiry Date"></asp:Label>
            <asp:TextBox ID="ExpiryDateTxt" runat="server" TextMode="Date"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="PriceLbl" runat="server" Text="Price"></asp:Label>
            <asp:TextBox ID="PriceTxt" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="TypeLbl" runat="server" Text="Type"></asp:Label>
            <asp:TextBox ID="TypeTxt" runat="server"></asp:TextBox>
        </div>

        <div>
            <asp:Label ID="ErrorLbl" runat="server" ></asp:Label>
        </div>
    
        <div>
            <asp:Button ID="UpdateBtn" runat="server" Text="Update" OnClick="UpdateBtn_Click" />
        </div>
    </form>
</body>
</html>
