<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Welcome.aspx.cs" Inherits="MonsterWeb.Client.Welcome" %>

<%@ Register Src="~/Login.ascx" TagPrefix="uc" TagName="Login" %>

<asp:Content runat="server" ContentPlaceHolderID="body">
    <uc:Login runat="server"/>
</asp:Content>
