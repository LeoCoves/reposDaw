using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio09
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
                double ressuma;

                num1 = double.Parse(tCuadroTexto1.Text);
                num2 = double.Parse(tCuadroTexto2.Text);

                ressuma = num1 + num2;

                tCuadroTexto3.Text = ressuma.ToString();
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
                double num1, num2;
                double resresta;

                num1 = double.Parse(tCuadroTexto1.Text);
                num2 = double.Parse(tCuadroTexto2.Text);

                resresta = num1 - num2;

                tCuadroTexto3.Text = resresta.ToString();
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

        private void boton3_Click(object sender, EventArgs e)
        {
            try
            {
                double num1, num2;
                double resproducto;

                num1 = double.Parse(tCuadroTexto1.Text);
                num2 = double.Parse(tCuadroTexto2.Text);

                resproducto = num1 * num2;

                tCuadroTexto3.Text = resproducto.ToString();
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

        private void boton4_Click(object sender, EventArgs e)
        {
            try
            {
                double num1, num2;
                double resdividir;

                num1 = double.Parse(tCuadroTexto1.Text);
                num2 = double.Parse(tCuadroTexto2.Text);

                resdividir = num1 / num2;

                tCuadroTexto3.Text = resdividir.ToString();
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

        private void boton5_Click(object sender, EventArgs e)
        {
            try
            {
                double num1, num2;
                double resporcentaje;

                num1 = double.Parse(tCuadroTexto1.Text);
                num2 = double.Parse(tCuadroTexto2.Text);

                resporcentaje = num1 % num2;

                tCuadroTexto3.Text = resporcentaje.ToString();
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
