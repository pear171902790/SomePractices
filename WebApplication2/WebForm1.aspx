<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <asp:Repeater runat="server" ID="Rpt" OnItemCommand="Rpt_ItemCommand">
        <HeaderTemplate>
            <table>
                <tr>
                    <th>Name</th>
                    <th>Age</th>
                    <th>Delete</th>
                </tr>
        </HeaderTemplate>
        <ItemTemplate>
            <tr>
                <td><%#Eval("Name","Name is {0}") %></td>
                <td><%#Eval("Age") %></td>
                <td><asp:Button runat="server" CommandName="Delete" CommandArgument='<%#Eval("Id") %>' Text="Delete"/></td>
            </tr>
        </ItemTemplate>
        <FooterTemplate>
            </table>
        </FooterTemplate>
    </asp:Repeater>
    </div>
    </form>
</body>
</html>
