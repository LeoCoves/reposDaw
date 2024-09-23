using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double factorial = 1;
            int numero = int.Parse(txt1.Text);
            int i;
           
            for(i = 2; i <= numero; i++)
            {
                factorial *= i;

            }
            MessageBox.Show(factorial.ToString());
        }
    }
}
