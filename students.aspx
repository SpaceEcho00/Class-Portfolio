<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="students.aspx.cs" Inherits="testproj.students" %>

<script runat="server">

    protected void txtRegNo_TextChanged(object sender, EventArgs e)
    {

    }
</script>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="Registration Number"></asp:Label>
    <br />
    <asp:TextBox ID="txtRegNo" runat="server" MaxLength="11"></asp:TextBox>
    <br />
    <asp:Label ID="Label2" runat="server" Text="Student Name"></asp:Label>
    <br />
    <asp:TextBox ID="txtSName" runat="server" MaxLength="50"></asp:TextBox>
    <br />
    <asp:Label ID="Label3" runat="server" Text="Student Email"></asp:Label>
    <br />
    <asp:TextBox ID="txtSEmail" runat="server" TextMode="Email"></asp:TextBox>
    <br />
    <asp:Label ID="Label4" runat="server" Text="Student Gender"></asp:Label>
    <br />
    <asp:RadioButtonList ID="rblGender" runat="server">
        <asp:ListItem>Male</asp:ListItem>
        <asp:ListItem>Female</asp:ListItem>
    </asp:RadioButtonList>
    <br />
    <br />
    <asp:Label ID="Label5" runat="server" Text="Mobile Number"></asp:Label>
    <br />
    <asp:TextBox ID="txtMNo" runat="server" MaxLength="15"></asp:TextBox>
    <br />
    <br />
    <asp:Label ID="Label6" runat="server" AssociatedControlID="txtPasswd" Text="Password"></asp:Label>
    <br />
    <asp:TextBox ID="txtPasswd" runat="server" TextMode="Password" />
    <br />
    <asp:Label ID="Label7" runat="server" AssociatedControlID="txtCPasswd" Text="Confirm Password"></asp:Label>
    <br />
    <asp:TextBox ID="txtCPasswd" runat="server" TextMode="Password" />
    <br />
    <br />
    <asp:Button ID="btnSubmit" runat="server" Text="Submit" BorderColor="Black" Height="50px" OnClick="btnSubmit_Click" Width="100%" />
    <br />
    <asp:Label ID="lblSave" runat="server"></asp:Label>
    <br />
</asp:Content>
