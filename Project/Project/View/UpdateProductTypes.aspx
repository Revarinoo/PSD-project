<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site1.Master" AutoEventWireup="true" CodeBehind="UpdateProductTypes.aspx.cs" Inherits="Project.View.UpdateProductTypes" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
        &nbsp;</p>
    <p>
        <div class="container-fluid">
        &nbsp;<asp:Label ID="Label1" runat="server" Font-Names="Arial Black" Font-Size="Medium" Text="Update Product Type"></asp:Label>
    </p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        <table style="width:100%;">
        
            <tr>
                <td class="auto-style1 fontt font-weight-bold">Product Type</td>
                <td class="auto-style3 fontt font-weight-bold">:</td>
                <td>
                    <asp:TextBox ID="UpdateTypeName" runat="server" TabIndex="1" Width="300px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredUpdate2" runat="server" ControlToValidate="UpdateTypeName" EnableClientScript="False" ErrorMessage="Must be filled!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style1 fontt font-weight-bold" >Description</td>
                <td class="auto-style1 fontt font-weight-bold">:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="UpdateDesc" runat="server" TabIndex="2" Width="300px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredUpdate3" runat="server" ControlToValidate="UpdateDesc" EnableClientScript="False" ErrorMessage="Must be filled!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            
        </table>
        </p>
    <p>
        <asp:Button ID="btnUpdatefix" runat="server" class="btn btn-info " Text="Update" OnClick="btnUpdatefix_Click"  />
        </p>
    <p>
        <asp:Label ID="labelError" runat="server" ForeColor="Red" Text="Label" Visible="False"></asp:Label>
    </p>
    </div>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
    <p>
        &nbsp;</p>
</asp:Content>
