<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="EmpleadosCalendar.aspx.cs" Inherits="GesPresta.EmpleadosCalendar" %>


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

            <div class="tabla">
                <div class="fBirthday">
                    <div class="boxBirthday">
                        <asp:Label ID="lblFnaEmp" Text="text" runat="server">Fecha de Nacimiento:</asp:Label>
                        <asp:TextBox ID="txtFnaEmp" runat="server" AutoPostBack="True" OnTextChanged="txtFnaEmp_TextChanged"></asp:TextBox> <br />
                    </div>

                    <asp:Calendar ID="Calendar1" runat="server" OnSelectionChanged="Calendar1_SelectionChanged" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                        <NextPrevStyle VerticalAlign="Bottom" />
                        <OtherMonthDayStyle ForeColor="#808080" />
                        <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                        <SelectorStyle BackColor="#CCCCCC" />
                        <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                        <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <WeekendDayStyle BackColor="#FFFFCC" />
                    </asp:Calendar>
                </div>

                <div class="fIngreso">
                    <div class="boxIngreso">
                        <asp:Label ID="lblFinEmp" Text="text" runat="server">Fecha de Ingreso:</asp:Label>
                        <asp:TextBox ID="txtFinEmp" runat="server" AutoPostBack="True" OnTextChanged="txtFinEmp_TextChanged"></asp:TextBox> 
                    </div>

                    <asp:Calendar ID="Calendar2"  runat="server" OnSelectionChanged="Calendar2_SelectionChanged" BackColor="White" BorderColor="#999999" CellPadding="4" DayNameFormat="Shortest" Font-Names="Verdana" Font-Size="8pt" ForeColor="Black" Height="180px" Width="200px">
                        <DayHeaderStyle BackColor="#CCCCCC" Font-Bold="True" Font-Size="7pt" />
                        <NextPrevStyle VerticalAlign="Bottom" />
                        <OtherMonthDayStyle ForeColor="#808080" />
                        <SelectedDayStyle BackColor="#666666" Font-Bold="True" ForeColor="White" />
                        <SelectorStyle BackColor="#CCCCCC" />
                        <TitleStyle BackColor="#999999" BorderColor="Black" Font-Bold="True" />
                        <TodayDayStyle BackColor="#CCCCCC" ForeColor="Black" />
                        <WeekendDayStyle BackColor="#FFFFCC" />
                    </asp:Calendar>
                </div>
                <div class="boxAntigüedad">
                    <div class="antRow">
                        <asp:Label ID="lblAntigüedadCalendar" Text="Antiguedad" runat="server"></asp:Label>
                    </div>
                    <div class="antRow">
                        <asp:TextBox width="50px" ID="txtAños" runat="server"></asp:TextBox>
                        <asp:Label ID="lblAños" Text="Años" runat="server"></asp:Label>
                    </div>
                    <div class="antRow">
                        <asp:TextBox width="50px" ID="txtMeses" runat="server"></asp:TextBox>
                        <asp:Label ID="lblMeses" Text="Meses" runat="server"></asp:Label>
                    </div>
                    <div class="antRow">
                        <asp:TextBox width="50px" ID="txtDias" runat="server"></asp:TextBox>
                        <asp:Label ID="lblDias" Text="Dias" runat="server"></asp:Label>
                    </div>
                </div>
            </div>


            <div class="btn">
                <asp:Button ID="cmdEnviar" Text="Enviar" runat="server" OnClick="cmdEnviar_Click" />
                <p>
                    <asp:Label Visible="False" ID="lblError1" runat="server"></asp:Label>
                </p>
                <p>
                    <asp:Label Visible="False" ID="lblError2" runat="server"></asp:Label>
                </p>
                <p>
                    <asp:Label Visible="False" ID="lblError3" runat="server"></asp:Label>
                </p>
            </div>
        </div>

        

    </form>
</body>
</html>
