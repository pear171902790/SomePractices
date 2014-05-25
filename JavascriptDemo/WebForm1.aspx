<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="JavascriptDemo.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.7.1.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    <input type="button" value="btn" id="btn"/>
    </div>
    </form>
    <script>
        var json = <%=Json%>;
        $('#btn').click(function() {
            $.ajax({
                url: '?',
                type: 'post',
                data:JSON.stringify(json),
                dataType:'json'
            });
        });
    </script>
</body>
</html>
