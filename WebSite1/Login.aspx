<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Login.aspx.cs" Inherits="_Default" %>

<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="asp" %>


<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title></title>
</head>
<body>
    
    <form id="form1" runat="server">
    <div>
        <asp:LinkButton ID="LinkButton1" runat="server">LinkButton</asp:LinkButton>
    </div>
            <style type="text/css">
      #loginform
    {
        min-width:300px;
        height:210px;
        background-attachment:fixed;
        background-color:antiquewhite;
        border:1px solid;
        border-color:#555555;
        padding:16px 16px;
        border-radius:4px;
        -webkit-box-shadow: 0px 1px 6px rgba(75, 31, 57, 0.8);
        -moz-box-shadow:     0px 1px 6px rgba(75, 31, 57, 0.8);
        box-shadow:              0px 1px 6px rgba(223, 88, 13, 0.8);
    }
    .modalBackground
    {      
        background-color:#333333;
        filter:alpha(opacity=80);
        opacity:0.8;
    }      
    .style51
        { 
            color:red;
            font-weight: bold;
            font-family: Verdana;
            font-size:x-large;
            
        }
    .auto-style8 {
                    font-weight: bold;
                    font-family: Verdana;
                    font-size:x-large;
                    height: 50px;
                    width: 423px;
                    text-align: left;
                }
    .auto-style9 {
                    font-weight: bold;
                    font-family: Verdana;
                    font-size:x-large;
                    height: 50px;
                    width: 423px;
                    text-align:center;
                }
    .txt
    {
         color:#505050;   
    }
    .redstar
    {
        color: #FF0000;
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
        <asp:ScriptManager ID="ScriptManager1" runat="server"></asp:ScriptManager>
         
       
  
        <asp:Panel ID="popUpPanel" runat="server">
        <div id="loginform">
        <table class="auto-style8">
            <tr><td class="txt">User:<span class="redstar">*</span></td>
        
          
        <td class="style5" ><span>
             
                <asp:TextBox ID="txtUserName" runat="server" placeholder=" UserName"
                    Width="186px"></asp:TextBox>
                    </td>
        </tr>
        <tr>
             <td><span class="txt">Password: <span class="redstar">*</span> &nbsp;&nbsp;</span></td><td><asp:TextBox ID="txtPwd" runat="server" TextMode="Password" placeholder=" Password" Width="186px"></asp:TextBox>
             </td>
        </tr>
               <asp:RadioButtonList ID="RadioButtonList1" runat="server"  RepeatDirection="Horizontal" Width="452px">
                    <asp:ListItem Text="Employee" Selected="True" Value="Employee"></asp:ListItem>
                    <asp:ListItem Text="Customer" Value="Customer"></asp:ListItem>
                </asp:RadioButtonList>
        <tr>
           <td class="button2" style="margin-right:auto"><asp:Button ID="btnSubmit"  OnClick="btnSubmit_Click" runat="server" Text="Proceed" /></td>
        </tr>
         
        </table>
        </div>
        </asp:Panel>
        <asp:ModalPopupExtender ID="Modalpopupextender1" runat="server"  TargetControlID="LinkButton1" BehaviorID="btnsubmit" PopupControlID="popUpPanel"
          BackgroundCssClass="modalbackground" DropShadow="true" ></asp:ModalPopupExtender>

      
    </form>
   
</body>
</html>
