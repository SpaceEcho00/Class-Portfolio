<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Second.aspx.cs" Inherits="Class_Portfolio.Second" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="lblError" runat="server" Text="Label"></asp:Label>
            <br />
            <asp:Label ID="Label1" runat="server" Text="Basic Pay "></asp:Label>
            <br />
            <asp:TextBox ID="TxtBPay" runat="server"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Commuter Allowance"></asp:Label>
            <br />
            <asp:TextBox ID="TxtCallowance" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text=" House Allowance"></asp:Label>
            <br />
            <asp:TextBox ID="TxtHallowance" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="BtnComputepay" runat="server" OnClick="Button1_Click" Text="Compute Pay" />
            <br />
            <asp:Label ID="lblGrosspay" runat="server" Text="Grosspay"></asp:Label>
            <br />
            <asp:Label ID="lblNetpay" runat="server" Text="Netpay"></asp:Label>
        </div>
    </form>
</body>
</html>
