<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Pay.aspx.cs" Inherits="WebProject.Pay" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="margin-left: 600px">
            <asp:Button ID="back" runat="server" Text="Back" OnClick="Back" style="margin-left: 0px" Width="158px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<br />
        </div>
        <p>
            <asp:Label ID="lbl_orderID" runat="server" Text="Order ID"></asp:Label>
        </p>

            <asp:TextBox ID="txt_orderID" runat="server"></asp:TextBox>
        <p>

            <asp:Label ID="lbl_cash" runat="server" Text="Cash Amount">

            </asp:Label>
        </p>

            <asp:TextBox ID="txt_cash" runat="server"></asp:TextBox>
        <p>

        <asp:Label ID="lbl_credit" runat="server" Text="Credit Amount"></asp:Label>
        </p>
        <p>

            <asp:TextBox ID="txt_credit" runat="server"></asp:TextBox>

        </p>

        <p>

        <asp:Button ID="btn_pay" runat="server" Text="Pay" onclick="SpecifyAmount" Width="90px"/>

        </p>

    </form>
</body>
</html>
