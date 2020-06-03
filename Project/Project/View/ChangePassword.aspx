<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site2.Master" AutoEventWireup="true" CodeBehind="ChangePassword.aspx.cs" Inherits="Project.View.ChangePassword" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="LblTitle" class="text-monospace text-light bg-secondary shadow" runat="server" Text="Change Password"></asp:Label>
    <table style="width: 100%;">
        <tr>
            <td class="auto-style1 fontt font-weight-bold">Old Password</td>
            <td class="auto-style3 fontt font-weight-bold">:</td>
            <td>
                <asp:TextBox ID="OldPassTextBox" runat="server" TabIndex="1" Width="300px" TextMode="Password"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="RequiredInsert1" runat="server" ControlToValidate="productName" EnableClientScript="False" ErrorMessage="Must be filled!" ForeColor="Red"></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td class="auto-style1 fontt font-weight-bold">New Password</td>
            <td class="auto-style3 fontt font-weight-bold">:</td>
            <td>
                <asp:TextBox ID="NewPassTextBox" runat="server" TabIndex="2" Width="300px" TextMode="Password"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1 fontt font-weight-bold">Confirm Password</td>
            <td class="auto-style3 fontt font-weight-bold">:</td>
            <td>
                <asp:TextBox ID="ConfirmPassTextBox" runat="server" TabIndex="2" Width="300px" TextMode="Password"></asp:TextBox>
            </td>

        </tr>
      
    </table>
    <asp:Label ID="labelError" runat="server" ForeColor="Red" Text="Label"></asp:Label>
    <br />
    <asp:Button ID="changepassBtn" runat="server" class="btn btn-primary " Text="Change Password" OnClick="changepassBtn_Click"/>
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="backtohomeBtn" runat="server" class="btn btn-secondary " Text="Back to Home" OnClick="backtohomeBtn_Click"/>
</asp:Content>
