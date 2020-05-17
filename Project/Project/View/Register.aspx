<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site2.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Project.View.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 269px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <h2>&nbsp;</h2>
        <h2>
            <asp:Label ID="LblTitle" class="text-monospace text-light bg-secondary shadow" runat="server" Text="Register"></asp:Label>
        </h2>
        <table style="width: 100%;">
            <tr>
                <td class="auto-style1 fontt font-weight-bold">Email</td>
                <td class="auto-style2 fontt font-weight-bold">:</td>
                <td>
                    <asp:TextBox ID="TxtEmail" runat="server" TabIndex="1" Width="250px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredRegister1" runat="server" ControlToValidate="TxtEmail" EnableClientScript="False" ErrorMessage="Email must be filled!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1 fontt font-weight-bold">Name</td>
                <td class="auto-style2 fontt font-weight-bold">:</td>
                <td>
                    <asp:TextBox ID="TxtName" runat="server" TabIndex="2" Width="250px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredRegister2" runat="server" ControlToValidate="TxtName" EnableClientScript="False" ErrorMessage="Name must be filled!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1 fontt font-weight-bold">Password</td>
                <td class="auto-style2 fontt font-weight-bold">:</td>
                <td>
                    <asp:TextBox ID="TxtPassword" runat="server" TabIndex="3" TextMode="Password" Width="250px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredRegister3" runat="server" ControlToValidate="TxtPassword" EnableClientScript="False" ErrorMessage="Password must be filled!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1 fontt font-weight-bold">Confirm Password</td>
                <td class="auto-style2 fontt font-weight-bold">:</td>
                <td>
                    <asp:TextBox ID="TxtConfirm" runat="server" TabIndex="2" Width="250px" TextMode="Password"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style1 fontt font-weight-bold">Gender</td>
                <td class="auto-style2 fontt font-weight-bold">:</td>
                <td>
                    <asp:RadioButtonList ID="RadioButtonGender" class="fontt font-weight-bold" runat="server">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList>
                    <asp:RequiredFieldValidator ID="RequiredRegister4" runat="server" ControlToValidate="RadioButtonGender" EnableClientScript="False" ErrorMessage="Gender must be chosen" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
        </table>
        Already a member? 
        <asp:HyperLink ID="LnkLogin" runat="server" NavigateUrl="~/View/Login.aspx">Login</asp:HyperLink>
        <br />
        <asp:Button ID="BtnRegister" class="btn btn-info fontt font-weight-bold" runat="server" TabIndex="4" Text="Register" OnClick="DoRegister" />
        <br />
        <asp:Label ID="labelError" class="fontt font-weight-bold" runat="server" ForeColor="Red" Text="label" Visible="False"></asp:Label>
        <br />
        <br />
        <br />
        <br />
    </div>
</asp:Content>
