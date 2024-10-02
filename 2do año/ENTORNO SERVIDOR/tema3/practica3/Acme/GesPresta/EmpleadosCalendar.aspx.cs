using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GesPresta
{
    public partial class EmpleadosCalendar : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblError1.Visible = false;
            lblError2.Visible = false;
            lblError3.Visible = false;
        }

        protected void cmdEnviar_Click(object sender, EventArgs e)
        {
            
        }

        private bool validarFecha(string fecha)
        {
            bool validar = false;
            string date = Convert.ToString(fecha);
            string formato = "dd/MM/yyyy";

            if (DateTime.TryParseExact(fecha, formato, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime fechaValida))
            {
                validar = true;
            }

            return validar;
        }

        private void calcularAntiguedad(DateTime calendar2, DateTime dateHoy)
        {
            TimeSpan diferencia = dateHoy - calendar2;
            DateTime fechamin = new DateTime(1, 1, 1);
            
                txtAños.Text = ((fechamin + diferencia).Year - 1).ToString();
                txtMeses.Text = ((fechamin + diferencia).Month - 1).ToString();
                txtDias.Text = ((fechamin + diferencia).Day).ToString();


        }
        private void checkDates(DateTime calendar1, DateTime calendar2, DateTime dateHoy)
        {
            calendar1 = Calendar1.SelectedDate;
            calendar2 = Calendar2.SelectedDate;
            dateHoy = System.DateTime.Now;
            bool error = false;
            string cadena = "";
            
            if (calendar2 != DateTime.MinValue)
            {
                if (calendar2 < calendar1)
                {
                    lblError1.Text = "La fecha de ingreso no puede ser menor a la fecha de nacimiento del empleado";
                    lblError1.Visible = true;
                    error = true;
                }
            }
            if (calendar2 > dateHoy)
            {
                lblError2.Text = "La fecha de ingreso no puede ser mayor a la fecha actual";
                lblError2.Visible = true;
                error = true;
            }
            if (calendar1 > dateHoy)
            {
                lblError3.Text = "La fecha de nacimiento no puede ser mayor a la fecha actual";
                lblError3.Visible = true;
                error=true;
            }
            if (!error)
            {
                if(calendar2 != DateTime.MinValue)
                {
                    calcularAntiguedad(calendar2, dateHoy);
                }
                lblError1.Visible = false;
                lblError2.Visible = false;
                lblError3.Visible = false;
            }
            else
            {
                txtAños.Text = String.Empty;
                txtMeses.Text = String.Empty;
                txtDias.Text = String.Empty;
            }
        }

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            DateTime calendar1 = Calendar1.SelectedDate;
            DateTime calendar2 = Calendar2.SelectedDate;
            DateTime dateHoy = System.DateTime.Now;
            txtFnaEmp.Text = calendar1.ToShortDateString();
            checkDates(calendar1, calendar2, dateHoy);
        }

        protected void Calendar2_SelectionChanged(object sender, EventArgs e)
        {
            DateTime calendar1 = Calendar1.SelectedDate;
            DateTime calendar2 = Calendar2.SelectedDate;
            DateTime dateHoy = System.DateTime.Now;
            txtFinEmp.Text = calendar2.ToShortDateString();
            checkDates(calendar1, calendar2, dateHoy);

        }

        string formatDate = "dd/MM/yyyy";
        DateTime dateHoy = DateTime.Now;

        protected void txtFnaEmp_TextChanged(object sender, EventArgs e)
        {
            DateTime date;

            if (DateTime.TryParseExact(txtFnaEmp.Text, formatDate, null, DateTimeStyles.None, out date))
            {
                Calendar1.SelectedDate = Convert.ToDateTime(txtFnaEmp.Text);
                Calendar1.VisibleDate = Convert.ToDateTime(txtFnaEmp.Text);
                DateTime calendar1 = Calendar1.SelectedDate;
                DateTime calendar2 = Calendar2.SelectedDate;
                checkDates(calendar1, calendar2, dateHoy);
            }
        }

        protected void txtFinEmp_TextChanged(object sender, EventArgs e)
        {
            DateTime date;

            if (DateTime.TryParseExact(txtFinEmp.Text, formatDate, null, DateTimeStyles.None, out date))
            {
                Calendar2.SelectedDate = Convert.ToDateTime(txtFinEmp.Text);
                Calendar2.VisibleDate = Convert.ToDateTime(txtFinEmp.Text);
                DateTime calendar1 = Calendar1.SelectedDate;
                DateTime calendar2 = Calendar2.SelectedDate;
                checkDates(calendar1, calendar2, dateHoy);
            }
        }
    }
}