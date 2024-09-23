using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bMostrar_Click(object sender, EventArgs e)
        {
            int num1, num2;
            int suma;

            num1 = int.Parse(tCuadroTexto1.Text);
            num2 = int.Parse(tCuadroTexto2.Text);
            suma = num1 + num2;

            tCuadroTexto3.Text = (suma.ToString());




            
        }

        private void boton2_Click(object sender, EventArgs e)
        {
            int num1, num2;
            int resta;

            num1 = int.Parse(tCuadroTexto1.Text);
            num2 = int.Parse(tCuadroTexto2.Text);
            resta = num1 - num2;

            tCuadroTexto3.Text = (resta.ToString());
        }
    }
}
