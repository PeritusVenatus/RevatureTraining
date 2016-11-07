<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StudentView.aspx.cs" Inherits="SchoolRegistration.WebClient.StudentView" %>

<%@ Register Src="~/PageSelection.ascx" TagPrefix="uc" TagName="Selection" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
       <asp:Label runat="server" Font-Bold="true" Font-Size="X-Large">School Registraton</asp:Label>
    <div>
          <uc:Selection runat="server" />
       <div></div>
       <asp:Label runat="server" Font-Size="Large">copyright &copy; 2016 - present</asp:Label>
    </div>
    </form>
</body>
</html>