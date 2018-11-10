<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="DeleteAppPage.aspx.cs" Inherits="WebSiteApplication.DeleteAppPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 59px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td colspan="2">
                <asp:Label ID="Label1" runat="server" ForeColor="#FF3300" Text="Are sure you want delete this item?"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
            </td>
            <td>
                <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" />
            </td>
        </tr>
    </table>
</asp:Content>
