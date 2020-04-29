<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="updateOrderStatusInProcess.aspx.cs" Inherits="WebProject.updataOrderStatusInProcess" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:HyperLink href="/adminPage.aspx" ID="goback" runat="server">Go Back</asp:HyperLink>
        <div>
            <asp:Label ID="Label1" runat="server" Text="order no.:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="update" OnClick="Button1_Click" />
        </div>
    </form>
</body></html>
