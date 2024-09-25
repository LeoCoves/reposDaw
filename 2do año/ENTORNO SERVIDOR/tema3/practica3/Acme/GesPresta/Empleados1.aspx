<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empleados1.aspx.cs" Inherits="GesPresta.Empleados1" %>


<%@ Register src="Cabecera.ascx" tagname="Cabecera" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <link rel="stylesheet" href="HojaEstilos.css"/>
    <title>Empleados</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <uc1:Cabecera ID="Cabecera1" runat="server" />
            <h2 class="titEmp">DATOS DE LOS EMPLEADOS</h2>

            <div class="cuerpo">
                <div class="linea">
                    <div class="textos">
                        <asp:Label ID="lblcodEmp" Text="text" runat="server">Codigo Empleado:</asp:Label> 
                    </div>
                    <div class="controles">
                        <asp:TextBox ID="txtcodEmp" runat="server"></asp:TextBox> <br />
                    </div>
                </div>

                <div class="linea">
                    <div class="textos">
                        <asp:Label ID="lblNifEmp" Text="text" runat="server">NIF:</asp:Label> 
                    </div>
                    <div class="controles">
                        <asp:TextBox ID="txtNifEmp" runat="server"></asp:TextBox> <br />
                    </div>
                </div>

                <div class="linea">
                    <div class="textos">
                        <asp:Label ID="lblNomEmp" Text="text" runat="server">Apellidos y Nombre:</asp:Label> 
                    </div>
                    <div class="controles">
                        <asp:TextBox ID="txtNomEmp" runat="server" Width="493px"></asp:TextBox> <br />
                    </div>
                </div>

                <div class="linea">
                    <div class="textos">
                        <asp:Label ID="lblDirEmp" Text="text" runat="server">Dirección:</asp:Label> 
                    </div>
                    <div class="controles">
                        <asp:TextBox ID="txtDirEmp" runat="server" Width="515px"></asp:TextBox> <br />
                    </div>
                </div>

                <div class="linea">
                    <div class="textos">
                        <asp:Label ID="lblCiuEmp" Text="text" runat="server">Ciudad:</asp:Label> 
                    </div>
                    <div class="controles">
                        <asp:TextBox ID="txtCiuEmp" runat="server" Width="512px"></asp:TextBox> <br />
                    </div>
                </div>

                <div class="linea">
                    <div class="textos">
                        <asp:Label ID="lblTelEmp" Text="text" runat="server">Telefonos:</asp:Label> 
                    </div>
                    <div class="controles">
                        <asp:TextBox ID="txtTelEmp" runat="server" Width="380px"></asp:TextBox> <br />
                    </div>
                </div>

                <div class="linea">
                    <div class="textos">
                        <asp:Label ID="lblFnaEmp" Text="text" runat="server">Fecha de Nacimiento:</asp:Label> 
                    </div>
                    <div class="controles">
                        <asp:TextBox ID="txtFnaEmp" runat="server"></asp:TextBox> <br />
                    </div>
                </div>

                <div class="linea">
                    <div class="textos">
                        <asp:Label ID="lblFinEmp" Text="text" runat="server">Fecha de Ingreso:</asp:Label>
                    </div>
                    <div class="controles">
                        <asp:TextBox ID="txtFinEmp" runat="server"></asp:TextBox> <br />
                    </div>
                </div>

                <div class="linea">
                    <div class="textos">
                        <asp:Label ID="lblSexo" Text="text" runat="server">Sexo:</asp:Label> 
                    </div>
                    <div class="controles">
                        <asp:RadioButtonList  ID="rblSexEmp" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Selected="True" Value="H">Hombre</asp:ListItem>
                        <asp:ListItem Value="M">Mujer</asp:ListItem>
                        </asp:RadioButtonList>
                        <br />
                    </div>
                </div>

                <div class="linea">
                    <div class="textos">
                        <asp:Label ID="lblDepEmp" Text="text" runat="server">Departamento:</asp:Label> 
                    </div>
                    <div class="controles">
                        <asp:DropDownList ID="ddlDepEmp" runat="server">
                        <asp:ListItem Value="Investigación">Investigación</asp:ListItem>
                        <asp:ListItem Value="Desarrollo">Desarrollo</asp:ListItem>
                        <asp:ListItem Value="Innovación">Innovación</asp:ListItem>
                        <asp:ListItem Value="Administración">Administración</asp:ListItem>
                        </asp:DropDownList>
                        <br />
                    </div>
                </div>
            </div>

            <div class="btn">
                <asp:Button ID="cmdEnviar" Text="Enviar" runat="server" OnClick="cmdEnviar_Click" />
            </div>
        </div>

        <div class="valores">
            <asp:Label Visible="False" ID="lblvalores" runat="server" Text="Label"></asp:Label>
        </div>
            

    </form>
</body>
</html>
