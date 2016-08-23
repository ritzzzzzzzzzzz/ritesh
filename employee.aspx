<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="employee.aspx.cs" Inherits="employee" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" href="style1.css" type="text/css" />
    <style src="style1.css" type="text/css"></style>
    <style type="text/css">
        .auto-style1 {
            text-align: left;
            width: 359px;
        }
        .auto-style2 {
            width: 359px;
        }
        .auto-style4 {
            width: 359px;
            font-weight: bold;
        }</style>
    </asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    


        <table style="width: 100%;">
            <tr>
                <td class="auto-style1" colspan="2">
                   <h1> <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Register Employee
                </strong></h1>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"><strong>First Name</strong></td>
                <td><asp:TextBox ID="TextBox1" runat="server" CssClass="TextSearch" Height="16px" Width="201px"></asp:TextBox></td>
               
            </tr>
            <tr>
                <td class="auto-style2"><strong>Last Name</strong></td>
                <td><asp:TextBox ID="TextBox15" runat="server" CssClass="TextSearch" Height="16px" Width="201px"></asp:TextBox></td>
              
            </tr>
            <tr>
                <td class="auto-style4"><strong>Date Of Birth</strong></td>
                <td>
                    <asp:Calendar ID="Calendar1" runat="server" CssClass="TextSearch" Height="53px" Width="16px"></asp:Calendar>
                </td>
                
            </tr>
             <tr>
                <td class="auto-style4">Gender</td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList>
                 </td>
                
            </tr>
            <tr>
                <td class="auto-style2"><strong>Email</strong></td>
                <td><asp:TextBox ID="TextBox18" runat="server" CssClass="TextSearch" Height="16px" Width="201px"></asp:TextBox></td>
                
            </tr>
            <tr>
                <td class="auto-style2"><strong>Address</strong></td>
                <td><asp:TextBox ID="TextBox19" runat="server" CssClass="TextSearch" Height="16px" Width="201px"></asp:TextBox></td>
                
            </tr>
             <tr>
                <td class="auto-style2"><strong>Contact No.</strong></td>
                <td><asp:TextBox ID="TextBox20" runat="server" CssClass="TextSearch" Height="16px" Width="201px"></asp:TextBox></td>
                
            </tr>
            <tr>
                <td class="auto-style2"><strong>Years Of Experirence</strong></td>
                <td><asp:TextBox ID="TextBox21" runat="server" CssClass="TextSearch" Height="16px" Width="201px"></asp:TextBox></td>
                
            </tr>
            <tr>
                <td class="auto-style2"><strong>Date Of Joining</strong></td>
                <td><asp:TextBox ID="TextBox22" runat="server" CssClass="TextSearch" Height="16px" Width="201px"></asp:TextBox></td>
                
            </tr>
            <tr>
                  <td class="auto-style2"><strong>CTC</strong></td>
                <td><asp:TextBox ID="TextBox23" runat="server" CssClass="TextSearch" Height="16px" Width="201px"></asp:TextBox></td>
            </tr>
             <tr>
                  <td class="auto-style2"><strong>Password</strong></td>
                <td><asp:TextBox ID="TextBox24" runat="server" CssClass="TextSearch" Height="16px" Width="201px"></asp:TextBox></td>
            </tr>
             <tr>
                  <td class="auto-style2"><strong>Role</strong></td>
                <td><asp:TextBox ID="TextBox25" runat="server" CssClass="TextSearch" Height="16px" Width="201px"></asp:TextBox></td>
            </tr>
            <tr>
                  <td class="auto-style2"><strong>Place</strong></td>
                <td><asp:TextBox ID="TextBox26" runat="server" CssClass="TextSearch" Height="16px" Width="201px"></asp:TextBox></td>
            </tr>
            <tr>
                  <td class="auto-style2"><strong>Status</strong></td>
                <td><asp:TextBox ID="TextBox27" runat="server" CssClass="TextSearch" Height="16px" Width="201px"></asp:TextBox></td>
            </tr>
            <tr>
                  <td class="auto-style2" colspan="2">
                      &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                      <asp:Button ID="Button1" runat="server" Text="Submit" CssClass="btn1" />
                  </td>
                
            </tr>
        </table>
    </asp:Content>
