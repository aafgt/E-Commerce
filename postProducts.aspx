<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="postProducts.aspx.cs" Inherits="WebProject.postProducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            
            <asp:Button ID="Button2" runat="server" Text="Log out" OnClick="Button2_Click" />
            
            <br />
            <br />
            <asp:Label ID="lbl_product_name" runat="server" Text="Product _name : "></asp:Label>
    
        <asp:TextBox ID="txt_product_name" runat="server"></asp:TextBox>
    
        <br />
    
        <br />
        <asp:Label ID="lbl_category" runat="server" Text="Category: "></asp:Label>
        <asp:TextBox ID="txt_category" runat="server"></asp:TextBox>
    
        <br />

        <br />
        <asp:Label ID="lbl_product_description" runat="server" Text =" Product_description: "></asp:Label>
        <asp:TextBox ID="txt_product_description" runat="server"></asp:TextBox>
    
        <br />

        <br />
        <asp:Label ID="lbl_price" runat="server" Text="Price: "></asp:Label>
        <asp:TextBox ID="txt_price" runat="server"></asp:TextBox>
    
        <br />

            <br />
        <asp:Label ID="lbl_colour" runat="server" Text="Colour: "></asp:Label>
        <asp:TextBox ID="txt_colour" runat="server"></asp:TextBox>
    
        <br />

        <br />
        <asp:Button ID="Button1" runat="server" Text="Post" onclick="postProduct" Width="90px"/>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink2" NavigateUrl="https://localhost:44396/viewProducts.aspx" runat="server">View your products</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink3" NavigateUrl="https://localhost:44396/editProducts.aspx" runat="server">Edit your products</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink4" NavigateUrl="https://localhost:44396/allAboutOffers.aspx" runat="server">Go to the Offers page</asp:HyperLink>
            <br />
        </div>
    </form>
</body>


</html>
