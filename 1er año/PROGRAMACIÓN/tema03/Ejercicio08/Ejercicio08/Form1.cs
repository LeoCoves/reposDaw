using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = txt1.Text;
                string textolabel = lbl2.Text;
                string textoabajo = textolabel + texto + Environment.NewLine;

                lbl2.Text = textoabajo.ToString();
            }

            catch (FormatException fEx)
            {
                MessageBox.Show("Se ha producido este error:" + fEx.Message);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
