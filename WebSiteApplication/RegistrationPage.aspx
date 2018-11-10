<%@ Page Title="" Language="C#" UnobtrusiveValidationMode="none" AutoEventWireup="true" CodeBehind="RegistrationPage.aspx.cs" Inherits="WebSiteApplication.RegistrationPage" %>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Register</title>
    

    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 179px;
        }
        .auto-style3 {
            width: 133px;
            text-align: right;
        }
        </style>

    </head>
    <body>
    <form id="form1" runat="server">
         <fieldset>
    <legend>Personal information:</legend>
             <br>
    <div>


    <table class="auto-style1">
        <tr>
            <td colspan="2">
                <asp:Label ID="LabelMessage" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">UserName:</td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBoxUserName" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBoxUserName" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">Password:</td>
            <td class="auto-style3">
                <asp:TextBox ID="TextBoxPassword" runat="server" TextMode="Password"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBoxPassword" ErrorMessage="*" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;</td>
            <td class="auto-style3">
                <asp:Button ID="ButtonRegister" runat="server" OnClick="ButtonRegister_Click" Text="Register" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
   </div>
             </fieldset>
    </form>
</body>
</html>
