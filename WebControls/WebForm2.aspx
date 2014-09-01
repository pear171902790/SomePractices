<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebControls.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <% if (!A)
       {%>
        <asp:TextBox runat="server" ID="Txt1" Text="11111"></asp:TextBox>
       <%} %>
    </div>
    </form>
</body>
</html>
