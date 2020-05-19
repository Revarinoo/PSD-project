<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site1.Master" AutoEventWireup="true" CodeBehind="AddtoCart.aspx.cs" Inherits="Project.View.AddtoCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <asp:GridView ID="GridViewAddCart" class="table table-dark" runat="server"></asp:GridView>
    <br />
    <br />
    <table>
        <tr>
            <td class="auto-style1 fontt font-weight-bold">Quantity</td>
            <td class="auto-style3 fontt font-weight-bold">:</td>
            <td>
                <asp:TextBox ID="Quantity" runat="server" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Quantity" EnableClientScript="False" ForeColor="Red" ErrorMessage="Must be filled!"></asp:RequiredFieldValidator>
            </td>
        </tr>
    </table>
    <br />
    <asp:Button ID="btnAddtoCart" runat="server" class="btn btn-info " Text="Add to Cart" OnClick="AddtoCart_Click" />
    <br />
    <br />
    <asp:Label ID="lblNotif" Visible="false" class="fontt font-weight-bold" runat="server" ForeColor="Red" Text="label" runat="server" />

    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
