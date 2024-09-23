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

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                int valor, cantbilletes, cantmonedas;

                valor = int.Parse(txt1.Text);



                if (valor >= 10000) 
                {
                    cantbilletes = valor / 10000;
                    lbl2.Text += ($"{cantbilletes} billetes de 10000" + "\n");
                    valor = valor % 10000;
                }

                if (valor >= 5000)
                {
                    cantbilletes = valor / 5000;
                    lbl2.Text += ($"{cantbilletes} billetes de 5000" + "\n");
                    valor = valor % 5000;
                }

                if (valor >= 2000)
                {
                    cantbilletes = valor / 2000;
                    lbl2.Text += ($"{cantbilletes} billetes de 2000" + "\n");
                    valor = valor % 2000;
                }

                if (valor >= 1000)
                {
                    cantbilletes = valor / 1000;
                    lbl2.Text += ($"{cantbilletes} billetes de 1000" + "\n");
                    valor = valor % 1000;
                }

                if (valor >= 100)
                {
                    cantmonedas = valor / 100;
                    lbl2.Text += ($"{cantmonedas} monedas de 100" + "\n");
                    valor = valor % 100;
                }

                if (valor >= 25)
                {
                    cantmonedas = valor / 25;
                    lbl2.Text += ($"{cantmonedas} monedas de 25" + "\n");
                    valor = valor % 25;
                }

                else
                {
                    MessageBox.Show("Introduce un numero superior a 25");
                }





            }

            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido este error:" +fEx.Message);
            }
        }
    }
}
