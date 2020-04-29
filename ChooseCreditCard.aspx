<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChooseCreditCard.aspx.cs" Inherits="WebProject.ChooseCreditCard" %>

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

            <asp:Label ID="lbl_number" runat="server" Text="Credit Card Number">

            </asp:Label>
        </p>
        <p>

            <asp:DropDownList ID="CreditCardNumbers" runat="server" Width="210px">
            </asp:DropDownList>
        </p>

        <p>

        <asp:Button ID="btn_pay" runat="server" Text="Use This Credit Card" onclick="ChoosingCreditCard" Width="215px"/>

        </p>

    </form>
</body>
</html>
