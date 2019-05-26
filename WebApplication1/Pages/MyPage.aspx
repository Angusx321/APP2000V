<%@ Page Title="Canteen: My Page" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="MyPage.aspx.cs" Inherits="WebApplication1.Pages.WebForm4" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
	<style type="text/css">
		.auto-style1 {
			height: 23px;
		}
	</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<asp:Label ID="WelcomeLabel" runat="server" Text="Welcome "></asp:Label>
	<h3>My Orders</h3>
	<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Button" />
	<asp:Panel ID="mainPanel" runat="server">
		<asp:DataList ID="DataList1" runat="server">
		</asp:DataList>
	</asp:Panel>
	<asp:BulletedList ID="BulletedList1" runat="server">
	</asp:BulletedList>
</asp:Content>
