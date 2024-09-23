using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio22
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int numero = int.Parse(txt1.Text);
            int i;

            if (numero >= 14681 && numero <= 15681 || numero >= 70001 && numero <= 79999 || numero >= 88888 && numero <= 111111)
            {
                MessageBox.Show("PRODUCTO DEFECTUOSO");
            }

            else
            {
                MessageBox.Show("PRODUCTO NO DEFECTUOSO");
            }
        }
    }
}
