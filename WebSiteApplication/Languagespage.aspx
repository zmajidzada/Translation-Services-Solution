<%@ Page Language="C#" MasterPageFile="~/Main.Master" AutoEventWireup="true" CodeBehind="Languagespage.aspx.cs" Inherits="WebSiteApplication.Languagespage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">        
    <style type="text/css">
        .auto-style1 {
            width: 423px;
            height: 27px;
        }
        .auto-style2 {
            width: 39px;
        }
        .auto-style3 {
            width: 29px;
        }
        .auto-style4 {
            margin-left: 25px;
        }
        .auto-style6 {
            width: 69px;
        }
        .auto-style10 {
        width: 70px;
    }
    .auto-style11 {
        margin-left: 2px;
    }
    .auto-style12 {
        margin-left: 16px;
    }
    .auto-style13 {
        width: 57px;
    }
    </style>
    </asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <br />
    </p>
    <p>
        <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4" CssClass="auto-style4" Width="396px">
            <Columns>
                <asp:BoundField DataField="LanguageName" HeaderText="Language" />
                <asp:BoundField DataField="LanguageLCID" HeaderText="LCID" SortExpression="LanguageLCID" />
                <asp:HyperLinkField DataNavigateUrlFields="LanguageId" DataNavigateUrlFormatString="EditLanguPage.aspx?LanguageId={0}" Text="Modify" />
            </Columns>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
    </p>
    <table class="auto-style1">
            <tr>
                <td class="auto-style13">&nbsp;Language:</td>
                <td class="auto-style10">
                    <asp:TextBox ID="TextBoxLanguageName" runat="server" Width="105px" CssClass="auto-style11"></asp:TextBox>
                </td>
                <td class="auto-style3">LICD:</td>
                <td class="auto-style6">
                    <asp:TextBox ID="TextBoxLanguageLCID" runat="server" Width="102px"></asp:TextBox>
                </td>
                <td class="auto-style2">
                    <asp:Button ID="ButtonAddLanguage" runat="server" OnClick="ButtonAddLanguage_Click" Text="Add" CssClass="auto-style12" Width="56px" />
                </td>
            </tr>
          </table>
    <p>
        &nbsp;</p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
    <p>
    </p>
</asp:Content>
