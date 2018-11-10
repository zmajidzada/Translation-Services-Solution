<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="EditFormPage.aspx.cs" Inherits="WebSiteApplication.EditFormPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 84px;
        }
        .auto-style4 {
            width: 117px;
        }
        .auto-style5 {
            width: 106px;
        }
        .auto-style6 {
            width: 65px;
        }
        .auto-style7 {
            width: 84px;
            height: 22px;
        }
        .auto-style8 {
            width: 106px;
            height: 22px;
        }
        .auto-style9 {
            width: 65px;
            height: 22px;
        }
        .auto-style10 {
            width: 117px;
            height: 22px;
        }
        .auto-style11 {
            height: 22px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style7"></td>
            <td class="auto-style8"></td>
            <td class="auto-style9"></td>
            <td class="auto-style10"></td>
            <td class="auto-style11"></td>
        </tr>
        <tr>
            <td class="auto-style2">Form Name:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtFormName" runat="server" Width="104px"></asp:TextBox>
            </td>
            <td class="auto-style6">Category:</td>
            <td class="auto-style4">
                <asp:TextBox ID="txtCategory" runat="server" Width="110px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="BTNupdate" runat="server" OnClick="BTNupdate_Click" Text="Update" />
            </td>
        </tr>
    </table>
</asp:Content>
