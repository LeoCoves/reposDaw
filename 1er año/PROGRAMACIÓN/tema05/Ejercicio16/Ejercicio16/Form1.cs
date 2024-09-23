using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio16
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
            int i = 1;
            vector[0] = int.Parse(Interaction.InputBox("Introduce el numero 0"));

            while (i < TAM)
            {
                int numero = int.Parse(Interaction.InputBox("Introduce el numero " + i));

                if (buscarNumVector(vector, numero))
                {
                    MessageBox.Show("Introduce otro numero no repetido");
                }
                else
                {
                    vector[i] = numero;
                    i++;
                }
            }   
        }

        bool buscarNumVector(int[] vector, int numero)
        {
            bool encontrado = false;

            for(int i = 0; i < TAM; i++)
            {
                if(numero == vector[i])
                {
                    encontrado = true;
                }
            }
            return encontrado;
        }

        string mostrarVector(int[] vector)
        {
            string texto = "";

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
            string texto = mostrarVector(vector);
            MessageBox.Show("Los numeros introducidos son: \n" + texto);
        }
    }
}
