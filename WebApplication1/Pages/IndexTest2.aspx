<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="IndexTest2.aspx.cs" Inherits="WebApplication1.Pages.IndexTest2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
    <asp:Panel ID="mainPanel" runat="server">
        <asp:DataList ID="DataList1" runat="server">
        </asp:DataList>
    </asp:Panel>
    <asp:BulletedList ID="BulletedList1" runat="server">
    </asp:BulletedList>
</asp:Content>
