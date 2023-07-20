<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="WebApplication2.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Segundo Examen Parcial</title>
    
    <meta http-equiv="Content-Type" content="text/html; charset=UTF-8" />
    <!--JQuery-->
    <script type="text/javascript" src="/Scripts/jquery-3.4.1.min.js"></script>
    <!-- Bootstrap core CSS -->
    <link rel="stylesheet" href="/Content/bootstrap.min.css" />
    <script type="text/javascript" src="/Scripts/bootstrap.min.js"></script>
    <script type="text/javascript" src="/Scripts/modernizr-2.8.3.js"></script>

<script>
    function verificarPassword() {
        var contra1 = document.getElementById('TextBoxPassword').value;
        var contra2 = document.getElementById('TextBoxPassword1').value;
        if (contra1 !== contra2) {
            alert("LOS PASSWORDS NO SON IGUALES!");
            return false;
        }
        return true;
    }
</script>

</head>
<body>
<div class="container">
        <form id="form1" runat="server">
            <div class="row">
                <div class="span12">
                    <h1>Log In: </h1>
                </div>
            </div>

            <div class="form-group row mt-3">
                <div class="col-sm-2 col-form-label">
                    <asp:Label ID="LabelUsuario" runat="server" Text="Usuario"></asp:Label>
                </div>
                <div class="col-sm-4">
                    <asp:TextBox ID="TextBoxUsuario" class="form-control" runat="server"></asp:TextBox>
                </div>
            </div>

            <div class="form-group row mt-3">
                <div class="col-sm-2 col-form-label">
                    <asp:Label ID="Password" runat="server" Text="Password"></asp:Label>
                </div>
                <div class="col-sm-4">
                    <asp:TextBox ID="TextBoxPassword" class="form-control" runat="server" TextMode="Password"></asp:TextBox>
                </div>
            </div>

            <div class="form-group row mt-3">
                <div class="col-sm-2 col-form-label">
                    <asp:Label ID="Password2" runat="server" Text="Verificar Password"></asp:Label>
                </div>
                <div class="col-sm-4">
                    <asp:TextBox ID="TextBoxPassword1" class="form-control" runat="server" TextMode="Password"></asp:TextBox>
                </div>
            </div>

            <div class="text-center mt-3">
                <div class="btn-group">
                    <asp:Button ID="ButtonRegistrar" runat="server" Text="Registrar" 
                        OnClientClick="return verificarPassword();" class="btn btn-success btn-lg"/>
                </div>
            </div>
        </form>

    </div>
</body>
</html>