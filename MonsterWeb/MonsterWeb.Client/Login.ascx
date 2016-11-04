<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Login.ascx.cs" Inherits="MonsterWeb.Client.Login" %>

<asp:Label runat="server">Username</asp:Label>
<asp:TextBox runat="server" ID="Username"></asp:TextBox>

<asp:Label runat="server">Password</asp:Label>
<asp:TextBox runat="server" ID="Password" TextMode="Password"></asp:TextBox>

<asp:Button runat="server" ID="Login" Text="Login" OnClick="Login_Click"/>

<asp:Label runat="server" ID="Message"></asp:Label>

