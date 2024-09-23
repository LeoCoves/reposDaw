using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        double valorAbsoluto(double n1)
        {
            double resultado = n1;

            if (n1 < 0)
            {
                resultado *= -1;
            }

            return resultado;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1, result;

            num1 = double.Parse(txt1.Text);

            result = valorAbsoluto(num1);

            MessageBox.Show(result.ToString());

        }
    }
}
