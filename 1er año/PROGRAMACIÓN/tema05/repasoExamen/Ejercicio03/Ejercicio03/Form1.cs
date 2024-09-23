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

namespace Ejercicio03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int TAM = 10;
        int[] vector = new int[TAM];

        void readVector(int[] vector)
        {
            for(int i = 0; i < TAM; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce numeros"));
            }
        }

        int menorVector(int[] vector)
        {
            int numMenor = vector[0];

            for(int i = 1; i < TAM; i++)
            {
                if (vector[i] < numMenor)
                {
                    numMenor = vector[i];
                }
            }
            return numMenor;
        }

        string mostrarVector(int[] vector)
        {
            string texto = "El vector es: \n";
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
            string texto = mostrarVector(vector);
            int menor = menorVector(vector);
            MessageBox.Show(texto + "\n" + "El numero menor es " + menor);
        }
    }
}
