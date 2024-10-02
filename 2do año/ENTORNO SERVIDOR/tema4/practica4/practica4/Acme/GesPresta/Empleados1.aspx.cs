using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GesPresta
{
    public partial class Empleados1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            txtcodEmp.Focus();
        }

        protected void cmdEnviar_Click(object sender, EventArgs e)
        {
            lblvalores.Visible = true;
            lblvalores.Text = "VALORES DEL FORMULARIO" +
                "<br/> Código Empleado: " + txtcodEmp.Text +
                "<br/> NIF: " + txtNifEmp.Text +
                "<br/> Apellidos y Nombre: " + txtNomEmp.Text + 
                "<br/> Dirección: " + txtDirEmp.Text +
                "<br/> Ciudad: " + txtCiuEmp.Text +
                "<br/> Telefonos: " + txtTelEmp.Text +
                "<br/> Fecha de Nacimiento: " + txtFnaEmp.Text +
                "<br/> Fecha de Incorporación: " + txtFinEmp.Text +
                "<br/> Sexo: " + rblSexEmp.SelectedItem.Value +
                "<br/> Departamento: " + ddlDepEmp.Text;
        }
    }
}