using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio18
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            const int NUMERO = 50;
            int i = 2;
            int resultado = 0;

            while (i <= NUMERO)
            {
                resultado +=  i;
                i += 2;
            }
            MessageBox.Show("La suma es de: " + resultado.ToString());
        }
    }
}
