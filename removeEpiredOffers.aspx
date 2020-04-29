<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="removeEpiredOffers.aspx.cs" Inherits="WebProject.removeEpiredOffers" %>

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
        <asp:Label ID="Label1" runat="server" Text="Offer ID: "></asp:Label>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Button1" Onclick="removeExpiredOffer" runat="server" Text="Remove" />
        </p>
        <asp:HyperLink ID="HyperLink1" NavigateUrl="https://localhost:44396/applyOffers.aspx" runat="server">Apply Offers</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink2" NavigateUrl="https://localhost:44396/createOffers.aspx" runat="server">Create Offers</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink3" NavigateUrl="https://localhost:44396/viewOffers.aspx" runat="server">View Offers</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink4" NavigateUrl="https://localhost:44396/mainPage.aspx" runat="server">Post/Edit/View your products</asp:HyperLink>
    </form>
</body>
</html>
