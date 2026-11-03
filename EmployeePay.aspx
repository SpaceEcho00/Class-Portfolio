<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="EmployeePay.aspx.cs" Inherits="Class_Portfolio.EmployeePay" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="lblJobTitle" runat="server" Text="Select Job Title"></asp:Label>
        <br />
        <asp:DropDownList ID="ddlJobTitle" runat="server" Width="100%">
            <asp:ListItem>Engineer</asp:ListItem>
            <asp:ListItem>Intern</asp:ListItem>
            <asp:ListItem>DatabaseAdministrator</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="btnEmployeePay" runat="server" BackColor="#990000" OnClick="btnEmployeePay_Click" Text="Display Employee Pay" Width="100%" />
    </p>
    <p>
        <asp:Label ID="lblBasic" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:Label ID="lblHousing" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:Label ID="lblTransport" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        <asp:Label ID="lblGross" runat="server" Text="Label"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
