using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace GesPresta
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string cadena = "";
            cadena += "Codigo: " + Request.Form["txtCodPre"] + "<br/>";
            cadena += "Descripción: " + Request.Form["txtDespre"] + "<br/>";
            cadena += "Importe: " + Request.Form["txtImpPre"] + "<br/>";
        }
    }
}