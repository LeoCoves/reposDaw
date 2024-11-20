<%@ OutputCache Duration="1" VaryByParam="None" %>
<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Registrarse.aspx.cs" Inherits="Tienda.Registrarse" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Registrarse</title>
    <link href="~/Estilos/HojaEstilo.css" rel="stylesheet" type="text/css" />
</head>
<body>
    <form id="form1" runat="server">
        <div id="cabecera">
           <div id="cabecera1">
              <br />
              comerciodaw.com &nbsp;
           </div>
           <div id="cabecera2">
               <br />
               &nbsp;&nbsp;TIENDA ONLINE - SHOPPING DAW<br />
               <br />
           </div>
        </div>

        <div style="text-align:center">
            <h2>GesTienda</h2>
            <h3>Registro de Usuario</h3>
        </div>

        <div style="display: flex; justify-content: center">
             <div style="display:table; padding-bottom: 4%; padding-top: 2%">

                 <div style="display: table-row; margin: 10px">
                     <div style="display: table-cell; text-align: right; padding-right: 10px;">
                         <asp:Label ID="lblCorCli" runat="server" Text="Correo Electronico"></asp:Label>
                     </div>
                     <div style="display: table-cell; padding: 5px">
                         <asp:TextBox ID="txtCorCli" runat="server" Width="365px"></asp:TextBox>
                     </div>
                 </div>

                 <div style="display: table-row">
                     <div style="display: table-cell; text-align: right; padding-right: 10px;">
                         <asp:Label ID="lblPassword1" runat="server" Text="Contraseña"></asp:Label>
                     </div>
                     <div style="display: table-cell; padding: 5px">
                         <asp:TextBox ID="txtPassword1" runat="server" TextMode="Password"></asp:TextBox>
                     </div>
                 </div>

                 <div style="display: table-row">
                     <div style="display: table-cell; text-align: right; padding-right: 10px;">
                         <asp:Label ID="lblPassword2" runat="server" Text="Introduzca nuevamente la Contraseña"></asp:Label>
                     </div>
                     <div style="display: table-cell; padding: 5px">
                         <asp:TextBox ID="txtPassword2" runat="server" TextMode="Password" ></asp:TextBox>
                     </div>
                 </div>

                 <div style="display: table-row">
                    <div style="display: table-cell; text-align: right; padding-right: 10px;">
                        <asp:Label ID="lblIdCliente" runat="server" Text="NIF/NIE/CIF"></asp:Label>
                    </div>
                    <div style="display: table-cell; padding: 5px">
                        <asp:TextBox ID="txtIdCliente" runat="server" Width="230px" ></asp:TextBox>
                    </div>
                </div>

                  <div style="display: table-row">
                    <div style="display: table-cell; text-align: right; padding-right: 10px;">
                        <asp:Label ID="lblNomCli" runat="server" Text="Nombre / Razon Social"></asp:Label>
                    </div>
                    <div style="display: table-cell; padding: 5px">
                        <asp:TextBox ID="txtNomCli" runat="server" Width="367px" ></asp:TextBox>
                    </div>
                </div>

                <div style="display: table-row">
                    <div style="display: table-cell; text-align: right; padding-right: 10px;">
                        <asp:Label ID="lblDirCli" runat="server" Text="Dirección"></asp:Label>
                    </div>
                    <div style="display: table-cell; padding: 5px">
                        <asp:TextBox ID="txtDirCli" runat="server" Width="363px" ></asp:TextBox>
                    </div>
                </div>

                   <div style="display: table-row">
                        <div style="display: table-cell; text-align: right; padding-right: 10px;">
                            <asp:Label ID="lblPobCli" runat="server" Text="Población"></asp:Label>
                        </div>
                        <div style="display: table-cell; padding: 5px">
                            <asp:TextBox ID="txtPobCli" runat="server" Width="293px" ></asp:TextBox>
                        </div>
                    </div>

                   <div style="display: table-row">
                        <div style="display: table-cell; text-align: right; padding-right: 10px;">
                            <asp:Label ID="lblCpoCli" runat="server" Text="Código Postal"></asp:Label>
                        </div>
                        <div style="display: table-cell; padding: 5px">
                            <asp:TextBox ID="txtCpoCli" runat="server" Width="116px" ></asp:TextBox>
                        </div>
                    </div>

                   <div style="display: table-row">
                        <div style="display: table-cell; text-align: right; padding-right: 10px;">
                            <asp:Label ID="lblTelCli" runat="server" Text="Telefono"></asp:Label>
                        </div>
                        <div style="display: table-cell; padding: 5px">
                            <asp:TextBox ID="txtTelCli" runat="server" Width="203px" ></asp:TextBox>
                        </div>
                    </div>

                 <div style="display: table-row">
                     <div style="padding-left: 120%; margin-top: 7%;">
                            <asp:Button ID="btnInsertar" runat="server" Text="Insertar" OnClick="btnInsertar_Click" />                 
                    </div>
                 </div>
            </div>
        </div>

        <div style="text-align:center">
                <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Default.aspx">Ir al Inicio</asp:LinkButton>
        </div>

        <asp:Label ID="lblMensajes" ForeColor="Red" runat="server" style="text-align:center" Width="100%"></asp:Label>

 
         <div id="pie">
              <br />
              <br />

              © Desarrollo de Aplicaciones Web interactivas con Acceso a Datos
              <br />
              IES Mare Nostrum (Alicante)
         </div>
    </form>
</body>
</html>
