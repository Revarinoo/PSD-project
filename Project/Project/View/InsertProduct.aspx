<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site1.Master" AutoEventWireup="true" CodeBehind="InsertProduct.aspx.cs" Inherits="Project.View.InsertProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <table style="width: 100%;">
        <tr>
            <td class="auto-style1 fontt font-weight-bold">Name</td>
            <td class="auto-style3 fontt font-weight-bold">:</td>
            <td>
                <asp:TextBox ID="productName" runat="server" TabIndex="1" Width="300px"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredInsert1" runat="server" ControlToValidate="productName" EnableClientScript="False" ErrorMessage="Must be filled!" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style1 fontt font-weight-bold">Stock</td>
            <td class="auto-style3 fontt font-weight-bold">:</td>
            <td>
                <asp:TextBox ID="productStock" runat="server" TabIndex="2" Width="300px"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td class="auto-style1 fontt font-weight-bold">Price</td>
            <td class="auto-style3 fontt font-weight-bold">:</td>
            <td>
                <asp:TextBox ID="productPrice" runat="server" Width="300px"></asp:TextBox>
            </td>

        </tr>
        <tr>
            <td class="auto-style1 fontt font-weight-bold">Type</td>
            <td class="auto-style3 fontt font-weight-bold">:</td>
            <td>
                <asp:DropDownList ID="DropDownListType" runat="server">
                </asp:DropDownList>
            </td>
        </tr>
    </table>
    <br />
    <asp:Button ID="btnInsertP" runat="server" class="btn btn-info " Text="Insert" OnClick="btnInsertP_Click" />


    <br />
    <br />
    <asp:Label ID="LabelInvalid" runat="server" Text="Label" Visible="False" ForeColor="Red"></asp:Label>
    <br />
    <br />
    <asp:GridView ID="GridViewInsertProduct" class="table table-dark" runat="server">
    </asp:GridView>


    <br />
</asp:Content>
