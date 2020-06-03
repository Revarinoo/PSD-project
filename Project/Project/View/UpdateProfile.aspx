<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site2.Master" AutoEventWireup="true" CodeBehind="UpdateProfile.aspx.cs" Inherits="Project.View.UpdateProfile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <asp:Label ID="LblTitle" class="text-monospace text-light bg-secondary shadow" runat="server" Text="Update Profile"></asp:Label>
    <table style="width: 100%;">
        <tr>
            <td class="auto-style1 fontt font-weight-bold">Email</td>
            <td class="auto-style3 fontt font-weight-bold">:</td>
            <td>
                <asp:TextBox ID="EmailUpdateTextBox" runat="server" TabIndex="1" Width="300px"></asp:TextBox>
                <%--<asp:RequiredFieldValidator ID="RequiredInsert1" runat="server" ControlToValidate="productName" EnableClientScript="False" ErrorMessage="Must be filled!" ForeColor="Red"></asp:RequiredFieldValidator>--%>
            </td>
        </tr>
        <tr>
            <td class="auto-style1 fontt font-weight-bold">Name</td>
            <td class="auto-style3 fontt font-weight-bold">:</td>
            <td>
                <asp:TextBox ID="UserNameUpdateTextBox" runat="server" TabIndex="2" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1 fontt font-weight-bold">Gender</td>
            <td class="auto-style3 fontt font-weight-bold">:</td>
            <td>
                <asp:RadioButtonList ID="RadioButtonGender" class="fontt font-weight-bold" runat="server">
                        <asp:ListItem>Male</asp:ListItem>
                        <asp:ListItem>Female</asp:ListItem>
                    </asp:RadioButtonList>
            </td>

        </tr>
      
    </table>
    <asp:Label ID="labelError" runat="server" ForeColor="Red" Text="ErrorMsg"></asp:Label>
    <br />
    <asp:Button ID="updateBtn" runat="server" class="btn btn-primary " Text="Update" OnClick="updateBtn_Click"/>
    &nbsp;&nbsp;&nbsp;
    <asp:Button ID="backtohomeBtn" runat="server" class="btn btn-secondary " Text="Back to Home" OnClick="backtohomeBtn_Click"/>
</asp:Content>
