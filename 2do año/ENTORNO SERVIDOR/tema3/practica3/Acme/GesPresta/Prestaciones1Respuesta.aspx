<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prestaciones1Respuesta.aspx.cs" Inherits="GesPresta.WebForm2" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link rel="stylesheet" href="HojaEstilos.css"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>VALORES RECIBIDOS DESDE EL FORMULARIO PRESTACIONES1.ASPX</h2>

            <div class="valores">
                <asp:Label Visible="false" ID="lblValores" runat="server" Text="Label"></asp:Label>
            </div>
                

        </div>
    </form>
</body>
</html>
