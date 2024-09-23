using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const double VALOR = 166.386;

        private void boton1_Click(object sender, EventArgs e)
        {
            try
            {
                double euros;
                double conversion;

                euros = double.Parse(tCuadroTexto1.Text);

                conversion = euros * VALOR;

                MessageBox.Show(conversion.ToString());
            }

            catch (FormatException fEx) 
            {
                MessageBox.Show("Se ha producido el error:" + fEx.Message);
            }

            catch (DivideByZeroException oEx)
            {
                MessageBox.Show(oEx.Message);
            }
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            try
            {
                double pesetas;
                double conversion;

                pesetas = double.Parse(tCuadroTexto2.Text);

                conversion = pesetas / VALOR;

                MessageBox.Show(conversion.ToString());
            }

            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error:" + fEx.Message);
            }

            catch (DivideByZeroException oEx)
            {
                MessageBox.Show(oEx.Message);
            }
        }
    }
}
