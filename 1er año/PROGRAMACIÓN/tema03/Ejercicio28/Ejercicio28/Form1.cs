using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio28
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double num1 = double.Parse(txtNum1.Text);
            double num2 = double.Parse(txtNum2.Text);
            string texto = "";
            double resultado;

            if (num2 > 0 && num1 > 0)
            {


                for (double i = 0; i < num2; i++)
                {
                    texto += " + " + num1;
                }

                resultado = num1 * num2;

                MessageBox.Show(num1 + " * " + num2 + " = " + texto + " = " + resultado);
            }

            else if (num1 > 0 && num2 < 0)
            {
                for (double i = 0; i > num2; i--)
                {
                    texto += " (+" + num1 + ") -";
                }
                resultado = num1 * num2;

                MessageBox.Show(num1 + " * " + num2 + " = " + texto + " = " + resultado);
            }

            else if (num1 < 0 && num2 > 0)
            {
                for (double i = 0; i > num1; i--)
                {
                    texto += " (-" + num2 + ") +";
                }
                resultado = num1 * num2;

                MessageBox.Show(num1 + " * " + num2 + " = " + texto + " = " + resultado);
            }

           
            //num 2 debe ser menor que 0 (aqui num negativos)
            else
            {
                for (double i = 0; i > num2; i--)
                {
                    texto += " (" + num1 + ") -";
                }
                resultado = num1 * num2;

                MessageBox.Show(num1 + " * " + num2 + " = " + texto + " = " + resultado);
            }
        }
    }
}
