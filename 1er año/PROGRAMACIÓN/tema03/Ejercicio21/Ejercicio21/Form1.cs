using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio21
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnFor_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNumero.Text);
            string texto = " ";

            if (num < 1 || num > 15)
            {
                MessageBox.Show("Incorrecto");

            }

            else
            {
                for (int i = 1; i <= num; i++)
                {
                    for (int j = 1; j <= 10; j++)
                    {
                        texto += j + ", ";

                    }

                    texto += "\n";
                }
                MessageBox.Show(texto);
            }
            

        }

        private void btnWhile_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNumero.Text);
            string texto = " ";
            int i = 1;
            int j = 1;

            if (num < 0 || num > 15)
            {
                MessageBox.Show("Incorrecto");

            }

            else
            {
                while (i <= num)
                {
                    i++;

                    while (j <= 10)
                    {
                        texto += j + ", ";
                        j++;
                    }
                    j = 1;
                    texto += "\n";
                    
                }

                MessageBox.Show(texto);
            }
        }
    }
}
