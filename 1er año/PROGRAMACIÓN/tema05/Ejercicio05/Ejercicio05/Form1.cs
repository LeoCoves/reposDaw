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

        const int TAM = 3;
        int[] vector1 = new int[TAM];
        int[] vector2 = new int[TAM];
        int[] vector3 = new int[TAM];

        void leerVectores(int[] vectores)
        {
            for(int i = 0; i < TAM; i++)
            {
                vectores[i] = int.Parse(Interaction.InputBox("Introduce el numero" + i));
            }
        }

        void sumarVector(int[] vector1, int[] vector2, int[] suma)
        {
            for(int i = 0; i < TAM; i++)
            {
                suma[i] = vector1[i] + vector2[i];
            }       
        }

        string mostrarVector(int[] vector3)
        {
            string texto = "Los numeros sumados son: \n";

            for(int i = 0; i < TAM; i++)
            {
                texto += vector3[i] + ", ";
            }
            return texto;
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            leerVectores(vector1);
            leerVectores(vector2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            sumarVector(vector1, vector2, vector3);
            string texto = mostrarVector(vector3);
            MessageBox.Show(texto);
        }
    }
}
