<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site1.Master" AutoEventWireup="true" CodeBehind="ViewCart.aspx.cs" Inherits="Project.View.ViewCart" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <asp:GridView ID="GridViewCart" class="table table-dark" ShowFooter="true" runat="server">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton OnClick="UpdateCart_Click" ID="UpdateCartRedirect" class="btn btn-outline-light py-0" CommandArgument='<%# Eval("ProductID")%>' runat="server" >Add to cart</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            
            <%--<Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton OnClick="DeleteCart_Click" ID="DeleteCartRedirect" class="btn btn-outline-light py-0" CommandArgument='<%# Eval("UserID") + ";" + Eval("ProductID")%>' runat="server" >Add to cart</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>--%>
        </asp:GridView>
</asp:Content>
