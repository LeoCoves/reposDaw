using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio16
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string calcularFactorial(int n1)
        {
            string resultado = n1 + " = ";
            int total = 1;

            for(int i = n1; i >= 1; i--)
            {
                resultado += "*" + i  ;
                total *= i; 
            }

            resultado += " = " + total;

            return resultado;

        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1;
            num1 = int.Parse(txt1.Text);
            string result;

            result = calcularFactorial(num1);

            MessageBox.Show(result);

        }
    }
}
