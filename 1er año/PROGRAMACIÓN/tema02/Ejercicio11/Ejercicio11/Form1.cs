using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double INTERES = 0.05;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double capital;
                double resultado;

                capital = double.Parse(tCuadroTexto1.Text);

                resultado = capital + (capital * INTERES);

                tCuadroTexto2.Text = resultado.ToString();
            }

            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido un error:" +  fEx.Message);
            }

            catch (DivideByZeroException oEx)
            {
                MessageBox.Show(oEx.Message);
            }
        }
    }
}
