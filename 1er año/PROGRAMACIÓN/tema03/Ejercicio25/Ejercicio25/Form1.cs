using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTabla_Click(object sender, EventArgs e)
        {
            int i;
            int j;
            string texto = "";
            int resultado;

            for (i = 1; i <= 10; i++)
            {
                
                for (j = 1; j <= 10; j++)
                {
                    resultado = i * j;
                    texto += i + " * " + j + " = " + resultado + "\n";
                }
                MessageBox.Show(texto);

                texto = "";
                
                j = 1;
            }
        }
    }
}
