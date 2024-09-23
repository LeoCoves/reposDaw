using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool calculo (int n1, int n2)
        {
            bool numero = false;

            if (n1 % n2 == 0)
            { 
                numero = true; 
            }

                return numero;

        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1, num2;
            bool numero;

            num1 = int.Parse(txt1.Text);
            num2 = int.Parse(txt2.Text);
            numero = calculo (num1, num2);

            if (numero == true)
            {
                MessageBox.Show("Es divisible");
            }

            else
            {
                MessageBox.Show("No es divisible");
            }
        }
    }
}
