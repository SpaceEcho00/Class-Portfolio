<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Grading.aspx.cs" Inherits="Class_Portfolio.Grading" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 464px">
            <asp:Label ID="Label1" runat="server" Text="Cat Marks (Out of 10)"></asp:Label>
            <br />
            <asp:TextBox ID="txtCatMark" runat="server" Width="1196px"></asp:TextBox>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Attendance (Out of 5)"></asp:Label>
            <br />
            <asp:TextBox ID="TxtAttendanceMark" runat="server" Width="1191px"></asp:TextBox>
            <br />
            <asp:Label ID="Label3" runat="server" Text="Project(Out of 25)"></asp:Label>
            <br />
            <asp:TextBox ID="txtProjectMark" runat="server" Width="1188px"></asp:TextBox>
            <br />
            <asp:Label ID="Label4" runat="server" Text="Exam Mark(Out of 50)"></asp:Label>
            <br />
            <asp:TextBox ID="txtExamMark" runat="server" Width="1265px"></asp:TextBox>
            <br />
            <asp:Button ID="btnComputeGrade" runat="server" OnClick="btnComputeGrade_Click" Text="Compute Grade" />
            <br />
            <asp:Literal ID="litOutput" runat="server"></asp:Literal>
        </div>
    </form>
</body>
</html>
