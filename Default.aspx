<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="Default.aspx.cs" Inherits="_Default" %>


<asp:Content ID="head" ContentPlaceHolderID="head" runat="server"></asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <div>
        <table style="width: 100%;">
            <tr>
                <td>Name</td>
                <td>
                    <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                    <asp:TextBox ID="txtid" runat="server"></asp:TextBox>
                </td>
                
            </tr>
            <tr>
                <td>Class</td>
                <td>
                    <asp:DropDownList ID="ddlclass" runat="server" AutoPostBack="True"></asp:DropDownList></td>
                
            </tr>
            <tr>
                <td>Gender</td>
                <td>
                    <asp:RadioButtonList ID="rblgender" runat="server"></asp:RadioButtonList></td>
                
            </tr>
            <tr><td>
                <asp:Button ID="Search" runat="server" Text="Update" OnClick="Search_Click" />
                <asp:Button ID="Btnsearch" runat="server" Text="Search" OnClick="Btnsearch_Click" />
                <asp:Button ID="Btnadd" runat="server" Text="Submit" OnClick="Btnadd_Click" />
            </table>
    </div>
        </form>
</asp:Content>
