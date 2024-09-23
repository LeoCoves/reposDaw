using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void boton_Click(object sender, EventArgs e)
        {
            int num1, num2;
            int resultado;
            int resto;

            try
            {

                num1 = int.Parse(CuadroTexto1.Text);
                num2 = int.Parse(CuadroTexto2.Text);

                resultado = num1 / num2;
                resto = num1 % num2;

                CuadroTexto3.Text = ("El resultado es " + resultado.ToString()+ " y el resto es " + resto.ToString());
            }
            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error:" + fEx.Message);
            }
        }
    }
}
