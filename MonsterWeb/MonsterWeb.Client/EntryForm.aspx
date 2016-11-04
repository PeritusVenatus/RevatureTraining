<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="EntryForm.aspx.cs" Inherits="MonsterWeb.Client.EntryForm" %>

<%@ Register Src="~/Login.ascx" TagPrefix="uc" TagName="Login" %>

<asp:Content runat="server" ContentPlaceHolderID="body">
       <asp:Label runat="server" ID="MonsterName"></asp:Label>

       <asp:TextBox runat="server" ID="MonsterName_Text"></asp:TextBox>

       <asp:Label runat="server" ID="MonsterGender"></asp:Label>

       <asp:DropDownList runat="server" ID="MonsterGender_List"></asp:DropDownList>

       <asp:Button runat="server"  ID="MonsterSubmit" Text="Submit" OnClick="MonsterSubmit_Click"/>
</asp:Content>
