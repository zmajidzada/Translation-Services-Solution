<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="ModifyAppPage.aspx.cs" Inherits="WebSiteApplication.ModifyAppPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 122px;
        }
        .auto-style3 {
            width: 164px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">ApplicationName:</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtUpdate" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="UpdateButton" runat="server" OnClick="UpdateButton_Click" Text="Update" />
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
