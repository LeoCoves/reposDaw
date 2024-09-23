using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int comunDivisor(int num1, int num2)
        {
            

            while (num2 != 0)
            {
                int a = num2;
                num2 = num1 % num2;
                num1 = a;

            }

            return num1;


        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txt1.Text);
            int n2 = int.Parse(txt2.Text);
            

            int valor = comunDivisor(n1, n2);

            MessageBox.Show("El maximo comun divisor es " + valor);

            
        }
    }
}
