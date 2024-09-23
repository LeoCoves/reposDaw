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

        const int TAM = 10;
        int[] vector = new int[TAM];

        void leerVector(int[] vector)
        {
            for(int i = 0; i < TAM; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce"));
            }
        }

        int media(int[] vector)
        {
            int numMedia = 0;

            for(int i = 0; i < TAM; i++)
            {
                numMedia += vector[i];
            }
            numMedia = numMedia / TAM;
            return numMedia;
        }

        string mostrarVector(int[] vector)
        {
            string texto = "La lista de mayores o iguales a la media: \n";
            for(int i = 0; i < TAM; i++)
            {
                if (vector[i] >= media(vector))
                {
                    texto += vector[i] + ", ";
                }
            }
            return texto;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            leerVector(vector);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("La media es " + media(vector));
            MessageBox.Show(mostrarVector(vector));
        }
    }
}
