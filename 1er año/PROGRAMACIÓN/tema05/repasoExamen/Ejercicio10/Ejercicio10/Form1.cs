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

        const int TAM = 6;
        int[] vector1 = new int[TAM];
        int[] vector2 = new int[TAM];

        void leerVector(int[] vector)
        {
            for(int i = 0; i < TAM; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introducir nombres: "));
            }
        }

        void modificar(int[] vector1, int[] vector2)
        {
            int i = 1;
            vector2[0] = vector1[TAM - 1];

            while (i < TAM )
            {
                vector2[i] = vector1[i - 1];
                i++;
            }
        }

        string mostrarVector(int[] vector)
        {
            string texto = "La lista es: \n";
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
            modificar(vector1, vector2);
            MessageBox.Show(mostrarVector(vector2));
        }
    }
}
