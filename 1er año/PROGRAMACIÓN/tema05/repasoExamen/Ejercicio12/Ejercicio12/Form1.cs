using System;
using System.CodeDom.Compiler;
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

        const int TAM = 14;
        int[] vector = new int[TAM];

        void leerVector(int[] vector)
        {
            for(int i = 0; i < TAM; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introducir numeros"));
            }
        }

        void calcular(int[] vector, out int tempMax, out int tempMin, out int media)
        {
            tempMax = 0; 
            tempMin = vector[0];
            media = 0;
            for(int i = 0; i < TAM; i++)
            {
                if (vector[i] < tempMin)
                {
                    tempMin = vector[i];
                }
                else if (vector[i] > tempMax)
                {
                    tempMax = vector[i];
                }
                media += vector[i];
            }
            media = media / TAM;
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
            leerVector(vector);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int tempMax, tempMin, media;
            calcular(vector, out tempMax, out tempMin, out media);
            string texto = mostrarVector(vector);
            MessageBox.Show(texto + "\n" + tempMax + ", " + tempMin + ", " + media);
        }
    }
}
