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

namespace Ejercicio08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int TAM = 5;
        int[] vector = new int[TAM];

        void leerVector(int[] vector)
        {
            int i = 0;
            int numero; 

            while (i < TAM)
            {
                numero = int.Parse(Interaction.InputBox("Introduce el numero " + i));

                if (numero <= 0)
                {
                    MessageBox.Show("Debe ser mayor que 0");
                }
                else
                {
                    vector[i] = numero;
                    i++;
                }
            }
        }

        int modificar(int[] vector)
        {
            int modificados = 0;

            for (int i = 0; i < TAM; i++)
            {
                if (vector[i] != -1)
                {
                    for (int j = i + 1; j < vector.Length; j++)
                    {
                        if (vector[i] == vector[j])
                        {
                            vector[j] = -1;
                            modificados++;
                        }
                    }
                }
            }
            return modificados;
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
            leerVector(vector);
        }

        private void btnCambiar_Click(object sender, EventArgs e)
        {
            int modificados = modificar(vector);
            string texto = mostrarVector(vector);

            MessageBox.Show(texto + "\n Los numeros repetidos son: " + modificados);
        }
    }
}
