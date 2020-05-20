<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site1.Master" AutoEventWireup="true" CodeBehind="UpdateProductType.aspx.cs" Inherits="Project.View.UpdateProductType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
     <style type="text/css">
        .auto-style1 {
            margin-left: 440px;
        }
        .auto-style2 {
            margin-left: 480px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style1">
        &nbsp;</p>
    <p class="auto-style2">
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Franklin Gothic Heavy" Font-Size="Large" Font-Underline="True" Text="Update Product Type"></asp:Label>
    </p>
        <div class="container-fluid">
        <asp:GridView ID="GridViewUpdate" class="table table-dark" runat="server">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton OnClick="UpdatePT" ID="UpdatePTRedirect" class="btn btn-outline-light py-0"  CommandArgument='<%# Eval("ProductTypeID")%>' runat="server">Select</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
        </div>
    </p>
    <p>
        &nbsp;</p>
    <br />
     
    <br />
    <br />
</asp:Content>
