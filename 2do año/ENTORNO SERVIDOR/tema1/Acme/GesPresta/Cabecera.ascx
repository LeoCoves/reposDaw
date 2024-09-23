<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Cabecera.ascx.cs" Inherits="GesPresta.Cabecera" %>&nbsp;
<link rel="stylesheet" href="HojaEstilos.css">
<div class="container">
 
        <asp:LinkButton class="links" id="lblInicio" PostBackURL="Default.aspx" runat="server">Inicio</asp:LinkButton>
        <asp:LinkButton class="links" id="lblEmpleados" PostBackURL="Empleados.aspx" runat="server">Empleados</asp:LinkButton>
        <asp:LinkButton class="links" id="lblPresentaciones" PostBackURL="Prestaciones.aspx" runat="server">Presentaciones</asp:LinkButton>


    <div class="titulos">
        <h1>ACME INOVACIÓN, S. FIG.</h1>
        <h2>Gestión de Prestaciones Sociales</h2> <hr />
    </div>

</div>