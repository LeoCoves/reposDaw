using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txt1.Text);
            int i;

            if (numero >= 1)
            {

                for (i = 1; i <= numero; i++)
                {
                    MessageBox.Show("Valor: " + i);
                }

            }

            else
            {
                MessageBox.Show("Valores incorrectos");
            }
        }

        private void btnwhile_Click(object sender, EventArgs e)
        {

            int numero = int.Parse(txt1.Text);
            int i = 1;

            if (numero >= 1)
            {
                while(i <= numero)
                {
                    MessageBox.Show("Valor: " + i);
                    i++;

                }
            }

            else
            {
                MessageBox.Show("Valores incorrectos");
            }

        }

        private void btndowhile_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txt1.Text);
            int i = 1;

            if (numero >= 1)
            {
                do
                {
                    MessageBox.Show("Valor: " + i);
                    i++;

                } while (i <= numero);
            }

            else
            {
                MessageBox.Show("Valores incorrectos");
            }
        }
    }
}
