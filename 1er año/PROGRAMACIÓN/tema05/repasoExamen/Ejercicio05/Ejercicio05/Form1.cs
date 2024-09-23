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

namespace Ejercicio05
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
        int[] vector3 = new int[TAM];

        void leerVector(int[] vector)
        {
            for (int i = 0; i < TAM; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce numero"));
            }
        }

        void sumarVectores(int[] vector1, int[] vector2, int[] vector3)
        {
            for (int i = 0; i < TAM; i++)
            {
                vector3[i] = vector1[i] + vector2[i];
            }
        }

        string mostrarVector(int[] vector)
        {
            string texto = "Los numeros son \n";
            for (int i = 0; i < TAM; i++)
            {
                texto += vector[i] + ", ";
            }
            return texto;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            leerVector(vector1);
            MessageBox.Show("Ahora el segundo array");
            leerVector(vector2);
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            sumarVectores(vector1, vector2, vector3);
            MessageBox.Show(mostrarVector(vector3));
        }
    }
}
