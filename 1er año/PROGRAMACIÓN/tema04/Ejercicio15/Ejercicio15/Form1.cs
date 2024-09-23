using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void calcularBilletes(ref double euros, int valorBilletes, string tipo, ref string res)
        {

            if (euros >= valorBilletes)
            {
                int cantbilletes =  (int)(euros / valorBilletes);

                euros = euros % valorBilletes;

                res += cantbilletes + " " + tipo + " de " + valorBilletes + "\n";  
                            
            }
        }

        void calcularCentimos(ref int centimos, int valorBilletes, string tipo, ref string res)
        {

            if (centimos >= valorBilletes)
            {
                int cantbilletes = centimos / valorBilletes;

                centimos = centimos % valorBilletes;

                res += cantbilletes + " " + tipo + " de " + valorBilletes + "\n";

            }
        }



        //5.57 = 5.57*100 - (int)euros*100)=57
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double euros = double.Parse(txt1.Text);
            int centimos = (int)(euros * 100 - (int)euros * 100);
            string res = "";

            MessageBox.Show(centimos.ToString());

            calcularBilletes(ref euros, 500, "billetes", ref res);
            calcularBilletes(ref euros, 200, "billetes", ref res);
            calcularBilletes(ref euros, 100, "billetes", ref res);
            calcularBilletes(ref euros, 50, "billetes", ref res);
            calcularBilletes(ref euros, 20, "billetes", ref res);
            calcularBilletes(ref euros, 10, "billetes", ref res);
            calcularBilletes(ref euros, 5, "billetes", ref res);
            calcularBilletes(ref euros, 2, "monedas", ref res);
            calcularBilletes(ref euros, 1, "monedas", ref res);
            
            // Calcular centimos

            calcularCentimos(ref centimos, 50, "centimos", ref res);
            calcularCentimos(ref centimos, 20, "centimos", ref res);
            calcularCentimos(ref centimos, 10, "centimos", ref res);
            calcularCentimos(ref centimos, 5, "centimos", ref res);
            calcularCentimos(ref centimos, 2, "centimos", ref res);
            calcularCentimos(ref centimos, 1, "centimos", ref res);

            lblResultado.Text = (res);
        }
    }
}
