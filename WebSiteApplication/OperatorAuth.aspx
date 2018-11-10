<%@ Page Language="C#"  UnobtrusiveValidationMode="None" AutoEventWireup="true" CodeBehind="OperatorAuth.aspx.cs" Inherits="WebSiteApplication.OperatorAuth" %>
    <!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Login</title>
    
   
    <style type="text/css">
        .auto-style1 {
            width: 299px;
        }
        .auto-style2 {
            width: 162px;
        }
        .auto-style3 {
            width: 162px;
            height: 25px;
        }
        .auto-style4 {
            height: 25px;
        }
    </style>
    
   
    </head>
    <body>
    <form id="form1" runat="server">
        <fieldset>
    <legend>Login Details<strong>:</strong></legend>
    <div>

    
        <table class="auto-style1">
            <tr>
                <td class="auto-style9" colspan="2">
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style11" colspan="2">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    &nbsp;Enter your username:<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBoxLoginUserName" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
                <td class="auto-style20">
                    <asp:TextBox ID="TextBoxLoginUserName" runat="server" Width="97px" CssClass="auto-style34"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style3">
                    Enter your password:&nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBoxLoginUserName" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
                    &nbsp;&nbsp;
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="TextBoxLoginPassword" runat="server" TextMode="Password" Width="97px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;
                    </td>
                <td class="auto-style32">
                    <asp:Button ID="ButtonLogin" runat="server" OnClick="ButtonLogin_Click" style="text-align: left; margin-left: 41px" Text="Login" Width="64px" />
                </td>
            </tr>
            <tr>
                <td colspan="2"><a href="RegistrationPage.aspx">Register</a></td>
            </tr>
        </table>
    
     </div>
            </fieldset>
    </form>
</body>
</html>
