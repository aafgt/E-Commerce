<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="removefromwishlistPage.aspx.cs" Inherits="WebProject.removefromwishlistPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="wishlist_name" runat="server" Text="Wishlist Name"></asp:Label>
        &nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="txt_wishlist_name" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
           <a href="~/customerPage.aspx" ID="Go_back" runat="server">Go Back</a> 

        </div>
        <asp:Label ID="serial" runat="server" Text="Product Serial Number"></asp:Label>
    &nbsp;&nbsp;
        <asp:TextBox ID="txt_serial_no" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="removefromwish" runat="server" Text="Remove From Wishlist" OnClick="removeFromWishlist"/>
        </p>
    </form>
</body>
</html>
