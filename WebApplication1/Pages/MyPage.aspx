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
	<br />
	<asp:Button ID="LogoutButton" runat="server" OnClick="LogoutButton_Click" Text="Logout" />
	<br />
	<br />
	<h3>My Orders</h3>
	<p>
		<%--<asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false" AllowPaging="true"
			OnPageIndexChanging="OnPageIndexChanging" PageSize="10">
			<Columns>
				<asp:BoundField ItemStyle-Width="150px" DataField="foodID" HeaderText="Food Item" />
				<asp:BoundField ItemStyle-Width="150px" DataField="datetime" HeaderText="Date" />
				<asp:BoundField ItemStyle-Width="150px" DataField="orderstate" HeaderText="Status" />
			</Columns>
		</asp:GridView>--%>
	</p>
</asp:Content>
