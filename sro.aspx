<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="sro.aspx.cs" Inherits="sro" %>

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
                   <h1> <strong>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Register SRO
                </strong></h1>
                </td>
            </tr>
            <tr>
                <td class="auto-style2"><strong>Address1</strong></td>
                <td><asp:TextBox ID="TextBox1" runat="server" CssClass="TextSearch" Height="16px" Width="201px" TextMode="MultiLine"></asp:TextBox></td>
               
            </tr>
            <tr>
                <td class="auto-style2"><strong>Address2</strong></td>
                <td><asp:TextBox ID="TextBox15" runat="server" CssClass="TextSearch" Height="16px" Width="201px" TextMode="MultiLine"></asp:TextBox></td>
              
            </tr>
            <tr>
                <td class="auto-style4"><strong>Area/Location</strong></td>
                <td>
                    <asp:TextBox ID="TextBox28" runat="server" CssClass="TextSearch" Height="16px" Width="201px"></asp:TextBox>
                </td>
                
            </tr>
             <tr>
                <td class="auto-style4">District</td>
                <td>
                    <asp:TextBox ID="TextBox29" runat="server" CssClass="TextSearch" Height="16px" Width="201px"></asp:TextBox>
                 </td>
                
            </tr>
            <tr>
                <td class="auto-style2"><strong>State</strong></td>
                <td><asp:TextBox ID="TextBox18" runat="server" CssClass="TextSearch" Height="16px" Width="201px"></asp:TextBox></td>
                
            </tr>
            <tr>
                <td class="auto-style2"><strong>Country</strong></td>
                <td><asp:TextBox ID="TextBox19" runat="server" CssClass="TextSearch" Height="16px" Width="201px"></asp:TextBox></td>
                
            </tr>
             <tr>
                <td class="auto-style2"><strong>Bank Name</strong></td>
                <td><asp:TextBox ID="TextBox20" runat="server" CssClass="TextSearch" Height="16px" Width="201px"></asp:TextBox></td>
                
            </tr>
            <tr>
                <td class="auto-style2"><strong>Bank Account</strong></td>
                <td><asp:TextBox ID="TextBox21" runat="server" CssClass="TextSearch" Height="16px" Width="201px"></asp:TextBox></td>
                
            </tr>
            <tr>
                <td class="auto-style2"><strong>Branch</strong></td>
                <td><asp:TextBox ID="TextBox22" runat="server" CssClass="TextSearch" Height="16px" Width="201px"></asp:TextBox></td>
                
            </tr>
            <tr>
                  <td class="auto-style2"><strong>IFSC Code</strong></td>
                <td><asp:TextBox ID="TextBox23" runat="server" CssClass="TextSearch" Height="16px" Width="201px"></asp:TextBox></td>
            </tr>
             <tr>
                  <td class="auto-style2"><strong>Created By</strong></td>
                <td><asp:TextBox ID="TextBox24" runat="server" CssClass="TextSearch" Height="16px" Width="201px"></asp:TextBox></td>
            </tr>
             <tr>
                  <td class="auto-style2"><strong>Created Date</strong></td>
                <td>
                    <asp:Calendar ID="Calendar1" runat="server" Width="185px"></asp:Calendar>
                  </td>
            </tr>
            <tr>
                  <td class="auto-style2"><strong>Modify By</strong></td>
                <td><asp:TextBox ID="TextBox26" runat="server" CssClass="TextSearch" Height="16px" Width="201px"></asp:TextBox></td>
            </tr>
            <tr>
                  <td class="auto-style2"><strong>Modify Date</strong></td>
                <td>
                    <asp:Calendar ID="Calendar2" runat="server" Width="185px"></asp:Calendar>
                </td>
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

