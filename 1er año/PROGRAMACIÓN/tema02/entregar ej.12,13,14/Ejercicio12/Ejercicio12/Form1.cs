using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        const double IVA = 0.21;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double prod1, prod2, prod3;
                double res;
                double resIVA;

                prod1 = double.Parse(tCuadroTexto1.Text);
                prod2 = double.Parse(tCuadroTexto2.Text);
                prod3 = double.Parse(tCuadroTexto3.Text);

                res = prod1 + prod2 + prod3;

                resIVA = res + (IVA * (prod1 + prod2 + prod3));

                tCuadroTexto4.Text = res.ToString();
                tCuadroTexto5.Text = resIVA.ToString();
            }

            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido un error:" + fEx.Message);
            }
        }
    }
}
