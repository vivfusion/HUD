<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="database_connection.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            Student Id :&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtId" runat="server"></asp:TextBox>
            <br />
            <br />
            Student name :&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtName" runat="server"></asp:TextBox>
            <br />
            <br />
            Student class :&nbsp;&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="TxtClass" runat="server" ></asp:TextBox>
            <br />
            <br />
            Student subject :&nbsp;
            <asp:TextBox ID="TxtSub" runat="server"></asp:TextBox>
            <br />
            <br />
            <br />
            <br />
            <asp:ListBox ID="ListBox1" runat="server" Width="201px" Height="124px" style="margin-top: 0px"></asp:ListBox>
            <br />
            <br />
            <asp:Button ID="saveBtn" runat="server" Text="Save" OnClick="saveBtn_Click" />
            <asp:Button ID="dispBtn" runat="server" Text="Display" OnClick="dispBtn_Click" />
          
        </div>
    </form>
</body>
</html>
