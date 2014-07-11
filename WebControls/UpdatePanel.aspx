<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdatePanel.aspx.cs" Inherits="WebControls.UpdatePanel" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:ScriptManager runat="server"></asp:ScriptManager>
            <asp:UpdatePanel runat="server" ID="UP1">
                <ContentTemplate>
                    <asp:TextBox runat="server" ID="TB1"></asp:TextBox><br />
                    <%=Str %><br />
                    <script>
                        alert('up1 not ajax');
                        var prm = Sys.WebForms.PageRequestManager.getInstance();
                        prm.add_pageLoaded(function() {
                            alert('it alert even first or ajax');
                        });
                    </script>
                    <asp:Button runat="server" Text="Submit1" />
                </ContentTemplate>
            </asp:UpdatePanel>
        </div>
    </form>
    <script>
        alert('not in updatepanel');
    </script>
</body>
</html>
