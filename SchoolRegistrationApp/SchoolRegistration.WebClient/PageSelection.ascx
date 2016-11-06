<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="PageSelection.ascx.cs" Inherits="SchoolRegistration.WebClient.PageSelection" %>

<asp:Button runat="server" ID="Admin" Text="Admin" OnClick="Admin_Click" />

<asp:Button runat="server" ID="Professor" Text="Profesor" OnClick="Professor_Click" />

<asp:Button runat="server" ID="Student" Text="Student" OnClick="Student_Click" />

<asp:Label runat="server" ID="Message"></asp:Label>