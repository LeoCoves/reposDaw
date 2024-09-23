using Microsoft.VisualBasic;
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

namespace Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int TAM = 4;
        int[] vector1 = new int[TAM];
        int[] vector2 = new int[TAM];

        void leerVector(int[] vector)
        {
            for(int i = 0; i < TAM; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce el numero" + i));
            }
        }

        void cambiarPosicion(int[] v1, int[] v2)
        {
            v2[0] = v1[TAM-1];

            for(int i = 0; i < TAM - 1; i++)
            {
                v2[i + 1] = v1[i];
            }
        }

        string mostrarVector(int[] vector)
        {
            string texto = "Los numeros son: \n";

            for(int i = 0; i < TAM; i++)
            {
                texto += vector[i] + ", ";
            }
            return texto;
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            leerVector(vector1);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            cambiarPosicion(vector1, vector2);
            string texto = mostrarVector(vector2);
            MessageBox.Show(texto);
        }
    }
}
