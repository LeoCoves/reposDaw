using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio01
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
            for(int i = 0; i < vector.Length; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce un numero: " + i));
            }
        }

        string mostrarVector(int[] vector)
        {
            string texto = "Elementos del vector \n";

            for (int i = 0; i < vector.Length; i++)
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
            string resultado = mostrarVector(vector);
            MessageBox.Show(resultado);
        }
    }
}
