<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ControlError.aspx.cs" Inherits="Tienda.ControlError" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center">
            <div>
                Aplicacion Web GesTienda
            </div>
            <br />
            <div>
                Error en tiempo de ejecución
            </div>

            <div style="width: 60%; border: 1pt solid black; margin-left: 20%; margin-right: 20%; text-align:left">
                <p>Error ASP.NET: </p>
                <asp:Label ID="lblErrorASP" runat="server" ForeColor="Red"></asp:Label>
                
                <br />
                <br />

                <p>Error ADO.NET: </p>
                <asp:Label ID="lblErrorADO" runat="server" ForeColor="Red"></asp:Label>
                <br />
            </div>
        </div>
    </form>
</body>
</html>
