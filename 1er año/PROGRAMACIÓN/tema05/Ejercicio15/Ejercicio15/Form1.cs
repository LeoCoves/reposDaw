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

namespace Ejercicio15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int TAM = 10;
        int[] vector = new int[TAM];

        void leerVector(int[] vector)
        {
            for (int i = 0; i < TAM; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce el numero " + i));
            }
        }

        int numMay(int[] vector)
        {
            int mayor = vector[0];

            for (int i = 1; i < TAM; i++)
            {
                if (vector[i] > mayor)
                {
                    mayor = vector[i];
                }
            }
            return mayor;
        }
        
        int numMen(int[] vector)
        {
            int menor = vector[0];

            for (int i = 1; i < TAM; i++)
            {
                if (vector[i] < menor)
                {
                    menor = vector[i];
                }
            }
            return menor;
        }

        int numRepetidos(int[] vector, int num)
        {
            int repetidos = 0;

            for (int i = 0; i < TAM; i++)
            {
                if(num == vector[i])
                {
                    repetidos++;
                }
            }
            return repetidos - 1;
        }

        string mostrarVector(int[] vector)
        {
            string texto = "";

            for (int i = 0; i < TAM; i++)
            {
                texto += vector[i] + ", ";
            }
            return texto;
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            leerVector(vector);   
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int numMayor = numMay(vector);
            int numMenor = numMen(vector);
            int numRepMayor = numRepetidos(vector, numMayor);
            int numRepMenor = numRepetidos(vector, numMenor);
            string texto = mostrarVector(vector);

            MessageBox.Show(texto + "\n" + "El mayor es " + numMayor + " y el menor es " + numMenor +
                                    "\n Los numeros repetidos mayores son " + numRepMayor + 
                                    "\n Los numeros repetidos menores son " + numRepMenor);
        }
    }
}

