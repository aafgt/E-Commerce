<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="vendorPage.aspx.cs" Inherits="WebProject.vendorPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <h1>Login Successful&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Log out" />
        </h1>
        <div style="height: 15px">
        </div>
        <asp:HyperLink ID="HyperLink2" NavigateUrl="https://localhost:44396/postProducts.aspx" runat="server">Post your products</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink3" NavigateUrl="https://localhost:44396/viewProducts.aspx" runat="server">View your products</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink4" NavigateUrl="https://localhost:44396/editProducts.aspx" runat="server">Edit your products</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink6" NavigateUrl="https://localhost:44396/allAboutOffers.aspx" runat="server">Create/Apply/Remove your offers </asp:HyperLink>
    </form>
</body></html>
