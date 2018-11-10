<%@ Page Title="" Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="EditLanguPage.aspx.cs" Inherits="WebSiteApplication.EditLanguPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 64px;
        }
        .auto-style3 {
            width: 123px;
        }
        .auto-style4 {
            width: 40px;
        }
        .auto-style5 {
            width: 114px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">&nbsp;</td>
            <td class="auto-style4">&nbsp;</td>
            <td class="auto-style5">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Language:</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtBoxLanuage" runat="server" Width="101px"></asp:TextBox>
            </td>
            <td class="auto-style4">LCID:</td>
            <td class="auto-style5">
                <asp:TextBox ID="txtBoxLCID" runat="server" Width="106px"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnUpdate" runat="server" OnClick="btnUpdate_Click" Text="Update" />
            </td>
        </tr>
    </table>
</asp:Content>
