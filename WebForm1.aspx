<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Client1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Enter COurse NAme : <asp:TextBox ID="txtCourseName" runat="server"></asp:TextBox>
       
        &nbsp;&nbsp;&nbsp; Enter Course ID :
            <asp:TextBox ID="txtCourseId" runat="server"></asp:TextBox>
       
        <br />
            Enter Credit : <asp:TextBox ID="txtCredit" runat="server"></asp:TextBox>
       <br />
            Enter Semester : <asp:TextBox ID="txtSemester" runat="server"></asp:TextBox>
      <br />
            <asp:Button ID="btnInsertCourse" runat="server" Text="Insert Course" OnClick="btnInsertCourse_Click"></asp:Button>
       
        &nbsp;&nbsp;&nbsp;&nbsp;
           
             <asp:Button ID="btnEdit" runat="server" Text="Edit Course" OnClick="btnEdit_Click"></asp:Button>
       
        &nbsp;&nbsp;&nbsp;&nbsp;
           
             <asp:Button ID="btnDelete" runat="server" Text="Delete Course" OnClick="btnDelete_Click"></asp:Button>
       
        &nbsp;&nbsp;&nbsp;&nbsp;
           
             <asp:Button ID="btnSearch" runat="server" Text="Search Course" OnClick="btnSearch_Click"></asp:Button>
       
        &nbsp;&nbsp;&nbsp;&nbsp;
           
            <asp:Label ID="lblMessage" runat="server" Text=" "></asp:Label>
       
        </div>
    </form>
</body>
</html>
