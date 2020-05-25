<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site2.Master" AutoEventWireup="true" CodeBehind="ViewUser.aspx.cs" Inherits="Project.View.ViewUser" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<div class="container-fluid">
        &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;<asp:Label ID="LabelHeader" runat="server" Font-Bold="True" Font-Names="Franklin Gothic Heavy" Font-Size="X-Large" Font-Strikeout="False" Font-Underline="True" Text="List Users"></asp:Label>
        <br />
        &nbsp;
        <asp:GridView ID="GridViewUser" class="table table-dark" runat="server">
            <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <asp:LinkButton OnClick="Change_StatusBtn" ID="UserRedirect" class="btn btn-outline-light py-0" CommandArgument='<%# Eval("UserID")%>' runat="server" >Switch Status</asp:LinkButton>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    </div>
    <asp:Label Visible="false" ID="lblDelete" Text="Label" runat="server" />
    </asp:Content>