<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Employee_details._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

       <div style="padding:15px">
           <table class="w-100">
               <tr>
                   <td style="width: 350px" >EmpId</td>
                   <td>
                       <asp:TextBox ID="TextBox1" runat="server" CausesValidation="True" CssClass="css_id" OnTextChanged="TextBox1_TextChanged" ToolTip="enter Id"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td style="width: 350px" >EmpName</td>
                   <td>
                       <asp:TextBox ID="TextBox2" runat="server" CssClass="css_name"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td style="width: 350px">DoB</td>
                   <td>
                       <asp:TextBox ID="TextBox3" runat="server" CssClass="css_dob"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td style="width: 350px">Gender</td>
                   <td>
                       <asp:RadioButtonList ID="RadioButtonList1" runat="server" RepeatDirection="Horizontal" Width="163px">
                           <asp:ListItem>Male</asp:ListItem>
                           <asp:ListItem>Female</asp:ListItem>
                       </asp:RadioButtonList>
                   </td>
               </tr>
               <tr>
                   <td style="width: 350px">Contact</td>
                   <td>
                       <asp:TextBox ID="TextBox4" runat="server" CssClass="css_contact"></asp:TextBox>
                   </td>
               </tr>
               </table>
           <p>
           </p>
           <table class="w-100">
               <tr>
    <td style="width: 852px">
        
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Insert" CssClass="insert" />
        <asp:Button ID="Button2" runat="server" Text="Update" OnClick="Button2_Click" CssClass="update" />
        <asp:Button ID="Button3" runat="server"  Text="Delete" OnClick="Button3_Click" CssClass="delete"/>
    </td>
    <td style="width: 350px">
        </td>
</tr>
               <tr>
    <td style="width: 350px" colspan="2">
    </td>
</tr>
<tr>
    <td colspan="2">
        <asp:GridView ID="GridView1" runat="server" BackColor="White" BorderColor="#CCCCCC" BorderStyle="None" BorderWidth="1px" CellPadding="3" Width="1081px">
            <FooterStyle BackColor="White" ForeColor="#000066" />
            <HeaderStyle BackColor="#006699" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="White" ForeColor="#000066" HorizontalAlign="Left" />
            <RowStyle ForeColor="#000066" />
            <SelectedRowStyle BackColor="#669999" Font-Bold="True" ForeColor="White" />
            <SortedAscendingCellStyle BackColor="#F1F1F1" />
            <SortedAscendingHeaderStyle BackColor="#007DBB" />
            <SortedDescendingCellStyle BackColor="#CAC9C9" />
            <SortedDescendingHeaderStyle BackColor="#00547E" />
        </asp:GridView>
    </td>
</tr>

               </table>
           <p>
               </p>
           
    </div>
    <div>
        <style>
                .css_id
                {
                    border-color:aqua;
                   
                }
                .css_id
{
    border-color:aqua;
   
}.css_name
{
    border-color:aqua;
   
}.css_dob
{
    border-color:aqua;
    
}
 .css_contact
{
    border-color:aqua;
    
}
            .insert
            {
                background-color:yellowgreen
            }
            .delete
            {
                background-color:red;
            }
            .update
            {
                background-color:gold;
            }
        </style>
        
    </div>
   

    </asp:Content>
