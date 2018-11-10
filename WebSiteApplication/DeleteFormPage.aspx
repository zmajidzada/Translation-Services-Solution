<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="DeleteFormPage.aspx.cs" Inherits="WebSiteApplication.DeleteFormPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 26px;
            height: 30px;
        }
        .auto-style3 {
            height: 30px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td colspan="2">
                <asp:Label ID="lblDelete" runat="server" Text="Are you sure you want to delete this form?"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">
                <asp:Button ID="btnYes" runat="server" OnClick="btnYes_Click" Text="Yes" />
            </td>
            <td class="auto-style3">
                <asp:Button ID="btnNo" runat="server" OnClick="btnNo_Click" Text="No" Width="40px" />
            </td>
        </tr>
    </table>
</asp:Content>
