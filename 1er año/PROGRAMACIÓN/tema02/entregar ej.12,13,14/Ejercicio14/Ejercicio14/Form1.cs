using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
             
                double num1 = double.Parse(tCuadroTexto1.Text);
                double num2 = double.Parse(tCuadroTexto2.Text);

                bool resultado = num1 > num2;

                tCuadroTexto3.Text = resultado.ToString();
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

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                double num1 = double.Parse(tCuadroTexto1.Text);
                double num2 = double.Parse(tCuadroTexto2.Text);

                bool resultado = num1 < num2;

                tCuadroTexto3.Text = resultado.ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {

                double num1 = double.Parse(tCuadroTexto1.Text);
                double num2 = double.Parse(tCuadroTexto2.Text);

                bool resultado = num1 == num2;

                tCuadroTexto3.Text = resultado.ToString();
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

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                double num1 = double.Parse(tCuadroTexto1.Text);
                double num2 = double.Parse(tCuadroTexto2.Text);

                bool resultado = num1 != num2;

                tCuadroTexto3.Text = resultado.ToString();
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
