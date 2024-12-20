<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LineasFactura.aspx.cs" Inherits="GesFactura.LineasFactura" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="HojaEstilos.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
            <h1 style="text-align:center">
                Uso de Servicio Web - Cálculos factura de un artículos
            </h1>
            <div class="cuerpo">
                 <div class="linea">
                     <div class="textos">
                         <asp:Label ID="lbl1" Text="text" runat="server">Cantidad</asp:Label> 
                     </div>
                     <div class="controles">
                         <asp:TextBox ID="txtCantidad" runat="server" Width="200px"></asp:TextBox> <br />
                     </div>
                 </div>

                 <div class="linea">
                     <div class="textos">
                         <asp:Label ID="lbl2" Text="text" runat="server">Precio</asp:Label> 
                     </div>
                     <div class="controles">
                         <asp:TextBox ID="txtPrecio" runat="server" Width="200px"></asp:TextBox> <br />
                     </div>
                 </div>

                 <div class="linea">
                     <div class="textos">
                         <asp:Label ID="lbl3" Text="text" runat="server">Descuento (%)</asp:Label> 
                     </div>
                     <div class="controles">
                         <asp:TextBox ID="txtDescuento" runat="server" Width="200px"></asp:TextBox> <br />
                     </div>
                 </div>

                 <div class="linea">
                     <div class="textos">
                         <asp:Label ID="lbl4" Text="text" runat="server">Tipo de IVA (%)</asp:Label> 
                     </div>
                     <div class="controles">
                         <asp:TextBox ID="txtTipoIVA" runat="server" Width="200px"></asp:TextBox> <br />
                     </div>
                 </div>
            </div>

        <div style="text-align:center">
            <asp:Button ID="btnEnviar" runat="server" Text="Enviar" OnClick="btnEnviar_Click" />
        </div>

        <p style="text-align:center">Resultado de los cálculos:</p>

        <div class="cuerpoCalculos">
            <div class="linea">
                <div class="desCalculos">
                    <asp:Label ID="lbl5" Text="text" runat="server">Bruto</asp:Label> 
                </div>
                 <div class="desCalculos">
                    <asp:Label ID="lbl6" Text="text" runat="server">Descuento</asp:Label> 
                </div>
                <div class="desCalculos">
                    <asp:Label ID="lbl7" Text="text" runat="server">Base Imponible</asp:Label> 
                </div>
                <div class="desCalculos">
                    <asp:Label ID="lbl8" Text="text" runat="server">IVA</asp:Label> 
                </div>
                <div class="desCalculos">
                    <asp:Label ID="lbl9" Text="text" runat="server">Total</asp:Label> 
                </div>
            </div>
            <div class="linea">
                <div class="desCalculos">
                    <asp:Label ID="lblBruto" Text="" runat="server"></asp:Label> 
                </div>
                 <div class="desCalculos">
                    <asp:Label ID="lblDescuento" Text="" runat="server"></asp:Label> 
                </div>
                <div class="desCalculos">
                    <asp:Label ID="lblBaseImponible" Text="" runat="server"></asp:Label> 
                </div>
                <div class="desCalculos">
                    <asp:Label ID="lblIVA" Text="" runat="server"></asp:Label> 
                </div>
                <div class="desCalculos">
                    <asp:Label ID="lblTotal" Text="" runat="server"></asp:Label> 
                </div>
            </div>
        </div>
            
    </form>
</body>
</html>
            
            
            