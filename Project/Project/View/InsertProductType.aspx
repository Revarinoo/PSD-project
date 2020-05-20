<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site1.Master" AutoEventWireup="true" CodeBehind="InsertProductType.aspx.cs" Inherits="Project.View.InsertProductType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            height: 40px;
        }
        .auto-style2 {
            width: 199px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div class="container-fluid">
        <br />
        <br />
    <br>
    <table style="width:100%;">
            <tr>
                <td class="auto-style2 fontt font-weight-bold">Product Type</td>
                <td class="auto-style3 fontt font-weight-bold">:</td>
                <td>
                    <asp:TextBox ID="typeName" runat="server" TabIndex="1" Width="300px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredInsert2" runat="server" ControlToValidate="typeName" EnableClientScript="False" ErrorMessage="Must be filled!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style2 fontt font-weight-bold">Description</td>
                <td class="auto-style1 fontt font-weight-bold">:</td>
                <td class="auto-style1">
                    <asp:TextBox ID="typeDesc" runat="server" TabIndex="2" Width="300px"></asp:TextBox>
                    <asp:RequiredFieldValidator ID="RequiredInsert3" runat="server" ControlToValidate="typeDesc" EnableClientScript="False" ErrorMessage="Must be filled!" ForeColor="Red"></asp:RequiredFieldValidator>
                </td>
            </tr>
            
        </table>
     <br />
           <asp:Button ID="btnInsertPT" runat="server" class="btn btn-info" Text="Insert" OnClick="btnInsertPT_Click"  />
                    
    <br />
    <br />
    <asp:Label ID="lblInfo" runat="server" Text="Label" Visible="False" ForeColor="Red"></asp:Label>
    </div>                
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
