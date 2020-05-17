<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site1.Master" AutoEventWireup="true" CodeBehind="DeleteProduct.aspx.cs" Inherits="Project.View.DeleteProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Italic="False" Font-Names="Cooper Black" Font-Size="X-Large" Font-Strikeout="False" Font-Underline="False" Text="Delete Product"></asp:Label>
    </p>

    <p>
        <asp:GridView ID="GridViewDelP" class="table table-dark" runat="server">
        </asp:GridView>
    </p>
    <p>
        &nbsp;
    </p>
    <p>
        <table style="width: 100%;">
            <tr>
                <td class="auto-style1 fontt font-weight-bold">Product ID</td>
                <td class="auto-style3 fontt font-weight-bold">:</td>
                <td>
                    <asp:TextBox ID="DeleteProductID" runat="server" TabIndex="1" Width="300px"></asp:TextBox>
                </td>
            </tr>


        </table>
        &nbsp;
    </p>
    <p>
        <asp:Button ID="btnDeleteP" runat="server" class="btn btn-info" Text="Delete" OnClick="btnDeleteP_Click" />&nbsp;
    </p>
    <p>
        <asp:Label ID="LabelDelP" runat="server" Text="Label" Visible="False" ForeColor="Red"></asp:Label>
    </p>
</asp:Content>
