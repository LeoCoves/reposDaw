using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1, num2;

                num1 = double.Parse(tCuadroTexto1.Text);
                num2 = double.Parse(tCuadroTexto2.Text);

                if (num1 == num2)
                {
                    resultado.Text = $"{num1} es igual que {num2}";
                }

                else
                {
                    resultado.Text = $"{num1} NO es igual que {num2}";
                }
            }

            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido este error:" +fEx.Message);
            }
        }
    }
}
