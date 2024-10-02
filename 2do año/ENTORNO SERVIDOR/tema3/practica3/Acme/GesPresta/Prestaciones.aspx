<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Prestaciones.aspx.cs" Inherits="GesPresta.Prestaciones" %>

<%@ Register src="Cabecera.ascx" tagname="Cabecera" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="HojaEstilos.css"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:Cabecera ID="Cabecera1" runat="server" />
            <h2 class="titEmp">DATOS DE LAS PRESTACIONES</h2>

            <div class="cuerpo">
                <div class="linea">
                    <div class="textos">
                        <asp:Label ID="lblCodPre" Text="text" runat="server">Codigo Presentación:</asp:Label> 
                    </div>
                    <div class="controles">
                        <asp:TextBox ID="txtCodPre" runat="server" Width="154px"></asp:TextBox> <br />
                    </div>
                </div>

                <div class="linea">
                    <div class="textos">
                        <asp:Label ID="lblDesPre" Text="text" runat="server">Descripción</asp:Label> 
                    </div>
                    <div class="controles">
                        <asp:TextBox ID="txtDesPre" runat="server" Width="496px"></asp:TextBox> <br />
                    </div>
                </div>

                <div class="linea">
                    <div class="textos">
                        <asp:Label ID="lblImpPre" Text="text" runat="server">Importe Fijo</asp:Label> 
                    </div>
                    <div class="controles">
                        <asp:TextBox ID="txtImpPre" runat="server"></asp:TextBox> <br />
                    </div>
                </div>

                <div class="linea">
                    <div class="textos">
                        <asp:Label ID="lblPorPre" Text="text" runat="server">Porcentaje del Importe</asp:Label> 
                    </div>
                    <div class="controles">
                        <asp:TextBox ID="txtPorPre" runat="server"></asp:TextBox> <br />
                    </div>
                </div>

                <div class="linea">
                    <div class="textos">
                        <asp:Label ID="lblTipPre" Text="Text" runat="server">Tipo de Prestación:</asp:Label> 
                    </div>
                    <div class="controles">
                        <asp:DropDownList ID="ddlTipPre" runat="server">
                        <asp:ListItem Value="Dentaria">Dentaria</asp:ListItem>
                        <asp:ListItem Value="Familiar">Familiar</asp:ListItem>
                        <asp:ListItem Value="Ocular">Ocular</asp:ListItem>
                        <asp:ListItem Value="Otras">Otras</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                    </div>
                </div>
            </div>

            <div class="btn">
                <asp:Button ID="cmdEnviar" Text="Enviar" runat="server" />
            </div>
        </div>
    </form>
</body>
</html>
