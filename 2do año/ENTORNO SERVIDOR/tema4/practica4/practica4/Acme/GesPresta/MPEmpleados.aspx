<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="MPEmpleados.aspx.cs" Inherits="GesPresta.MPEmpleados" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
        <h2 class="titEmp">DATOS DE LOS EMPLEADOS</h2>

    <div class="cuerpo">
        <div class="linea">
            <div class="textos">
                <asp:Label ID="lblcodEmp" Text="text" runat="server">Codigo Empleado:</asp:Label> 
            </div>
            <div class="controles">
                <asp:TextBox ID="txtcodEmp" runat="server"></asp:TextBox>  <br />
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
                <asp:TextBox ID="txtTelEmp" runat="server" Width="380px"></asp:TextBox>  <br />
            </div>
        </div>

        <div class="linea">
            <div class="textos">
                <asp:Label ID="lblFnaEmp" Text="text" runat="server">Fecha de Nacimiento:</asp:Label> 
            </div>
            <div class="controles">
                <asp:TextBox ID="txtFnaEmp" runat="server"></asp:TextBox>  <br />
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
                <asp:RadioButtonList ID="rblSexEmp" runat="server" RepeatDirection="Horizontal">
                <asp:ListItem Value="H" Selected="True">Hombre</asp:ListItem>
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
                <asp:ListItem Value="Investigación" Selected="True">Investigación</asp:ListItem>
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
    </div>

    

</asp:Content>
