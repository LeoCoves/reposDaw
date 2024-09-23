using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        const double RETENCION = 0.18;

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                double horas;
                double horasextras;
                double paga;
                double nominabruta;
                double nominaneta;

                horas = double.Parse(tCuadroTexto1.Text);
                horasextras = double.Parse(tCuadroTexto2.Text) * 2;
                paga = double.Parse(tCuadroTexto3.Text);

                nominabruta = (horas + horasextras) * paga;
                nominaneta = nominabruta - (nominabruta * RETENCION);

                tCuadroTexto4.Text = nominabruta.ToString();
                tCuadroTexto5.Text = nominaneta.ToString();
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
