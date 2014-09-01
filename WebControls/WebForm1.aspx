<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebControls.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:ScriptManager runat="server"></asp:ScriptManager>
        <div>
            <asp:TextBox runat="server" ID="Txt"></asp:TextBox>
<%--            <asp:UpdatePanel runat="server" UpdateMode="Conditional">--%>
<%--                <ContentTemplate>--%>
            <asp:HiddenField runat="server" ID="Hid1"/>
                    <asp:Table runat="server" ID="Table1">
                        <asp:TableRow runat="server">
                            <asp:TableCell runat="server" Text="hehe"></asp:TableCell>
                        </asp:TableRow>
                    </asp:Table>
                    <asp:Button runat="server" OnClick="Add_Row2" />
<%--                </ContentTemplate>--%>
<%--            </asp:UpdatePanel>--%>
        </div>
    </form>
</body>
</html>
