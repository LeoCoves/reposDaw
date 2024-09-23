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

namespace Ejercicio09
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int TAM = 6;
        int[] vector1 = new int[TAM];
        int[] vector2 = new int[TAM];

        void leerVector(int[] vector)
        {
            for(int i = 0; i < vector.Length; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce el numero " + i));
            }
        }

        void cambiarOrden(int[] v1, int[] v2)
        {
            int j = TAM - 1;

            for (int i = 0; i < TAM; i++)
            {
                v2[j] = v1[i];
                j--;
            }
        }

        string mostrarVector(int[] v2)
        {
            string texto = "Los numeros al reves serian \n";

            for (int i = 0; i < TAM; i++)
            {
                texto += v2[i] + ", ";
            }
            return texto;
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            leerVector(vector1);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            cambiarOrden(vector1, vector2);
            string texto = mostrarVector(vector2);
            MessageBox.Show(texto);
        }
    }
}
