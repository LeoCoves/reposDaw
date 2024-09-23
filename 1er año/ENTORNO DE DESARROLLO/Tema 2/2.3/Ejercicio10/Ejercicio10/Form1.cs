using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {

            double valor, cantcentimos;
            int cantmonedas, cantbilletes;

                valor = double.Parse(txt1.Text);

                if (valor >= 500)
                {
                    cantbilletes = (int)valor / 500;
                    lblResultado.Text += ($"{cantbilletes} billetes de 500 euros" +"\n");
                    valor = valor % 500;
                }

                if (valor >= 200)
                {
                    cantbilletes = (int)valor / 200;
                    lblResultado.Text += ($"{cantbilletes} billetes de 200 euros" + "\n");
                    valor = valor % 200;
                }

                if (valor >= 100)
                {
                    cantbilletes = (int)valor / 100;
                    lblResultado.Text += ($"{cantbilletes} billetes de 100 euros" + "\n");
                    valor = valor % 100;
                }

                if (valor >= 50)
                {
                    cantbilletes = (int)valor / 50;
                    lblResultado.Text += ($"{cantbilletes} billetes de 50 euros" + "\n");
                    valor = valor % 50;
                }

                if (valor >= 10)
                {
                    cantbilletes = (int)valor / 10;
                    lblResultado.Text += ($"{cantbilletes} billetes de 10 euros" + "\n");
                    valor = valor % 10;
                }

                if (valor >= 5)
                {
                    cantbilletes = (int)valor / 5;
                    lblResultado.Text += ($"{cantbilletes} billetes de 5 euros" + "\n");
                    valor = valor % 5;
                }

                if (valor >= 2)
                {
                    cantmonedas = (int)valor / 2;
                    lblResultado.Text += ($"{cantmonedas} monedas de 2 euros" + "\n");
                    valor = valor % 2;
                }

                if (valor >= 1)
                {
                    cantmonedas = (int)valor / 1;
                    lblResultado.Text += ($"{cantmonedas} monedas de 1 euros" + "\n");
                    valor = valor % 1;
                }


                if (valor >= 0.50)
                {
                    cantcentimos = valor / 0.50;
                    lblResultado.Text += ($"{Math.Floor(cantcentimos)} monedas de 50 centimos" + "\n");
                    valor = valor % 0.50;
                }

                if (valor >= 0.20)
                {
                    cantcentimos = valor / 0.20;
                    lblResultado.Text += ($"{Math.Floor(cantcentimos)} monedas de 20 centimos" + "\n");
                    valor = valor % 0.20;
                }

                if (valor >= 0.10)
                {
                    cantcentimos = valor / 0.10;
                    lblResultado.Text += ($"{Math.Floor(cantcentimos)} monedas de 10 centimos" + "\n");
                    valor = valor % 0.10;
                }

                    if (valor >= 0.05)
                    {
                        cantcentimos = valor / 0.05;
                        lblResultado.Text += ($"{Math.Floor(cantcentimos)} monedas de 5 centimos" + "\n");
                        valor = valor % 0.05;
                    }

                    if (valor >= 0.02)
                    {
                        cantcentimos = valor / 0.02;
                        lblResultado.Text += ($"{Math.Floor(cantcentimos)} monedas de 2 centimos" + "\n");
                        valor = valor % 0.02;
                    }

                    if (valor >= 0.01)
                    {
                        cantcentimos = valor / 0.01;
                        lblResultado.Text += ($"{Math.Floor(cantcentimos)} monedas de 1 centimos" + "\n");
                        valor = valor % 0.01;
                    }
                

               

            

            
        }
    }
}
