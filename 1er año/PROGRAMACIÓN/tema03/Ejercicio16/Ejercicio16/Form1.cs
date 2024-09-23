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

namespace Ejercicio16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num = int.Parse(Interaction.InputBox("Escriba los numeros que desea sumar"));
            int suma = 0;

            while (num >= 0 && num <= 9)
            {

                 suma += num;
                
                 num = int.Parse(Interaction.InputBox("Escriba los numeros que desea sumar"));
            }

            MessageBox.Show("La suma es " + suma);
        }
    }
}
