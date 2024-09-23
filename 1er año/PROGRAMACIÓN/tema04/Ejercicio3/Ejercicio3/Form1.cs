using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void intercambio(ref int n1, ref int n2)
        {
            int cambio = n1;
            n1 = n2 ;
            n2 = cambio; 

            
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int num1, num2;

            num1 = int.Parse(txt1.Text);
            num2 = int.Parse(txt2.Text);

            intercambio(ref num1, ref num2);

            MessageBox.Show("Num1: " + num1 +"\n" + "Num2: " + num2);
        }
    }
}
