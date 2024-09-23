using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool comprobar(int num)
        {
            bool comprueba = false;

            if (num % 100 == 0 && num % 400 == 0 || num % 4 == 0 && num % 100 != 0)
            {
                comprueba = true;
            }

            return comprueba;
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            int año = int.Parse(txt1.Text);

            bool comprueba = comprobar(año);


            if (comprueba)
            {
                MessageBox.Show("Es bisiesto");
            }
            else
            {
                MessageBox.Show("No es bisiesto");
            }
        }
    }
}
