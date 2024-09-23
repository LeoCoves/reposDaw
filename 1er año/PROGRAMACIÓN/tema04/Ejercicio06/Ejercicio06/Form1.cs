using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void calcularDivision (int num1, int num2, out int resultado, out int resto)
        {
            resultado = num1 / num2;
            resto = num1 % num2;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txt1.Text);
            int n2 = int.Parse(txt2.Text);
            int res, resto;

            if (n1 > n2)
            {
                calcularDivision(n1, n2, out res, out resto);
                MessageBox.Show("El resultado es " + res);
                MessageBox.Show("El resto es" + resto);
            }
        }
    }
}
