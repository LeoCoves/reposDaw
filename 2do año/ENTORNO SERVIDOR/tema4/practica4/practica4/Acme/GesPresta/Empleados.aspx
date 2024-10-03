<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Empleados.aspx.cs" Inherits="GesPresta.Empleados" %>


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
                        <asp:TextBox ID="txtcodEmp" runat="server"></asp:TextBox> 
                        <asp:RequiredFieldValidator ID="rqdTxtCodEmp"  Text="*" ControlToValidate="txtcodEmp" runat="server" ErrorMessage="El Codigo Empleado es obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="regTxtCodEmp" Text="*" ControlToValidate="txtcodEmp" runat="server" ValidationExpression="\w\d{5}" ErrorMessage="El formato de los datos a introducir debe ser: 1 letra y 5 digitos" ForeColor="Green"></asp:RegularExpressionValidator>
                        <br />
                    </div>
                </div>

                <div class="linea">
                    <div class="textos">
                        <asp:Label ID="lblNifEmp" Text="text" runat="server">NIF:</asp:Label> 
                    </div>
                    <div class="controles">
                        <asp:TextBox ID="txtNifEmp" runat="server"></asp:TextBox> 
                        <asp:RequiredFieldValidator ID="rqdTxtNifEmp" Text="*" ControlToValidate="txtNifEmp" runat="server" ErrorMessage="El NIF es obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="regTxtNifEmp" Text="*" ControlToValidate="txtNifEmp" runat="server" ValidationExpression="\d{8}-\w" ErrorMessage="El formato de los datos a introducir debe ser: 8 digitos, guion y 1 letra" ForeColor="Green"></asp:RegularExpressionValidator>
                        <br />
                    </div>
                </div>

                <div class="linea">
                    <div class="textos">
                        <asp:Label ID="lblNomEmp" Text="text" runat="server">Apellidos y Nombre:</asp:Label> 
                    </div>
                    <div class="controles">
                        <asp:TextBox ID="txtNomEmp" runat="server" Width="493px"></asp:TextBox> 
                        <asp:RequiredFieldValidator ID="rqdTxtNomEmp" Text="*" ControlToValidate="txtNomEmp" runat="server" ErrorMessage="El Nombre y los Apellidos son obligatorios" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
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
                        <asp:TextBox ID="txtTelEmp" runat="server" Width="380px"></asp:TextBox> 
                        <asp:RequiredFieldValidator ID="rqdTxtTelEmp" Text="*" ControlToValidate="txtTelEmp" runat="server" ErrorMessage="El telefono es obligatorio" ForeColor="Red"></asp:RequiredFieldValidator>
                        <br />
                    </div>
                </div>

                <div class="linea">
                    <div class="textos">
                        <asp:Label ID="lblFnaEmp" Text="text" runat="server">Fecha de Nacimiento:</asp:Label> 
                    </div>
                    <div class="controles">
                        <asp:TextBox ID="txtFnaEmp" runat="server"></asp:TextBox> 
                        <asp:RequiredFieldValidator ID="rqdTxtFnaEmp" Text="*" ControlToValidate="txtFnaEmp" runat="server" ErrorMessage="La fecha de Nacimiento es obligatoria" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="cmpTxtFnaEmp" Text="*" ControlToValidate="txtFnaEmp" ControlToCompare="txtFinEmp" Type="Date" Operator="LessThan" runat="server" ErrorMessage="La fecha de Ingreso debe ser mayor que la de Nacimiento" ForeColor="Red"></asp:CompareValidator>
                        <asp:RegularExpressionValidator ID="regTxtFnaEmp" Text="*" ControlToValidate="txtFnaEmp" runat="server" ValidationExpression="\d\d\/\d\d\/\d\d\d\d" ErrorMessage="El formato de los datos debe ser: dd/mm/yyyy" ForeColor="Green"></asp:RegularExpressionValidator>
                        <br />
                    </div>
                </div>

                <div class="linea">
                    <div class="textos">
                        <asp:Label ID="lblFinEmp" Text="text" runat="server">Fecha de Ingreso:</asp:Label>
                    </div>
                    <div class="controles">
                        <asp:TextBox ID="txtFinEmp" runat="server"></asp:TextBox> 
                        <asp:RequiredFieldValidator ID="rqdTxtFinEmp" Text="*" ControlToValidate="txtFinEmp" runat="server" ErrorMessage="La fecha de Ingreso es obligatoria" ForeColor="Red"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="regTxtFinEmp" Text="*" ControlToValidate="txtFinEmp" runat="server" ValidationExpression="\d\d\/\d\d\/\d\d\d\d" ErrorMessage="El formato de los datos debe ser: dd/mm/yyyy" ForeColor="Green"></asp:RegularExpressionValidator>
                        <br />
                    </div>
                </div>

                <div class="linea">
                    <div class="textos">
                        <asp:Label ID="lblSexo" Text="text" runat="server">Sexo:</asp:Label> 
                    </div>
                    <div class="controles">
                        <asp:RadioButtonList ID="rblSexEmp" runat="server" RepeatDirection="Horizontal">
                        <asp:ListItem Value="H">Hombre</asp:ListItem>
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
                <asp:Button ID="cmdEnviar" Text="Enviar" runat="server" />
                <br />
                <asp:ValidationSummary ID="ValidationSummary1" DisplayMode="List" runat="server" ForeColor="Red"/>
            </div>

            
        </div>
        
    </form>
</body>
</html>
