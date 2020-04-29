<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createOffers.aspx.cs" Inherits="WebProject.createOffers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 680px">
            <asp:Button ID="Button2" runat="server" Text="Log out" OnClick="Button2_Click" />
        </div>
        <asp:Label ID="Label1" runat="server" Text="Offer Amount: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Expiry Date: "></asp:Label>
        &nbsp;<asp:TextBox ID="Date" runat="server" TextMode="DateTimeLocal"></asp:TextBox>
        <div style="margin-left: 80px">
        </div>
        <asp:Button ID="Button1" OnClick="createOffer" runat="server" Text="Create Offer" />
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" NavigateUrl="https://localhost:44396/applyOffers.aspx" runat="server">Apply Offers</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink2" NavigateUrl="https://localhost:44396/viewOffers.aspx" runat="server">View Offers</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink3" NavigateUrl="https://localhost:44396/removeExpiredOffer.aspx" runat="server">Remove Expired Offer</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink4" NavigateUrl="https://localhost:44396/mainPage.aspx" runat="server">Post/View/Edit your products</asp:HyperLink>
    </form>
</body>
</html>
