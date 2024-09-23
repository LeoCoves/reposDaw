using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void boton1_Click(object sender, EventArgs e)
        {
            try
            {

                int num1;
                int resmetros;
                int rescm;

                num1 = int.Parse(tCuadroTexto1.Text);

                resmetros = num1 / 100;
                rescm = num1 % 100;

                tCuadroTexto2.Text = ("El resultado es de " + resmetros.ToString() + " metros y " + rescm.ToString() + " cm");
            }

            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido un error:" + fEx.Message);
            }

            catch (DivideByZeroException  oEx)
            {
                MessageBox.Show(oEx.Message);
            }
        }   
    }
}
