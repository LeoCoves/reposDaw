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
                        <asp:TextBox ID="txtCodPre" runat="server" Width="154px"></asp:TextBox> 
                        <asp:RequiredFieldValidator ID="rqdTxtCodPre"  ControlToValidate="txtCodPre" runat="server" ErrorMessage="El Codigo Empleado es obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="regTxtCodPre" ControlToValidate="txtCodPre" runat="server" ValidationExpression="\d{3}-\d{3}-\d{3}" ErrorMessage="El formato de los datos a introducir debe ser: 3digitos, guion, 3 digitos, guion y 3 digitos" ForeColor="Green"></asp:RegularExpressionValidator>
                        <br />
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
                        <asp:TextBox ID="txtImpPre" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="rqdTxtImpPre"  ControlToValidate="txtImpPre" runat="server" ErrorMessage="El Importe es obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rngTxtImpPre" runat="server" ControlToValidate="txtImpPre" Type="Double" MinimumValue="0,00" MaximumValue="500,00" ErrorMessage="El importe debe estar comprendido entre 0 y 500" ForeColor="Red"></asp:RangeValidator>
                        <br />
                    </div>
                </div>

                <div class="linea">
                    <div class="textos">
                        <asp:Label ID="lblPorPre" Text="text" runat="server">Porcentaje del Importe</asp:Label> 
                    </div>
                    <div class="controles">
                        <asp:TextBox ID="txtPorPre" runat="server"></asp:TextBox> 
                        <asp:RequiredFieldValidator ID="rqdTxtPorPre"  ControlToValidate="txtPorPre" runat="server" ErrorMessage="El Porcentaje del Importe es obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rngTxtPorPre" runat="server" ControlToValidate="txtPorPre" Type="Double" MinimumValue="0,00" MaximumValue="15,00" ErrorMessage="El Porcentaje del Importe debe estar comprendido entre el 0% y 15%" ForeColor="Red"></asp:RangeValidator>
                        <br />
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
