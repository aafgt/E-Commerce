<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="applyOffers.aspx.cs" Inherits="WebProject.applyOffers" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:Label ID="Label1" runat="server" Text="Offer ID: "></asp:Label>
&nbsp;<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" Text="Log out" OnClick="Button2_Click" />
        <br />
        <br />
        <asp:Label ID="Label2" runat="server" Text="Product Serial Number: "></asp:Label>
        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        <div>
        </div>
        <asp:Button ID="Button1" Onclick="applyOffer" runat="server" Text="Apply" />
        <br />
        <br />
        <asp:HyperLink ID="HyperLink1" NavigateUrl="https://localhost:44396/createOffers.aspx" runat="server">Create Offers</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink2" NavigateUrl="https://localhost:44396/viewOffers.aspx" runat="server">View Offers</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink3" NavigateUrl="https://localhost:44396/removeExpiredOffer.aspx" runat="server">Remove Expired Offer</asp:HyperLink>
        <br />
        <br />
        <asp:HyperLink ID="HyperLink4" NavigateUrl="https://localhost:44396/mainPage.aspx" runat="server">Post/Edit/View your products</asp:HyperLink>
    </form>
</body>
</html>
