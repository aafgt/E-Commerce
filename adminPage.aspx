<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="adminPage.aspx.cs" Inherits="WebProject.adminPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Activate non-activated vendors" OnClick="Button1_Click" />
            <asp:Button ID="Button2" runat="server" Text="Review Orders" OnClick="Button2_Click" />
            <asp:Button ID="Button3" runat="server" Text="Update the order status to in process" OnClick="Button3_Click" />
            <asp:Button ID="Button4" runat="server" Text="Manage Deals" OnClick="Button4_Click" />
        </div>
        <asp:Button ID="logout" runat="server" Text="Logout"  OnClick="logout_Click"/>
    </form>
</body>
</html>
