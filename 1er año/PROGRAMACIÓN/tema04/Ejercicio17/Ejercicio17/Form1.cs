using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio17
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int division(int num1, int num2)
        {
            int i = 0;
            

            while(num1  >= num2)
            {
                num1 = num1 - num2;
                i++;
            }

            return i;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtnum1.Text);
            int n2 = int.Parse(txtnum2.Text);
            int resultado;

            resultado = division(n1, n2);

            MessageBox.Show(resultado.ToString());
        }
    }
}
