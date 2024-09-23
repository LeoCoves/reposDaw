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

namespace Ejercicio07
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int TAM = 5;
        int[] vector = new int[TAM];

        void readVector(int[] vector)
        {
            vector[0] = int.Parse(Interaction.InputBox("Introduce el primer numero"));
            int num;
            int i = 1;

           while (i < TAM)
            {
                num = int.Parse(Interaction.InputBox("Introduce un numero"));
                if(num > vector[i - 1])
                {
                    vector[i] = num;
                    i++;
                }
                else
                {
                    MessageBox.Show("Introduce un numero mayor al anterior");
                }
            }
        }

        string mostrarVector(int[] vector)
        {
            string texto = "La lista es : \n";
            for(int i = 0; i < TAM; i++)
            {
                texto += vector[i] + ", ";
            }
            return texto;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            readVector(vector);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mostrarVector(vector));
        }
    }
}
