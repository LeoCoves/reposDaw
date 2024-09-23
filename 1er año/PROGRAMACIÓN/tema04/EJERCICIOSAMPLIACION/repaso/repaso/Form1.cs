using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace repaso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool esPrimo(int num)
        {
            bool encontrado = true;

            for(int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    encontrado = false;
                }
            
            }

            return encontrado;
        }

        void divParesInpares(int n1, out string pares, out string inpares)
        {
            pares = "";
            inpares = "";

            for (int i = 1; i <= n1; i++)
            {
                if (n1 % i == 0)
                {
                    if (i % 2 == 0)
                    {
                        pares += i + ", ";
                    }
                    else
                    {
                        inpares += i + ", ";
                    }
                }
            }
        }

       


        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txtNum.Text);

            divParesInpares(num, out string pares, out string inpares);

            MessageBox.Show("Pares: " + pares + "\n" +
                            "Inpares: " + inpares);

        }
    }
}
