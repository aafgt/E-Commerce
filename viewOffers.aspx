<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewOffers.aspx.cs" Inherits="WebProject.viewOffers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 720px">
            <asp:Button ID="Button2" runat="server" Text="Log out" OnClick="Button2_Click" />
        </div>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        <asp:Button ID="Button1" OnClick="viewOffers" runat="server" Text="View" />
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" NavigateUrl="https://localhost:44396/applyOffers.aspx" runat="server">Apply Offer</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink2" NavigateUrl="https://localhost:44396/createOffers.aspx" runat="server">Create Offer</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink3" NavigateUrl="https://localhost:44396/removeExpiredOffer.aspx" runat="server">Remove Expired Offer</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink4" NavigateUrl="https://localhost:44396/mainPage.aspx" runat="server">Post/Edit/View your products</asp:HyperLink>
    </form>
</body>
</html>
