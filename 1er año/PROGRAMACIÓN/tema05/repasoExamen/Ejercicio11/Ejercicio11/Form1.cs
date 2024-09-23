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

namespace Ejercicio11
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int TAM = 6;
        int[] vector = new int[TAM];

        void leerVector(int[] vector)
        {
            for (int i = 0; i < TAM; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introducir nombres: "));
            }
        }

        void modificar(int[] vector)
        {
            int i = 1;
            int aux = vector[0];
            vector[0] = vector[TAM - i];

            for(i = 1; i < TAM; i++) 
            {
                vector[i] = aux;
                aux = vector[i];
            }
        }

        string mostrarVector(int[] vector)
        {
            string texto = "La lista es: \n";
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
            modificar(vector);
            MessageBox.Show(mostrarVector(vector));
        }
    }
}
