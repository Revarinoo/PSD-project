<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site1.Master" AutoEventWireup="true" CodeBehind="UpdateProduct.aspx.cs" Inherits="Project.View.UpdateProduct" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            margin-left: 520px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style1">
        <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Names="Franklin Gothic Heavy" Font-Size="Large" Text="Update Product" Font-Underline="True"></asp:Label>
        &nbsp;&nbsp;
    </p>
    <p>
        <div class="container-fluid">
            <asp:GridView ID="GridViewUpdateP" class="table table-dark" runat="server">
                <Columns>
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton OnClick="UpdateP_Click" ID="UpdatePRedirect" class="btn btn-outline-light py-0" CommandArgument='<%# Eval("ProductID")%>' runat="server">Select</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </p>
    <p>
        <br />
    </p>
    <p>
        &nbsp;
    </p>
</asp:Content>
