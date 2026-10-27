<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="dropdownlist.aspx.cs" Inherits="Class_Portfolio.dropdownlist" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:DropDownList ID="ddlNationality" runat="server" AutoPostBack="True" Height="101px" OnSelectedIndexChanged="ddlNationality_SelectedIndexChanged">
        <asp:ListItem Selected="True">Select your nationality</asp:ListItem>
        <asp:ListItem>Kenya</asp:ListItem>
        <asp:ListItem>Tanzania</asp:ListItem>
        <asp:ListItem>South Sudan</asp:ListItem>
        <asp:ListItem>Malawi</asp:ListItem>
        <asp:ListItem>D.R.C</asp:ListItem>
    </asp:DropDownList>
    <br />
    <asp:Label ID="lblNationality" runat="server" Text="Label"></asp:Label>
</asp:Content>
