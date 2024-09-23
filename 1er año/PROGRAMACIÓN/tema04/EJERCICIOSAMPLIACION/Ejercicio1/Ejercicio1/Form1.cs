using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string primos(int num)
        {

            string res = "";
            
                for (int i = 2; i <= num; i++)
                {
                    if (i % 2 != 0)
                    {
                        res += i + ", "; 
                    }
                    
                }
           

            return res;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNum.Text);

            string resultado = primos(num);

            if (num > 0)
            {
                MessageBox.Show("Los primos son: " + resultado);
            }

            else
            {
                MessageBox.Show("Introduce un numero mayor a 0");
            }

        }
    }
}
