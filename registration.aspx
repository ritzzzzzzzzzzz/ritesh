<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="registration.aspx.cs" Inherits="registration" %>


    <asp:content ID="id1" ContentPlaceHolderID="head" runat="server">

  
    <title></title>
   <script type="text/javascript" src="js file/j1.js"></script>
    
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
    </style>



        </asp:content>
    <asp:content ID="id2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <div>
   
        <table style="width:100%;">
            <tr>
                <td class="auto-style1" colspan="2">Register Yurself</td>
            </tr>
            <tr>
                <td>&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="txtname" runat="server" class="as"  ></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Password</td>
                <td>
                    <asp:TextBox ID="txtpass" runat="server" class="as"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Email</td>
                <td>
                    <asp:TextBox ID="txtemail" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>Gender</td>
                <td>
                    <asp:RadioButtonList ID="rdb1" runat="server" AutoPostBack="True" RepeatDirection="Horizontal">
                    </asp:RadioButtonList>
                </td>
            </tr>
            <tr>
                <td>State</td>
                <td>
                    <asp:DropDownList ID="ddl1" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnsubmit" runat="server" OnClick="btnsubmit_Click" OnClientClick="return su()" Text="Submit" />
                </td>
            </tr>
        </table>
    
    </div>
    </asp:content>

