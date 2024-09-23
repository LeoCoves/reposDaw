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

        int mayor(int n1, int n2)
        {
            int nummayor = n2;
            if (n1 > n2)
            {
                nummayor = n1;
            }

            return nummayor;
        }

        private void btnMayor_Click(object sender, EventArgs e)
        {
            int num1, num2, nummayor;

            num1 = int.Parse(txt1.Text);
            num2 = int.Parse(txt2.Text);
            nummayor = mayor(num1, num2);

            MessageBox.Show("El numero mayor es " + nummayor);
        }
    }
}
