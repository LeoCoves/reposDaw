using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace repaso2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void comprobar(double numeros, out int i, out int j)
        {
            i = 0;
            j = 0;

            while (numeros != 0)
            {
                numeros = double.Parse(Interaction.InputBox("Introduce un numero que no sea el 0"));

                if (numeros > 0)
                {
                    i++;
                }
                else
                {
                    j++;
                }
            }

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double numeros = double.Parse(Interaction.InputBox("Introduce un numero que no sea el 0"));

            comprobar(numeros, out int i, out int j);

            MessageBox.Show("Los positivos son: " + i + "\n" +
                            "Los negativos son: " + j + "\n");
        }
    }
}
