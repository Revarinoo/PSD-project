<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site1.Master" AutoEventWireup="true" CodeBehind="ViewProduct.aspx.cs" Inherits="Project.View.ViewProduct" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <br />
    <br />
    <br />
    <div class="container-fluid">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Label ID="LabelHeader" runat="server" Font-Bold="True" Font-Names="Franklin Gothic Heavy" Font-Size="X-Large" Font-Strikeout="False" Font-Underline="True" Text="List Product"></asp:Label>
        <br />
        &nbsp;
        <asp:GridView ID="GridViewProduct" class="table table-dark" runat="server">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton OnClick="AddCart_Click" ID="CartRedirect" class="btn btn-outline-light py-0" CommandArgument='<%# Eval("ProductID")%>' runat="server" >Add to cart</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button Text="Insert" class="btn btn-outline-light py-0" OnClick="InsertProduct_Click" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton OnClick="UpdateProduct_Click" ID="UpdateProduct" class="btn btn-outline-light py-0" CommandArgument='<%# Eval("ProductID")%>' runat="server" >Update</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton OnClick="DeleteProduct_Click" ID="DeleteProduct" class="btn btn-outline-light py-0" CommandArgument='<%# Eval("ProductID")%>' runat="server" >Delete</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <asp:Label Visible="false" ID="lblDelete" Text="Label" runat="server" />
    <br />
    <br />
    <br />
    <br />
    <br />
</asp:Content>
