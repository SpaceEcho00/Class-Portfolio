<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="logiinform.aspx.cs" Inherits="Class_Portfolio.logiinform" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    &nbsp;<asp:Label ID="Label1" runat="server" Text="Name"></asp:Label>
</p>
<p>
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
</p>
<p>
    Password</p>
<p>
    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
</p>
<p>
    <asp:Button ID="Login" runat="server" OnClick="Login_Click" Text="Button" />
</p>
<p>
    <asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
</p>
</asp:Content>
