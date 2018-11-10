<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="HomePage.aspx.cs" Inherits="WebSiteApplication.HomePage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 38px;
        }
        .auto-style2 {
            width: 100%;
        }
        .auto-style3 {
            margin-left: 0px;
        }
        .auto-style4 {
            width: 128px;
        }
        .auto-style5 {
            width: 492px;
        }
        .auto-style6 {
            margin-left: 136px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <table class="auto-style2">
        <tr>
            <td class="auto-style4">&nbsp;Application List:&nbsp;</td>
            <td class="auto-style5">
<asp:DropDownList ID="DisplayDropDownList" runat="server" AutoPostBack="True" OnSelectedIndexChanged="DisplayDropDownList_SelectedIndexChanged" CssClass="auto-style3" Height="27px" Width="170px">
  
</asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp; Forms List:</td>
            <td class="auto-style5">
                <asp:DropDownList ID="ListFormsDropDownList" runat="server" Height="27px" Width="170px">
                </asp:DropDownList>
            </td>
            <td>&nbsp;&nbsp;&nbsp;&nbsp; Languages:<asp:DropDownList ID="LanguageListDDList" runat="server" CssClass="auto-style1" Height="27px" Width="168px">
    </asp:DropDownList>
            </td>
        </tr>
        <tr>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
    <br />
    <br />
    <br />
    <asp:GridView ID="FormListGridView" runat="server" 
    CellPadding="3"
    ForeColor="Black"
    CssClass="auto-style6"
    gridlines="None"
    Width="377px">

        <AlternatingRowStyle BackColor="#CCCCCC" />
        <FooterStyle BackColor="#CCCCCC" />
        <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
        <PagerStyle BackColor="#999999" ForeColor="Black" HorizontalAlign="Center" />
        <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
        <SortedAscendingCellStyle BackColor="#F1F1F1" />
        <SortedAscendingHeaderStyle BackColor="#808080" />
        <SortedDescendingCellStyle BackColor="#CAC9C9" />
        <SortedDescendingHeaderStyle BackColor="#383838" />
    </asp:GridView>
<br />
<br />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<br />
<br />
<br />
<br />
<br />
</asp:Content>
