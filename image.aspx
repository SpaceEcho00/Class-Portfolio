<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="image.aspx.cs" Inherits="Class_Portfolio.image" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:ImageButton ID="ImageButton1" runat="server" Height="206px" ImageUrl="~/Images/imaes.jpg" Width="156px" />
    <br />
    <asp:Button ID="btnNext" runat="server" OnClick="btnNext_Click" Text="Next" />
    <asp:Button ID="btnPrevious" runat="server" OnClick="btnPrevious_Click" Text="Previous" />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
