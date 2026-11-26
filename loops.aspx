<%@ Page Title="" Language="C#" MasterPageFile="~/Master.Master" AutoEventWireup="true" CodeBehind="loops.aspx.cs" Inherits="Class_Portfolio.loops" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Button ID="btnforloop" runat="server" Height="70px" OnClick="btnforloop_Click" Text="For Loop" Width="33%" />
        <asp:Button ID="btnwhileloop" runat="server" Height="70px" OnClick="btnwhileloop_Click" Text="While Loop" Width="33%" />
        <asp:Button ID="btndowhile" runat="server" Height="70px" OnClick="btndowhile_Click" Text="Do While Loop" Width="33%" />
        <br />
        <asp:ListBox ID="lstNumbers" runat="server" Rows="50" Width="100%"></asp:ListBox>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
