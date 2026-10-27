<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="First.aspx.cs" Inherits="Class_Portfolio.First" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 164px">
            Enter<br />
            <asp:TextBox ID="TxtOHours" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="btnCompletePay" runat="server"  Text="Complete Pay" Width="126px" OnClick="btnCompletePay_Click" />
            <br />
            <br />
            <asp:Literal ID="LitFixedAllowance" runat="server"></asp:Literal>
            <br />
            <asp:Literal ID="litOverTimePay" runat="server"></asp:Literal>
            <br />
            <asp:Literal ID="litGrossPay" runat="server"></asp:Literal>
            <br />
            <asp:Literal ID="litPaye" runat="server"></asp:Literal>
            <br />
        </div>
        <asp:Literal ID="LitSha" runat="server"></asp:Literal>
        <br />
        <asp:Literal ID="litHousinglevy" runat="server"></asp:Literal>
        <br />
        <asp:Literal ID="litNSSF" runat="server"></asp:Literal>
        <br />
        <asp:Literal ID="litNetPay" runat="server"></asp:Literal>
        <br />
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
