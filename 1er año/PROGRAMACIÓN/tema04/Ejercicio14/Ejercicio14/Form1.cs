using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void calcularBilletes (ref int pesetas, int valorBilletes, ref string res)
        {
            int cantbilletes;
           

            if (pesetas >= valorBilletes)
            {
                cantbilletes = pesetas / valorBilletes;

                pesetas = pesetas % valorBilletes;


                if (pesetas > 100)
                {

                    res += cantbilletes + " billetes de " + valorBilletes + "\n";

                }

                else
                {
                    
                    res += cantbilletes + " monedas de " + valorBilletes + "\n"; 

                }
            }

            
        }

        

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int pesetas = int.Parse(txtPesetas.Text);
            string res = "";

            
          calcularBilletes(ref pesetas, 10000, ref res);
          calcularBilletes(ref pesetas, 5000, ref res);
          calcularBilletes(ref pesetas, 2000, ref res);
          calcularBilletes(ref pesetas, 1000, ref res);
          calcularBilletes(ref pesetas, 100, ref res);
          calcularBilletes(ref pesetas, 25, ref res);

            MessageBox.Show(res);

            
        }
    }
}
