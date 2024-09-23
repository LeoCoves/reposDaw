using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio05
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
                double num1, num2, num3;

                num1 = double.Parse(txt1.Text);
                num2 = double.Parse(txt2.Text);
                num3 = double.Parse(txt3.Text);

                double grande = num1;

                if (num2 > grande)
                {
                    grande = num2;
                }

                if (num3 > grande)
                {
                    grande = num3;
                }

                MessageBox.Show($"El numero {grande} es el mayor");
            }

            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido el error:" + fEx.Message);
            }
        }
    }
}
