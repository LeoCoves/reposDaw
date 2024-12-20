<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Ejercicio1.aspx.cs" Inherits="ServiciosWebCS.Ejercicio1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<link rel="stylesheet" src="estilos.css">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align: center">
            <h2>CONSUMIR UN SERVICIO WEB YA EXISTENTE</h2>
            <h1>Titulaciones Oficiales en la Universidad</h1>
            <div>
                <asp:Label ID="lblTexto1" runat="server" Text="Label">Curso acádemico (formato aaaa-aa)</asp:Label>
                <asp:TextBox ID="txtCurso" runat="server"></asp:TextBox>
                <asp:Button ID="btnObtenerInformacion" runat="server" Text="Obtener información" OnClick="btnObtenerInformacion_Click" />
            </div>
        </div>
        <asp:Label ID="lblResultado" runat="server" style="margin:1%"></asp:Label>
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
    </form>
</body>
</html>
