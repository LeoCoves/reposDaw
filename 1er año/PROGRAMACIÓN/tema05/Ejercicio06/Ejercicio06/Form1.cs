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

namespace Ejercicio06
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int TAM = 10;
        int[] vector1 = new int[TAM];
        int[] vector2 = new int[TAM];   

        void leerVector(int[] vectores)
        {
            for (int i = 0; i < TAM; i++)
            {
                vectores[i] = int.Parse(Interaction.InputBox("Introduce el numero " + i));
            }
        }

        bool comprobar(int[] v1, int[] v2)
        {
            bool encontrado = true;

            for(int i = 0; i < TAM; i++)
            {
                if (v1[i] != v2[i])
                {
                    encontrado = false;
                }
            }
            return encontrado;
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            leerVector(vector1);
            leerVector(vector2);
        }

        private void btnComprobar_Click(object sender, EventArgs e)
        {
            bool encontrado = comprobar(vector1, vector2);

            if (encontrado == true)
            {
                MessageBox.Show("Son iguales");
            }
            else
            {
                MessageBox.Show("No Son iguales");
            }
        }
    }
}
