<%@ Page Title="Canteen: Login" Language="C#" MasterPageFile="../Site1.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebApplication1.WebForm3" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style1 {
        width: 712px;
    }
    .auto-style2 {
        width: 4px;
    }
    .auto-style3 {
        width: 6px;
        height: 33px;
    }
    .auto-style5 {
        width: 90px;
    }
    .auto-style6 {
        width: 157px;
    }
    .auto-style7 {
        width: 157px;
        height: 33px;
    }
    .auto-style8 {
        width: 90px;
        height: 33px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
	<h2>Login</h2>
	<table class="auto-style1">
		<tr>
			<td class="auto-style3">Email</td>
			<td class="auto-style7">
				<asp:TextBox ID="Email" runat="server"></asp:TextBox>
			</td>
			<td class="auto-style8">
				<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="Email" ErrorMessage="Enter your email" ForeColor="Red"></asp:RequiredFieldValidator>
			</td>
		</tr>
		<tr>
			<td class="auto-style2">Password</td>
			<td class="auto-style6">
				<asp:TextBox ID="Password" runat="server" TextMode="Password"></asp:TextBox>
			</td>
			<td class="auto-style5">
				<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="Password" ErrorMessage="Enter your password" ForeColor="Red"></asp:RequiredFieldValidator>
			</td>
		</tr>
		<tr>
			<td class="auto-style2">&nbsp;</td>
			<td class="auto-style6">
				<asp:Button ID="LoginButton" runat="server" Text="Login" OnClick="LoginButton_Click" />
				<input id="Reset1" type="reset" value="Reset" /></td>
			<td class="auto-style5">
				&nbsp;</td>
		</tr>
		<tr>
			<td class="auto-style2">&nbsp;</td>
			<td class="auto-style6">
				<asp:HyperLink ID="HyperLink4" runat="server" NavigateUrl="~/Pages/NewUser.aspx">Create new user.</asp:HyperLink>
				<br />
				<br />
				<asp:Label ID="Label1" runat="server" ForeColor="Red"></asp:Label>
			</td>
			<td class="auto-style5">
				&nbsp;</td>
		</tr>
	</table>
</asp:Content>
