<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="radiobutton.aspx.cs" Inherits="Class_Portfolio.radiobutton" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:RadioButtonList ID="RadioButtonList" runat="server" AutoPostBack="True" Height="81px" OnSelectedIndexChanged="RadioButtonList1_SelectedIndexChanged" Width="111px">
        <asp:ListItem>Mpesa</asp:ListItem>
        <asp:ListItem>Cash</asp:ListItem>
        <asp:ListItem>Airtel Money</asp:ListItem>
    </asp:RadioButtonList>
    <asp:Label ID="lblPayment" runat="server" Text="Label"></asp:Label>
</asp:Content>
