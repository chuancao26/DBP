<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Auxiliar.aspx.cs" Inherits="WebApplication2.WebForm1" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
    <title></title>
<style>
    h1 {
        text-align: center;
        color: #84c754;
    }
    body {
        background-color: #333;
        font-family: sans-serif;
        color: #84c754; /* Set the font color to green */
    }
    label {
        font-size: 18px;
        color: #84c754;
    }
    input[type="text"],
    select,
    textarea {
        color: #84c754;
        background-color: #222;
        border: 1px solid white;
        border-radius: 10px;
        padding: 10px;
        margin-bottom: 15px;
        width: 100%;
        box-sizing: border-box;
    }
    input[type="radio"] {
        margin-right: 5px;
    }
    .form-group {
        margin-bottom: 20px;
    }
    .form-group label {
        display: block;
        margin-bottom: 5px;
    }
    .enviar-btn {
        background-color: #84c754;
        color: #222;
        border: none;
        border-radius: 10px;
        padding: 10px;
        cursor: pointer;
        margin-top: 10px;
    }

    .enviar-btn:hover {
        background-color: #222;
        color: #84c754;
    }
</style>

    <script type="text/javascript">
        function cookies() {
            var cookie = document.cookie;
            document.getElementById("cookieText").value = "userinfo:\n" + cookie;

            return false;
        }
    </script>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="usuario" runat="server" Text="Label"></asp:Label>
        </div>
        <div>
            <asp:Label ID="name" runat="server" Text="Label"></asp:Label>
        </div>
        <div>
            <asp:Label ID="secondname" runat="server" Text="Label"></asp:Label>
        </div>
        <div>
            <asp:Button ID="showbttn" runat="server" OnClientClick="return cookies()" Text="Mostrar cookie" />
        </div>
        <div>
            <asp:TextBox ID="cookieText" Visible="true" TextMode="MultiLine" Rows="5" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
