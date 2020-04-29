<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewProducts.aspx.cs" Inherits="WebProject.viewProducts" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 720px">
            <asp:Button ID="Button2" runat="server" Text="Log out" OnClick="Button2_Click" />
            <br />
        </div>
        <asp:Button ID="Button1" runat="server" Text="View" onclick="vendorviewProducts" Width="90px"/>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink2" NavigateUrl="https://localhost:44396/postProducts.aspx" runat="server">Post your products</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink3" NavigateUrl="https://localhost:44396/editProducts.aspx" runat="server">Edit your products</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink5" NavigateUrl="https://localhost:44396/allAboutOffers.aspx" runat="server">Go to the Offers page</asp:HyperLink>
        <br />
        <br />
            <asp:GridView ID="GridView1" runat="server">
            </asp:GridView>
    </form>
</body>

</html>
