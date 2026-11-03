<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="FindJobs.aspx.cs" Inherits="Class_Portfolio.FindJobs" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="lblJobCategory" runat="server" Text="Select Job Category"></asp:Label>
        <br />
        <asp:DropDownList ID="ddlSelectJobCategory" runat="server">
            <asp:ListItem>Accounting</asp:ListItem>
            <asp:ListItem>Engineering</asp:ListItem>
            <asp:ListItem>IT</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        <asp:Label ID="lblLocation" runat="server" Text="Select Location"></asp:Label>
    </p>
    <p>
        <asp:DropDownList ID="ddlLocation" runat="server">
            <asp:ListItem>Nairobi</asp:ListItem>
            <asp:ListItem>Kisumu</asp:ListItem>
            <asp:ListItem>Mombasa</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        <asp:Label ID="lblJobType" runat="server" Text="Select Job Type"></asp:Label>
    </p>
    <p>
        <asp:DropDownList ID="ddlJobType" runat="server">
            <asp:ListItem>FullTime</asp:ListItem>
            <asp:ListItem>Contract</asp:ListItem>
        </asp:DropDownList>
    </p>
    <p>
        <asp:Button ID="btnJobs" runat="server" OnClick="btnJobs_Click" Text="Search Job" />
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
