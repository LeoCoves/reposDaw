using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio27
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNumero.Text);
            bool encontrado = false;
            int i;

            for (i = 2; i < num && encontrado == false; i++)
            {

                if (num > 1)
                {
                    

                    if (num % i == 0)
                    {
                        encontrado = true;
                    }

                    if (!encontrado)
                    {
                        MessageBox.Show("PRIMO");
                    }

                    else
                    {
                        MessageBox.Show("NO PRIMO");
                    }

                }

                else
                {
                    MessageBox.Show("Ningun numero menor e igual a 1 es primo");
                }
            }

        }
    }
}
