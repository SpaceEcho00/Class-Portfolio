<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="dashbar.aspx.cs" Inherits="testproj.dashbar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1><asp:Literal ID="litWelcome" runat="server" Mode="Encode" /></h1>
    <asp:Label ID="lblDashboardMessage" runat="server" EnableViewState="false" />
</asp:Content>
