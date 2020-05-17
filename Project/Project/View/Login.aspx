<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site2.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Project.View.Login" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 287px;
        }
        .auto-style2 {
            width: 247px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <h2>&nbsp;</h2>
        <h2>
            <asp:Label ID="LblTitle" class="text-monospace text-light bg-secondary shadow" runat="server" Text="Login"></asp:Label>
        </h2>
        <table style="width: 100%;">
            <tr>
                <td class="auto-style2 fontt font-weight-bold">Email</td>
                <td class="auto-style3 fontt font-weight-bold">:</td>
                <td>
                    <asp:TextBox ID="TxtMail" runat="server" TabIndex="1" Width="250px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredLogin1" runat="server" ControlToValidate="TxtMail" EnableClientScript="False" ErrorMessage="Email must be filled!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2 fontt font-weight-bold">Password</td>
                <td class="auto-style3 fontt font-weight-bold">:</td>
                <td>
                    <asp:TextBox ID="TxtPass" runat="server" TabIndex="2" Width="250px" TextMode="Password"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredLogin2" runat="server" ControlToValidate="TxtPass" EnableClientScript="False" ErrorMessage="Password must be filled!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1 fontt font-weight-bold" colspan="3">
                    <asp:CheckBox ID="rememberMe" runat="server" TabIndex="3" Text="Remember Me" />
                </td>
                <td colspan="3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
        Not a member yet?
        <asp:HyperLink ID="LnkRegister" runat="server" NavigateUrl="~/View/Register.aspx" TabIndex="5">Register Now</asp:HyperLink>
        <br />
        <br />
        <asp:Button ID="btnLogin2" class="btn btn-info fontt font-weight-bold" runat="server" TabIndex="4" Text="Login" OnClick="DoLogin" />
        <br />
        <asp:Label ID="labelError" class="fontt font-weight-bold" runat="server" ForeColor="Red" Text="label" Visible="False"></asp:Label>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    </div>
</asp:Content>
