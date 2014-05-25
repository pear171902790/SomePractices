<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication1.WebForm1" %>

<!DOCTYPE html>

<html>
<head>
    <script type="text/javascript">
        var socket = new WebSocket('ws://localhost:8080/websession');
        socket.onopen = function () {
            alert('handshake successfully established. May send data now...');
        };
        socket.onclose = function () {
            alert('connection closed');
        };
    </script>
</head>
<body>
</body>
</html>