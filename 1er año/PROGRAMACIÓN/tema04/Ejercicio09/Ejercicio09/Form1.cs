using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int calcularPotencia(int n1, int n2)
        {
            int resultado = n1;

            for(int i = 1; i < n2; i++)
            {
                resultado *= n1;
            }

            return resultado;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num1, num2, result;

            num1 = int.Parse(txt1.Text);
            num2 = int.Parse(txt2.Text);

            result = calcularPotencia(num1, num2);

            MessageBox.Show(result.ToString());
        }
    }
}
