<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="Default2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
       <table style="width: 100%;">
            <tr>
                <td>Claim_id</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox></td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" /></td>
            </tr>
            <tr>
                <td>Model</td>
                <td class="auto-style1"><asp:TextBox ID="TextBox2" runat="server"/></td>
               
            </tr>
            <tr>
                <td>Model type</td>
                <td class="auto-style1">
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>Basic</asp:ListItem>
                        <asp:ListItem>Smartphone</asp:ListItem>
                        <asp:ListItem>Buisness</asp:ListItem>
                    </asp:RadioButtonList></td>
                
            </tr>
             <tr>
                <td>IMEI number</td>
                <td class="auto-style1"><asp:TextBox ID="TextBox3" runat="server"/></td>
                
            </tr>
             <tr>
                <td>Part ID</td>
                <td class="auto-style1">
                    <asp:DropDownList ID="DropDownList1" runat="server">
                        <asp:ListItem>1</asp:ListItem>
                        <asp:ListItem>2</asp:ListItem>
                    </asp:DropDownList></td>
                
            </tr>
            <tr>
                <td>Part Cost</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBox4" runat="server"/>
                 
                
            </tr>
            <tr>
                <td>Labor Cost</td>
                <td class="auto-style1">
                    <asp:TextBox ID="TextBox5" runat="server"/>
                  
                
            </tr>
             <tr>
                <td>Status</td>
                <td class="auto-style1">
                 
                   
                   <asp:DropDownList ID="DropDownList2" runat="server">
                       <asp:ListItem>Submitted</asp:ListItem>
                       <asp:ListItem>Accepted</asp:ListItem>
                       <asp:ListItem>Rejected</asp:ListItem>
                    </asp:DropDownList>
            </tr>
             <tr>
                <td>
                    <asp:Button ID="Button2" runat="server" Text="Add" Width="78px" OnClick="Button2_Click" /></td>
                
                    <td class="auto-style1"><asp:Button ID="Button3" runat="server" Text="Save" /></td>
                  <td><asp:Button ID="Button4" runat="server" Text="Modify" OnClick="Button4_Click" /></td>
                   <td><asp:Button ID="Button5" runat="server" Text="Remove" /></td>
                   <td><asp:Button ID="Button6" runat="server" Text="Cancel" /></td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
