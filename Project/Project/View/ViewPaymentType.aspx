<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site1.Master" AutoEventWireup="true" CodeBehind="ViewPaymentType.aspx.cs" Inherits="Project.View.ViewPaymentType" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <br />
    <br />
    <div class="container">
        <asp:GridView ID="GridViewPayment" class="table table-dark" runat="server">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:Button Text="Insert" class="btn btn-outline-light py-0" OnClick="InsertPaymentType_Click" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton OnClick="UpdatePaymentType_Click" ID="UpdatePaymentType" class="btn btn-outline-light py-0" CommandArgument='<%# Eval("PaymentTypeID")%>' runat="server" >Update</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton OnClick="DeletePaymentType_Click" ID="DeletePaymentType" class="btn btn-outline-light py-0" CommandArgument='<%# Eval("PaymentTypeID")%>' runat="server" >Delete</asp:LinkButton>
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
