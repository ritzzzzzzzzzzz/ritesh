<%@ Page Language="C#" AutoEventWireup="true" CodeFile="add.aspx.cs" Inherits="add" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>










        <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox><asp:TextBox ID="TextBox3" runat="server"></asp:TextBox><asp:TextBox ID="TextBox4" runat="server"></asp:TextBox><asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
        <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </div>
    </form>
</body>
</html>
