using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
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
        int factorial(int n1)
        {
          
            int totalFact = 1;

            for (int i = n1; i >= 1; i--)
            {
                
                totalFact *= i;
            }

            return totalFact;

        }

        int potencia(int n1, int n2)
        {
            int totalpotencia = n1;

            for (int i = 1; i < n2; i++)
            {
                totalpotencia *= n1;
            }

            return totalpotencia;
        }

        double serie(int m, int n)
        {
            double resultado = 0;

            for (int i = 1; i <= n; i++)
            {
                resultado += (double)potencia(m, i) / factorial(i);
            }
            
            return resultado;


        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int m = int.Parse(txt1.Text);
            int n = int.Parse(txt2.Text);

            double result;

            result = serie(m, n);

            MessageBox.Show(result.ToString());
        }
    }
}
