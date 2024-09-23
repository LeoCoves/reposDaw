using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjAmpliacion1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNumero.Text);
            int i;
            int j;
            string texto = "";

            for (i = 0; i <= num; i++)
            {
                texto += "\n";

                for (j = 1; j <= i; j++)
                {
                    texto +=  "* ";
                }

                
            }
            lblFigura1.Text = (texto);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            
            int num = int.Parse(txtNumero.Text);
            int i;
            int j;
            int k;
            string texto = "";

            for (i = 1; i <= num; i++)
            {
                texto += "\n";

                for (j = 1; j <= num - i; j++)
                {
                    texto += "  ";
                }


                for (k = 1; k <= i; k++)
                {
                    texto += " *";
                }


            }
            lblFigura2.Text = (texto);
        }
    }
}
