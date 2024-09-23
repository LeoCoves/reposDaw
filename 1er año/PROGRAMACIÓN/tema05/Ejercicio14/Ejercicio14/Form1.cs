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

namespace Ejercicio14
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
                vector[i] = int.Parse(Interaction.InputBox("Introduce la temperatura de la " + i + " hora"));
            }
        }

        double mediaVector(int[] vector)
        {
            double media = 0;

            for(int i = 0; i < TAM; i++)
            {
                media += vector[i];
            }
            media = media / TAM;
            return media;
        }

        string mostrarVector(int[] vector)
        {
            string texto = "Las temperaturas mayores o iguales a la media son: \n";

            for (int i = 0; i < TAM; i++)
            {
                if (vector[i] >= mediaVector(vector))
                {
                    texto += vector[i] + " grados a las " + i + " horas \n";
                }
            }
            return texto;
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            leerVector(vector);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            double media = mediaVector(vector);
            string texto = mostrarVector(vector);

            MessageBox.Show(texto);
        }
    }
}
