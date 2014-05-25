<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="deferred.aspx.cs" Inherits="JavascriptDemo.deferred" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
    </form>
    <script src="Scripts/jquery-1.7.1.min.js"></script>
    <script>
        var aa = function() {
            var bb = function() {
                alert('success');
            };
            window.setTimeout(bb, 5000);
        };
        $.when(aa).done('')
    </script>
</body>
</html>
