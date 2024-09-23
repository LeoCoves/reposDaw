using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio24
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNumero.Text);
            int i;
            string texto = "";
            int resultado;


            if (num < 0 || num > 100)
            {
                MessageBox.Show("Inserte un numero valido");
            }
            else
            {
                for (i = 1; i <= 9; i++)
                {
                    resultado = num * i;
                    texto += num + " * " + i + " = " + resultado + "\n";
                    
                }

                MessageBox.Show(texto);

            }
        }
    }
}
