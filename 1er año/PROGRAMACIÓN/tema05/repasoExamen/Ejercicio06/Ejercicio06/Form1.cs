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

        const int TAM = 4;
        int[] vector1 = new int[TAM];
        int[] vector2 = new int[TAM];

        void readVector(int[] vector)
        {
            for(int i = 0; i < TAM; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce numeros"));
            }
        }

        bool comprobar(int[] vector1, int[] vector2)
        {
            bool esIgual = true;

            for(int i = 0; i < TAM; i++)
            {
                if (vector1[i] != vector2[i])
                {
                    esIgual = false;
                }
            }
            return esIgual;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            readVector(vector1);
            MessageBox.Show("Ahora la segunda lista");
            readVector(vector2);
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
                MessageBox.Show("No son iguales");
            }
        }
    }
}
