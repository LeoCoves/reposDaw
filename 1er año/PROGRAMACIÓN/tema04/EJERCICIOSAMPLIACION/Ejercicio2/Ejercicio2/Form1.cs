using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int comunMultiplo(int num1, int num2)
        {
            int mcm = 0;
            bool encontrado = false;

            for (int i = 1; !encontrado; i++)
            {
                if((num1 * i) % num2 == 0)
                {
                    mcm = num1 * i;
                    encontrado = true;
                }
            }

            return mcm;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);

            int valor = comunMultiplo(num1, num2);

            MessageBox.Show("El minimo comun multiplo es: " + valor);
        }
    }
}
