using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3Referencias
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void calcularDivResto(int num1, int num2, out int div, out int resto)
        {
            div = num1 / num2;
            resto = num1 % num2;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int division, resto;
            int num1 = int.Parse(txt1.Text);
            int num2 = int.Parse(txt2.Text);


            calcularDivResto(num1, num2, out division, out resto);

            MessageBox.Show("El resultado es " + division + " y el resto es " + resto);
        }
    }
}
