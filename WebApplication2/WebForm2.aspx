<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="WebApplication2.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:ListView runat="server" ID="Lv" DataKeyNames="Id" OnItemDeleting="Lv_ItemDeleting">
           <LayoutTemplate>
               <table>
                <tr>
                    <th>Name</th>
                    <th>Age</th>
                    <th>Delete</th>
                </tr>
                   <div id="itemPlaceholder" runat="server"></div>
                   </table>
           </LayoutTemplate>
        <ItemTemplate>
            <tr>
                <td><%#Eval("Name","Name is {0}") %></td>
                <td><%#Eval("Age") %></td>
                <td><asp:Button ID="BtnDel" runat="server" CommandName="Delete" Text="Delete"/></td>
            </tr>
        </ItemTemplate>
        
        </asp:ListView>
    </div>
    </form>
</body>
</html>
