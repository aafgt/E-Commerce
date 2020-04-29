<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="createTodaysDeal.aspx.cs" Inherits="WebProject.createTodaysDeal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:HyperLink href="/adminPage.aspx" ID="goback" runat="server">Go Back</asp:HyperLink>
        <div style="height: 128px">
            <asp:Label ID="Label7" runat="server" Text="CREATE TODAYS DEAL"></asp:Label>
            <br />
            <asp:Label ID="Label5" runat="server" Text="deal amount:"></asp:Label>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            <asp:Label ID="Label6" runat="server" Text="expiry date:"></asp:Label>
            <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            <asp:Button ID="Button3" runat="server" Text="create" OnClick="Button3_Click" />
            <br />
            <br />
            <asp:Label ID="Label8" runat="server" Text="ADD TODAYS DEAL TO PRODUCT"></asp:Label>
            <br />
            <asp:Label ID="Label1" runat="server" Text="deal id:"></asp:Label>
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <asp:Label ID="Label2" runat="server" Text="serial no.:"></asp:Label>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            <asp:Button ID="Button1" runat="server" Text="add" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:Label ID="Label9" runat="server" Text="REMOVE EXPIRED DEAL"></asp:Label>
            <br />
            <asp:Label ID="Label3" runat="server" Text="deal id:"></asp:Label>
            <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            <asp:Button ID="Button2" runat="server" Text="remove" OnClick="Button2_Click" />
        </div>
    </form>
</body>
</html>
