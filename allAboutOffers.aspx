<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="allAboutOffers.aspx.cs" Inherits="WebProject.allAboutOffers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" Text="Log out" OnClick="Button1_Click" style="height: 26px" />
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" NavigateUrl="https://localhost:44396/createOffers.aspx" runat="server">Create Offers</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink2" NavigateUrl="https://localhost:44396/applyOffers.aspx" runat="server">Apply Offer on Product</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink3" NavigateUrl="https://localhost:44396/removeExpiredOffer.aspx" runat="server">Remove Expired Offer</asp:HyperLink>
            <br />
            <br />
            <asp:HyperLink ID="HyperLink6" NavigateUrl="https://localhost:44396/viewOffers.aspx" runat="server">View your offers</asp:HyperLink>
            <br />
            <br />
            <br />
            <asp:HyperLink ID="HyperLink4" NavigateUrl="https://localhost:44396/mainPage.aspx" runat="server">Post/View/Edit your products</asp:HyperLink>
            <br />
        </div>
    </form>
</body>
</html>
