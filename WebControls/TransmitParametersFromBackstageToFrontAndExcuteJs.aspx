<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TransmitParametersFromBackstageToFrontAndExcuteJs.aspx.cs" Inherits="WebControls.TransmitParametersFromBackstageToFrontAndExcuteJs" %>

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
                <asp:TextBox runat="server" ID="TB1"></asp:TextBox>
                <asp:Button runat="server" ID="Submit1"/>
            </ContentTemplate>
        </asp:UpdatePanel>
    </div>
    </form>
    <script>
        var pageLoaded = function (sender, args) {
            var up1ClientId = "<%= UP1.ClientID %>";
            var item = args.get_dataItems()[up1ClientId];
            if (!(typeof (item) === 'undefined')) {
                alert(item);
            }
        };
        var prm = Sys.WebForms.PageRequestManager.getInstance();
        prm.add_pageLoaded(pageLoaded);
    </script>
</body>
</html>
