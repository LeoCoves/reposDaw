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

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                double num1;

                num1 = double.Parse(txt1.Text);

                if (num1 > 10 || num1 < 0)
                {
                    MessageBox.Show("La nota introducida es incorrecta");
                }

                if (num1 <= 1.9)
                {
                    MessageBox.Show("La nota es un deficiente");
                }

                else if (num1 <= 3.9)
                {
                    MessageBox.Show("La nota es un insufiente");
                }

                else if (num1 <= 4.9)
                {
                    MessageBox.Show("La nota es un sufiente");
                }

                else if (num1 <= 5.9)
                {
                    MessageBox.Show("La nota es un bien");
                }


                else if (num1 <= 7.9)
                {
                    MessageBox.Show("La nota es un notable");
                }

                else if (num1 > 8 && num1 <= 100)
                {
                    MessageBox.Show("La nota es un sobresaliente");
                }

               

            }

            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido este error:" + fEx.Message);
            }
        }
    }
}
