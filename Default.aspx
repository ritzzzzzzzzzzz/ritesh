<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 451px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    </div>
        <table style="width:100%;">
            <tr>
                <td>
        <asp:Label ID="lblid" runat="server" Text="ID"></asp:Label>
                </td>
                <td class="auto-style1">
        <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
        <asp:Label ID="Password" runat="server" Text="Label"></asp:Label>
                </td>
                <td class="auto-style1">
    <asp:TextBox ID="txtpass" runat="server"></asp:TextBox></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td class="auto-style1"><asp:Button ID="Login" runat="server" Text="Button" OnClick="Login_Click" />
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
    </body>
</html>
