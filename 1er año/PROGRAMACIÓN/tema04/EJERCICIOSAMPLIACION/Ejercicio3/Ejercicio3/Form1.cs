using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

        int menor(int n1, int n2, int n3)
        {
            int menor = n1;

            if (n2 < n1)
            {
                menor = n2;
            }
            else if(n3 < n2)
            {
                menor = n3;
            }
            else
            {
                menor = n1;
            }
            return menor;
        }

        int comunDivisor(int n1, int n2, int n3)
        {
            int mcd = menor(n1, n2, n3);
            bool encontrado = false;

            for (int i = mcd; i>=1 && !encontrado; i++)
            {
                if(n1 % i == 0 && n2 % i == 0 && n3 % i == 0)
                {
                    mcd = i;
                    encontrado = true;
                }
            }

            return mcd; 
        }

       

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int n1 = int.Parse(txtNum1.Text);
            int n2 = int.Parse(txtNum2.Text);
            int n3 = int.Parse(txtNum3.Text);


            int numMenor = menor(n1, n2, n3);
            int mcd = comunDivisor(n1, n2, n3);

            MessageBox.Show("El numero menor es " + numMenor + " y su MCD es " + mcd);

        }
    }
}
