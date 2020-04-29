<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebProject.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="Titel" runat="server" Text="Register a New User"></asp:Label>
             &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink href="Default.aspx"  ID="goback" runat="server">Go Back</asp:HyperLink>
        </div>
        <p>
            <asp:Label ID="First_name" runat="server" Text="First Name"></asp:Label>
        </p>
        <asp:TextBox ID="txt_first_name" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Last_name" runat="server" Text="Last Name"></asp:Label>
        </p>
        <asp:TextBox ID="txt_last_name" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="User_name" runat="server" Text="Username"></asp:Label>
        </p>
        <asp:TextBox ID="txt_username" runat="server"></asp:TextBox>
        <p>
            <asp:Label ID="Password" runat="server" Text="Password"></asp:Label>
        </p>
        <asp:TextBox ID="txt_password" runat="server" TextMode="Password"></asp:TextBox>
        <p>
            <asp:Label ID="Email" runat="server" Text="E-mail"></asp:Label>
        </p>
        <asp:TextBox ID="txt_email" runat="server"></asp:TextBox>
        <p>
            <asp:Button ID="Submit" runat="server" onclick="register" Text="Submit" />
        </p>
    </form>
</body>
</html>
