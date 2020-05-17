<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site1.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Project.View.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" type="text/css" href="Home.css">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p class="auto-style1">
        <asp:Label ID="LblMessage" class="fontt font-weight-bold" runat="server" Text="Welcome"></asp:Label>
    </p>
    <div class="col-md-12 ">
        <p class="auto-style1">
            <asp:Button ID="btnViewProduct" runat="server" class="btn btn-outline-info" Text="View Product" OnClick="DoViewProduct" />

            &nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnViewUser" runat="server" class="btn btn-outline-info" Text="View User" OnClick="btnViewUser_Click" />
            &nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnInsertProduct" runat="server" class="btn btn-outline-info" Text="Insert Product" OnClick="btnInsertProduct_Click" />
            &nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnUpdateProduct" runat="server" class="btn btn-outline-info" Text="Update Product" OnClick="btnUpdateProduct_Click" />
            &nbsp;&nbsp;
    <asp:Button ID="btnViewProductType" runat="server" class="btn btn-outline-info" Text="View Product Type" OnClick="btnViewProductType_Click" />
            &nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnInsertProductType" runat="server" class="btn btn-outline-info" Text="Insert Product Type" OnClick="btnInsertProductType_Click" />
            &nbsp;&nbsp;&nbsp;
    <asp:Button ID="btnUpdateProductType" runat="server" class="btn btn-outline-info" Text="Update Product Type" OnClick="btnUpdateProductType_Click" />
        </p>

        <p>
            &nbsp;
        </p>
        <p>
            <div class="container-fluid">
                &nbsp;&nbsp;
        <asp:GridView ID="GridViewCart" class="table table-dark" runat="server">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton OnClick="Cart_Click" ID="CartRedirect" class="btn btn-outline-light py-0" CommandArgument='<%# Eval("ProductID")%>' runat="server" >Add to cart</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
            </div>
        </p>
        <p>
            &nbsp;
        </p>

        &nbsp;</p>
    </div>
</asp:Content>
