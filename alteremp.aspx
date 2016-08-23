<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/MasterPage.master" CodeFile="alteremp.aspx.cs" Inherits="alteremp"  %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
    <link rel="stylesheet" href="style1.css" type="text/css" />
    <style src="style1.css" type="text/css"></style>
    </asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <table style="width: 100%;">
            <tr><td><h2><strong>Alter Employee Details</strong></h2></td></tr>
            <tr>
                <td><strong>Emp_ID</strong></td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server" CssClass="TextSearch"></asp:TextBox></td>
                <td>
                    <asp:Button ID="Button1" runat="server" Text="Search" OnClick="Button1_Click" CssClass="btn1" /></td>
                <td>
                    &nbsp;</td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:GridView ID="GridView1" runat="server" OnRowCancelingEdit="docancel" 
            OnRowDeleting="dodelete" OnRowEditing="doedit" OnRowUpdating="doupdate" 
            AutoGenerateColumns="False" Height="148px" Width="37%" 
            style="margin-right: 0px; margin-left: 2px; text-align: center;" CellPadding="4" 
            ForeColor="#333333" GridLines="None" DataSourceID="SqlDataSource1" AllowPaging="True">
                        <Columns>
                            
                            <asp:BoundField DataField="Last_name" HeaderText="Last_name" SortExpression="Last_name" />
                           
                           
                            <asp:BoundField DataField="Email" HeaderText="Email" SortExpression="Email" />
                            <asp:BoundField DataField="Address" HeaderText="Address" SortExpression="Address" />
                            <asp:BoundField DataField="Contact_no" HeaderText="Contact_no" SortExpression="Contact_no" />
                            <asp:BoundField DataField="Status" HeaderText="Status" SortExpression="Status" />
                            <asp:BoundField DataField="Place" HeaderText="Place" SortExpression="Place" />
                            <asp:BoundField DataField="CTC" HeaderText="CTC" SortExpression="CTC" />
                            <asp:BoundField DataField="Date_Of_Joining" HeaderText="Date_Of_Joining" SortExpression="Date_Of_Joining" />
                            <asp:BoundField DataField="Year_Of_Experience" HeaderText="Year_Of_Experience" SortExpression="Year_Of_Experience" />
                            <asp:BoundField DataField="Password" HeaderText="Password" SortExpression="Password" />
                            <asp:BoundField DataField="Role" HeaderText="Role" SortExpression="Role" />
                             <asp:CommandField ShowEditButton="true" EditText="Edit" CancelText="cancle" 
                    UpdateText="Update" HeaderText="Change"/>
            <asp:CommandField ShowDeleteButton="true" DeleteText="Delete" HeaderText="Delete"/>
                        </Columns>
                    </asp:GridView>
                    <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ass1ConnectionString %>" SelectCommand="SELECT [First_name], [Last_name], [Date_Of_Birth], [Gender], [Email], [Address], [Contact_no], [Status], [Place], [CTC], [Date_Of_Joining], [Year_Of_Experience], [Password], [Role] FROM [EM] WHERE ([id] = @id)">
                        <SelectParameters>
                            <asp:ControlParameter ControlID="TextBox1" Name="id" PropertyName="Text" Type="String" />
                        </SelectParameters>
                    </asp:SqlDataSource>
                </td>
            </tr>
            <tr>
                <td colspan="3">&nbsp;</td>
            </tr>
        </table>
    </asp:Content>
