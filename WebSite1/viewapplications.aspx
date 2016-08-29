<%@ Page Language="C#" AutoEventWireup="true" CodeFile="viewapplications.aspx.cs" Inherits="viewapplications" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>

<body>
    <form id="form1" runat="server">
            <style type="text/css">
    
    .modalBackground
    {      
        /*background-color:#333333;
        filter:alpha(opacity=80);*/
        opacity:0.8;
    }      
    </style>
        <script type="text/javascript">
            function ShowModalPopup() {
                $find("mpe").show(); return false;
            }
            function HideModalPopup() {
                $find("mpe").show(); return true;
            }


    </script>
    
    
    <div>
  <h1>View Details</h1>
        <table style="width: 100%;">
            <tr><td>
                <asp:Button ID="Btnall" runat="server" Text="View_ALL" OnClick="Btnall_Click" />
                <asp:Label ID="lblmsg" Visible="false" runat="server" Text="Label"></asp:Label>
                </td></tr>
            <tr>
                <td>Application ID</td>
                <td>
                    <asp:TextBox ID="txtid" runat="server"></asp:TextBox></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Marriage Location</td>
                <td>
                    <asp:TextBox ID="txtloc" runat="server"></asp:TextBox></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>SR Office</td>
                <td>
                    <asp:DropDownList ID="ddlsro" runat="server"></asp:DropDownList>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Husband Name</td>
                <td>   <asp:TextBox ID="txthusband" runat="server"></asp:TextBox></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>Wife Name</td>
                <td>   <asp:TextBox ID="txtwife" runat="server"></asp:TextBox></td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td>
                    <asp:Button ID="Btnsearch" runat="server" Text="Search" /></td>
            </tr>
        </table>
    </div>
        
       
        <asp:GridView ID="GridView1" runat="server" DataKeyNames="Application_no"  OnSelectedIndexChanged="GridView1_SelectedIndexChanged" AutoGenerateColumns="False"
            >
            <Columns>
                
                
                <asp:BoundField DataField="Application_no" HeaderText="ApplicationNO" />
                <asp:BoundField DataField="husband_name" HeaderText="Husband Name" />
                <asp:BoundField DataField="Wife_name" HeaderText="Wife Name" />
                <asp:BoundField DataField="MarraigeDate" HeaderText="Marriage Date" />
                <asp:BoundField DataField="MgrLocation" HeaderText="Marriage Location" />
                <asp:BoundField DataField="status" HeaderText="Status" />
              
                <asp:ButtonField HeaderText="View Application" Text="View" CommandName="Select" />
            </Columns>
              <EmptyDataTemplate>
                no records found
            </EmptyDataTemplate>
        </asp:GridView>
    
       <asp:ToolkitScriptManager ID="ToolkitScriptManager1" runat="server"></asp:ToolkitScriptManager>
        <asp:ModalPopupExtender ID="mpe" PopupControlID="popUpPanel" TargetControlID="lnkFake" 
             BackgroundCssClass="modalBackground"  runat="server"></asp:ModalPopupExtender>
         <asp:LinkButton   ID="lnkFake" runat="server"></asp:LinkButton>
         <asp:Panel ID="popUpPanel" runat="server"  >
                
        <asp:DetailsView ID="dvviewdetails" runat="server" Height="50px" Width="125px"></asp:DetailsView>
                     
        </asp:Panel>
     
    </form>
</body>
</html>
