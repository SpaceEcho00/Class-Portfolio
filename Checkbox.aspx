<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Checkbox.aspx.cs" Inherits="Class_Portfolio.Checkbox" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Lbl1" runat="server" Text="How Did You Know About Us?"></asp:Label>
        <br />
        <asp:CheckBoxList ID="CheckBoxList1" runat="server" AutoPostBack="True" Height="102px" OnSelectedIndexChanged="CheckBoxList1_SelectedIndexChanged">
            <asp:ListItem>TV</asp:ListItem>
            <asp:ListItem>Newspaper</asp:ListItem>
            <asp:ListItem>Radio</asp:ListItem>
            <asp:ListItem>Facebook</asp:ListItem>
            <asp:ListItem>Linked In</asp:ListItem>
        </asp:CheckBoxList>
    </p>
    <p>
        <asp:ListBox ID="LstBox" runat="server" BackColor="Black" ForeColor="Yellow" Height="80px" style="margin-bottom: 1px" Width="100%"></asp:ListBox>
    </p>
    <p>
        <asp:Label ID="Lbl2" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p style="margin-left: 40px">
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
