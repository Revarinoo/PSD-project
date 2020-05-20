<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site1.Master" AutoEventWireup="true" CodeBehind="ViewProductType.aspx.cs" Inherits="Project.View.ViewProductType" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <div class="container">
        <asp:GridView ID="GridViewPT" class="table table-dark" runat="server">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button Text="Insert" class="btn btn-outline-light py-0" OnClick="InsertProductType_Click" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton OnClick="UpdateProductType_Click" ID="UpdateProductType" class="btn btn-outline-light py-0" CommandArgument='<%# Eval("ProductTypeID")%>' runat="server" >Update</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton OnClick="DeleteProductType_Click" ID="DeleteProductType" class="btn btn-outline-light py-0" CommandArgument='<%# Eval("ProductTypeID")%>' runat="server" >Delete</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <br />
    <br />
    <asp:Label Visible="false" ID="lblDelete" ForeColor="Red" Text="Label" runat="server" />
    <br />
    <br />
</asp:Content>
