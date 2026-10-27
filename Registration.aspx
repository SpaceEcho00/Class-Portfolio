<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="Registration.aspx.cs" Inherits="Class_Portfolio.Registration" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        git<asp:Label ID="LblName" runat="server" Text="Full Name"></asp:Label>
    <br />
</p>
    <p>
        <asp:TextBox ID="TxtName" runat="server" Width="128px" Height="16px"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Full Name is  required" ForeColor="Red" ControlToValidate="TxtName" ValidationGroup="vgRegistration">*</asp:RequiredFieldValidator>
</p>
<p>
    <asp:Label ID="LblEmail" runat="server" Text="Email Address"></asp:Label>
</p>
<p>
    <asp:TextBox ID="TxtEmail" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ErrorMessage="Email Address is required" ForeColor="Red" ControlToValidate="TxtEmail" ValidationGroup="vgRegistration">*</asp:RequiredFieldValidator>
    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TxtEmail" Display="Dynamic" ErrorMessage="Invalid email address.Valid email address must contain . and  @ symbol" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="vgRegistration">*</asp:RegularExpressionValidator>
    </p>
<p>
    <asp:Label ID="LblNo" runat="server" Text="Mobile Number"></asp:Label>
</p>
    <p>
        <asp:TextBox ID="TxtNo" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ErrorMessage="Mobile Number is required" ForeColor="Red" ControlToValidate="TxtNo" ValidationGroup="vgRegistration">*</asp:RequiredFieldValidator>
</p>
<p>
    <asp:Label ID="LblUser" runat="server" Text="User Name"></asp:Label>
</p>
    <p>
        <asp:TextBox ID="TxtUser" runat="server"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ErrorMessage="Username is required" ForeColor="Red" ControlToValidate="TxtUser" ValidationGroup="vgRegistration">*</asp:RequiredFieldValidator>
</p>
<p>
    <asp:Label ID="LblPass" runat="server" Text="Password"></asp:Label>
</p>
<p>
    <asp:TextBox ID="TxtPass" runat="server" TextMode="Password"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ErrorMessage="Password is required" ForeColor="Red" ViewStateMode="Enabled" ControlToValidate="TxtPass" ValidationGroup="vgRegistration">*</asp:RequiredFieldValidator>
    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="TxtPass" ControlToValidate="TxtConfirm" Display="Dynamic" ErrorMessage="Passwords do not match" ForeColor="Red" ValidationGroup="vgRegistration">*</asp:CompareValidator>
</p>
<p>
    <asp:Label ID="LblConfirm" runat="server" Text="Confirm Password"></asp:Label>
</p>
<p>
    <asp:TextBox ID="TxtConfirm" runat="server"></asp:TextBox>
    <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ErrorMessage="Confirm Password is required" ForeColor="Red" ControlToValidate="TxtConfirm" ValidationGroup="vgRegistration">*</asp:RequiredFieldValidator>
    </p>
<p>
    <asp:Button ID="BtnCreate" runat="server" Text="Create Account" ValidationGroup="vgRegistration" />
</p>
<p>
</p>
<asp:ValidationSummary ID="ValidationSummary" runat="server" ForeColor="Red" ValidationGroup="vgRegistration" />
<p>
    &nbsp;</p>
</asp:Content>
