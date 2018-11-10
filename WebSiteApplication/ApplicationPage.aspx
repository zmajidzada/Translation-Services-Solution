<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ApplicationPage.aspx.cs" Inherits="WebSiteApplication.ApplicationPage"  %>

    <asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">        
         
        <style type="text/css">
    .auto-style1 {
        margin-left: 35px;
    }
    .auto-style2 {
        width: 67px;
    }
    .auto-style3 {
        width: 236px;
    }
    .auto-style4 {
        margin-left: 0px;
    }
    .auto-style5 {
        width: 164px;
    }
</style>
         
    </asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <asp:GridView ID="GridView1" AutoGenerateColumns="False" runat="server" Width="442px" Height="139px" BackColor="White" BorderColor="#CC9966" BorderStyle="None" BorderWidth="1px" CellPadding="4" OnSelectedIndexChanged="GridView1_SelectedIndexChanged" CssClass="auto-style1">
                       <Columns>
                          
                   
            <asp:TemplateField HeaderText="Application Name" >
            <ItemTemplate>
                <asp:HyperLink runat="server" NavigateUrl='<%# Eval("ApplicationName", "~/formPage.aspx?id={0}") %>'
                    Text='<%# Eval("ApplicationName") %>' />
            </ItemTemplate>
                               </asp:TemplateField>
                           

                           <asp:HyperLinkField DataNavigateUrlFields="ApplicationId" DataNavigateUrlFormatString="ModifyAppPage.aspx?ApplicationId={0}" Text="Edit" />
                           <asp:HyperLinkField DataNavigateUrlFields="ApplicationId" DataNavigateUrlFormatString="DeleteAppPage.aspx?ApplicationId={0}" Text="Delete" />
                           

                           </Columns>
        

                       <FooterStyle BackColor="#FFFFCC" ForeColor="#330099" />
                       <HeaderStyle BackColor="#ff6133" Font-Bold="True" ForeColor="#FFFFCC"/>
                       <PagerStyle BackColor="#FFFFCC" ForeColor="#330099" HorizontalAlign="Center" />
                       <RowStyle ForeColor="#330099" BackColor="White" />
                       <SelectedRowStyle BackColor="#FFCC66" Font-Bold="True" ForeColor="#663399" />
                       <SortedAscendingCellStyle BackColor="#FEFCEB" />
                       <SortedAscendingHeaderStyle BackColor="#AF0101" />
                       <SortedDescendingCellStyle BackColor="#F6F0C0" />
                       <SortedDescendingHeaderStyle BackColor="#7E0000" />
        

                    </asp:GridView>
        


     
      
     <table class="auto-style11">
         <tr>
             <td colspan="3">
                    <asp:Label ID="LblMSG" runat="server"></asp:Label>
                    <asp:Label ID="returnMsg" runat="server"></asp:Label>
&nbsp;<asp:Label ID="errorLabel" runat="server"></asp:Label>
                </td>
         </tr>
         <tr>
             <td class="auto-style5">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Application name:</td>
             <td class="auto-style3">
                    <asp:TextBox ID="TextBoxAddApplication" runat="server" Width="130px" CssClass="auto-style4"></asp:TextBox>
                </td>
             <td class="auto-style2">
                    <asp:Button ID="ButtonAddApplication" runat="server" OnClick="ButtonAddApplication_Click" Text="Add App" CssClass="auto-style14" Width="69px" style="margin-left: 0px" />
                </td>
         </tr>
     </table>
    <br />
    </asp:Content>