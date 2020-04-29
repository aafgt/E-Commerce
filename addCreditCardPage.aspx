<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="addCreditCardPage.aspx.cs" Inherits="WebProject.addCreditCarPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="cardNumber" runat="server" Text="Credit Card Number"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txt_card_number" runat="server"></asp:TextBox>
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:HyperLink href="customerPage.aspx" ID="Go_Back" runat="server">Go Back</asp:HyperLink>
        </div>
        <p>
            <asp:Label ID="date" runat="server" Text="Expiry Date"></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txt_date" runat="server" TextMode="Date"></asp:TextBox>
        </p>
        <p>
            <asp:Label ID="cvv" runat="server" Text="CVV" ></asp:Label>
&nbsp;&nbsp;
            <asp:TextBox ID="txt_cvv" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="add_card" runat="server" Text="Add Card" OnClick="add_card_Click" />
        </p>
    </form>
</body>
</html>
