<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site1.Master" AutoEventWireup="true" CodeBehind="ViewCart.aspx.cs" Inherits="Project.View.ViewCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <br />
    <asp:Label ID="empty" class="font-weight-bold text-center" Style="font-size: xx-large; margin: auto; width: 50%; padding: 10px;" Text="Your Cart is Empty" Visible="false" runat="server" />
    <asp:GridView ID="GridViewCart" class="table table-dark" ShowFooter="true" runat="server">
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton OnClick="UpdateCart_Click" ID="UpdateCartRedirect" class="btn btn-outline-light py-0" CommandArgument='<%# Eval("ID")%>' runat="server">Update cart</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
        <Columns>
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton OnClick="DeleteCart_Click" ID="DeleteCartRedirect" class="btn btn-outline-light py-0" CommandArgument='<%# Eval("ID")%>' runat="server">Delete cart</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
    <div class="container-fluid">
        <asp:Label ID="lblPayment" class="auto-style3 fontt font-weight-bold" Text="Payment Type : " runat="server" />
        <asp:DropDownList ID="DropDownListPaymentType" runat="server">
        </asp:DropDownList>
        <br />
        <br />
        <asp:Button ID="btnCheckout" runat="server" class="btn btn-info " Text="Checkout" OnClick="btnCheckout_Click" />
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
    <br />

</asp:Content>
