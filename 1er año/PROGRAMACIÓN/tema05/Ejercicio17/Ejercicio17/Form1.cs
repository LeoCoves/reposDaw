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

namespace Ejercicio17
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
            for(int i = 0; i < TAM; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce el numero " + i));
            }
        }

        int busquedaVector(int[] vector, int valor)
        {
            bool encontrado = false;
            int res;
            int i = 0;
            
            while(i < TAM && !encontrado)
            {
                if (vector[i] == valor)
                {
                    encontrado = true;
                }
                else
                {
                    i++;
                }
            }

            if (encontrado)
            {
                res = i;
            }
            else
            {
                res = -1;
            }
            return res;
        }

        void ordenarVector(int[] vector)
        {
            int aux;

            for (int i = 0; i < TAM - 1; i++)
            {
                for (int j = i + 1; j < TAM; j++)
                {
                    if (vector[j] > vector[i])
                    {
                        aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }
                }
            }
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

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(Interaction.InputBox("Introduce el valor a buscar:"));
            int res = busquedaVector(vector, valor);

            if (res == -1)
            {
                MessageBox.Show("No se encuentra en ninguna posición");
            }
            else
            {
                MessageBox.Show("Se encuentra en la " + res + " posicion");
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            ordenarVector(vector);
            string texto = mostrarVector(vector);
            MessageBox.Show("Ordenado seria \n" + texto);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string texto = mostrarVector(vector);
            MessageBox.Show("Los numeros introducidos son \n" + texto);
        }
    }
}
