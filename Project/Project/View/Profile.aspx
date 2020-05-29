<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site2.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Project.View.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
 <h2>
            <asp:Label ID="LblTitle" class="text-monospace text-light bg-secondary shadow" runat="server" Text="User Profile"></asp:Label>
        </h2>
        <table style="width: 100%;">
            <tr>
                <td class="auto-style2 fontt font-weight-bold">Email</td>
                <td class="auto-style3 fontt font-weight-bold">:</td>
                <td>
                    <asp:Label ID="UserEmailLabel" runat="server" Text="User Email"></asp:Label>
               </td>
            </tr>
            <tr>
                <td class="auto-style2 fontt font-weight-bold">Name</td>
                <td class="auto-style3 fontt font-weight-bold">:</td>
                <td>
                    <asp:Label ID="UserNameLabel" runat="server" Text="User Name"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2 fontt font-weight-bold">Gender</td>
                <td class="auto-style3 fontt font-weight-bold">:</td>
                <td>
                    <asp:Label ID="UserGenderLabel" runat="server" Text="User Gender"></asp:Label>
                </td>
            </tr>
            <tr>
                <td></td>
            </tr>
            <tr>
                <td class="auto-style1 fontt font-weight-bold" colspan="3">
                    <asp:Button ID="BacktoHomeBtn" runat="server" Text="Back to Home" />
                &nbsp;<asp:Button ID="UpdateProfileBtn" runat="server" Text="Update Profile" />
                </td>
                <td colspan="3">&nbsp;</td>
                <td>&nbsp;</td>
            </tr>
        </table>
</asp:Content>

