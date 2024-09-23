using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio14bien
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnfor_Click(object sender, EventArgs e)
        {
            int numero = 10;
            int suma = 0;


            for (int i = 1; i <= numero; i++)
            {
                suma += i;
            }   
            
                MessageBox.Show("El valor es de: " + suma);
        }

        private void btnwhile_Click(object sender, EventArgs e)
        {
            int numero = 10;
            int suma = 0;
            int i = 1;

            while(i <= numero)
            {
                
                suma += i;
                i++;
            }
            MessageBox.Show("El valor es: " + suma);
        }
    }
}
