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

namespace Ejercicio15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMayorMenor_Click(object sender, EventArgs e)
        {
            int num, mayor, menor;

            num = int.Parse(Interaction.InputBox("Introduce un numero, Ejercicio15"));
            mayor = num;
            menor = num;

            while(num > 0)
            {
                if (num > mayor)
                    mayor = num;

                if (num < menor)
                    menor = num;
                
                //Calcular mayor y menor
                num = int.Parse(Interaction.InputBox("Introduce un numero, Ejercicio15"));
            }
            MessageBox.Show("El mayor es " + mayor + "y el menor es " + menor);
        }

    }
}
