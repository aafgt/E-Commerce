<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CancellingOrders.aspx.cs" Inherits="WebProject.CancellingOrders" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 600px">
            <asp:Button ID="back" runat="server" Text="Back" OnClick="Back" style="margin-left: 0px" Width="158px" />
        </div>
        <div>
            <asp:Label ID="lbl_order" runat="server" Text="OrderID"></asp:Label>
        </div>
        <p>
            <asp:TextBox ID="txt_order" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="btn_cancel" runat="server" Text="Cancel Order" onclick="CancelOrders" Width="112px"/>
        </p>
    </form>
</body>
</html>
