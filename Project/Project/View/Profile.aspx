<%@ Page Title="" Language="C#" MasterPageFile="~/View/Site2.Master" AutoEventWireup="true" CodeBehind="Profile.aspx.cs" Inherits="Project.View.Profile" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div class="justify-content-center">USER PROFILE</div>
    <p>
        Email:
        <asp:Label ID="EmailLabel" runat="server" Text="User_Email"></asp:Label>
        </p>
    <p>
        Name: 
        <asp:Label ID="NameLabel" runat="server" Text="User_Name"></asp:Label>
        </p>
    <p>
        Gender: <asp:Label ID="GenderLabel" runat="server" Text="User_Gender"></asp:Label></p>
    <p>
        &nbsp;<asp:Button ID="BacktoHomeBtn" runat="server" OnClick="BacktoHomeBtn_Click" Text="Back to Home" />
        <asp:Button ID="UpdateProfileBtn" runat="server" Text="Update Profile" />
    </p>
</asp:Content>

