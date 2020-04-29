<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="activateVendor.aspx.cs" Inherits="WebProject.activateVendor" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body style="height: 104px">
    <form id="form1" runat="server">
        <asp:HyperLink href="/adminPage.aspx" ID="goback" runat="server">Go Back</asp:HyperLink>
        <div>
            <asp:Label ID="Label2_vendor" runat="server" Text="vendor username:"></asp:Label>
            <asp:TextBox ID="TextBox2_vendor" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="activate" Width="77px" />
        </div>
    </form>
</body>
</html>
