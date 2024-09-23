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

namespace Ejercicio12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int TAM = 24;
        int[] vector = new int[TAM];

        void leerVector(int[] vector)
        {
            for(int i = 0; i < TAM; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce la temperatura de la " + (i + 1) + " hora"));
            }
        }

        void calcularTemp(int[] vector,out int maxima,out int minima,out int media)
        {
            maxima = vector[0];
            minima = maxima;
            media = 0;

            for(int i = 0; i < TAM; i++)
            {
                if (vector[i] > maxima)
                {
                    maxima = vector[i];
                }
                else if (vector[i] < minima)
                {
                    minima = vector[i];
                }
                media += vector[i];
            }

            media = media / TAM;
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            leerVector(vector);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int maxima, minima, media;
            calcularTemp(vector, out maxima, out minima, out media);

            MessageBox.Show("La temperatura maxima sera de " + maxima + " grados \n" +
                             "La temperatura minima sera de " + minima + " grados \n" +
                             "La temperatura media sera de " + media + " grados");
        }
    }
}
