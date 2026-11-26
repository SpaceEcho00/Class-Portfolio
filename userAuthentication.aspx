<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="userAuthentication.aspx.cs" Inherits="testproj.userAuthentication" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Registration Number"></asp:Label>
    <br />
    <asp:TextBox ID="txtRegNo" runat="server" BorderColor="Black" Height="50px" Width="100%"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
    <br />
    <asp:TextBox ID="txtPasswd" runat="server" TextMode="Password"></asp:TextBox>
    <br />
    <br />
    <asp:Button ID="btnLogin" runat="server" BorderColor="Black" Height="50px" OnClick="btnLogin_Click" Text="Login" Width="100%" />
    <br />
    <br />
    <asp:Label ID="lblLogin" runat="server" EnableViewState="false"></asp:Label>
    <br />
    <br />
</asp:Content>
