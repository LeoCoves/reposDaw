using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace EjAmpliacion2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int num1 = int.Parse(txtNum1.Text);
            int num2 = int.Parse(txtNum2.Text);

            bool encontrado = false;
            string primos = "";

            if (num1 < num2)
            {
               

                for (int i = num1; i <= num2 && encontrado == false; i++ )
                {

                    if (i % 2  == 0)
                    {
                        encontrado = true;
                    } 
                    if (!encontrado)
                    {
                        primos += i + ", ";
                    }
                    else
                    {
                        encontrado = false;
                    }
                    
                }
                MessageBox.Show("Los números primos comprendidos entre " + num1 + " y " + num2 + " son: " + primos);
            }

            else
            {
                MessageBox.Show("Error");
            }
        }
    }
}
