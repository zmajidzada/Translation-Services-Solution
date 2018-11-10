<%@ Page Language="C#" UnobtrusiveValidationMode="none"MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="formPage.aspx.cs" Inherits="WebSiteApplication.formPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">   
     <style type="text/css">
         .auto-style1 {
             width: 47%;
         }
         .auto-style3 {
             width: 110px;
         }
         .auto-style6 {
             width: 68px;
         }
         .auto-style7 {
             width: 107px;
         }
     .auto-style8 {
        margin-left: 19px;
    }
    .auto-style9 {
        width: 115px;
    }
     </style>
     </asp:Content>     
 <asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <br />
&nbsp;&nbsp;
     <asp:DropDownList ID="ApplicationNameDDList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ApplicationNameDDList_SelectedIndexChanged">
       
     </asp:DropDownList>
     <br />
     <br />
     <br/>
     <asp:GridView ID="FormListGridView" runat="server" AutoGenerateColumns="False" Width="448px" BackColor="White" BorderColor="#DEDFDE" BorderStyle="None" BorderWidth="1px" CellPadding="4" CssClass="auto-style8" ForeColor="Black" GridLines="Vertical" >
         <AlternatingRowStyle BackColor="White" />
         <Columns>
             <asp:BoundField DataField="FormName" HeaderText="Form Name" SortExpression="FormName" />
             <asp:BoundField DataField="FormCategory" HeaderText="Category" SortExpression="FormCategory" />
             <asp:HyperLinkField DataNavigateUrlFields="FormId" DataNavigateUrlFormatString="DeleteFormPage.aspx?FormId={0}" Text="Delete" />
             <asp:HyperLinkField DataNavigateUrlFields="FormId " DataNavigateUrlFormatString="EditFormPage.aspx?FormId={0}" Text="Edit" />
         </Columns>
         <FooterStyle BackColor="#CCCC99" />
         <HeaderStyle BackColor="#6B696B" Font-Bold="True" ForeColor="White" />
         <PagerStyle BackColor="#F7F7DE" ForeColor="Black" HorizontalAlign="Right" />
         <RowStyle BackColor="#F7F7DE" />
         <SelectedRowStyle BackColor="#CE5D5A" Font-Bold="True" ForeColor="White" />
         <SortedAscendingCellStyle BackColor="#FBFBF2" />
         <SortedAscendingHeaderStyle BackColor="#848384" />
         <SortedDescendingCellStyle BackColor="#EAEAD3" />
         <SortedDescendingHeaderStyle BackColor="#575357" />
     </asp:GridView>
   
     <br />
     <table class="auto-style1">
         <tr>
             <td colspan="5">&nbsp;</td>
         </tr>
         <tr>
             <td class="auto-style9">&nbsp;&nbsp; Form name:</td>
             <td class="auto-style3">
                 <asp:TextBox ID="txtBoxFormName" runat="server" Width="101px"></asp:TextBox>
             </td>
             <td class="auto-style6">Category:</td>
             <td class="auto-style7">
                 <asp:TextBox ID="txtBoxCategory" runat="server" Width="101px"></asp:TextBox>
             </td>
             <td>
                 <asp:Button ID="btnAdd" runat="server" OnClick="btnAdd_Click" Text="Add" Width="50px" />
             </td>
         </tr>
     </table>
   
     <br />
     <br />
   
     </asp:Content> 
