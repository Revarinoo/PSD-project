<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site1.Master" AutoEventWireup="true" CodeBehind="UpdateProducts.aspx.cs" Inherits="Project.View.UpdateProducts" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;
    </p>
    <p>
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Arial Black" Font-Size="Medium" Text="Update Product"></asp:Label>
    </p>
    <p>
        &nbsp;
    </p>
    <p>
        <table style="width: 100%;">

            <tr>
                <td class="auto-style1 fontt font-weight-bold">Product Name</td>
                <td class="auto-style3 fontt font-weight-bold">:</td>
                <td>
                    <asp:TextBox ID="UpdatePName" runat="server" TabIndex="1" Width="300px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredUpdate1" runat="server" ControlToValidate="UpdatePName" EnableClientScript="False" ErrorMessage="Must be filled!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1 fontt font-weight-bold">Stock</td>
                <td class="auto-style1 fontt font-weight-bold">:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="UpdateStock" runat="server" TabIndex="2" Width="300px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredUpdateStock" runat="server" ControlToValidate="UpdateStock" EnableClientScript="False" ErrorMessage="Must be filled!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1 fontt font-weight-bold">Price</td>
                <td class="auto-style1 fontt font-weight-bold">:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="UpdatePrice" runat="server" TabIndex="2" Width="300px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredUpdatePrice" runat="server" ControlToValidate="UpdatePrice" EnableClientScript="False" ErrorMessage="Must be filled!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>

        </table>
    </p>
    <p>
        <asp:Button ID="btnUpdateP" runat="server" class="btn btn-info" Text="Update" OnClick="btnUpdateP_Click" />
        &nbsp;
    </p>
    <p>
        <asp:Label ID="LabelPr" runat="server" Text="Label" Visible="False" ForeColor="Red"></asp:Label>
    </p>
    <p>
        &nbsp;
    </p>
    <p>
        &nbsp;
    </p>
    <p>
        &nbsp;
    </p>
    <p>
        &nbsp;
    </p>
    <p>
        &nbsp;
    </p>
</asp:Content>
