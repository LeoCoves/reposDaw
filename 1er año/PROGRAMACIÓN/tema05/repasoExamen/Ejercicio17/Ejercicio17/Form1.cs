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

        const int TAM = 6;
        int[] vector = new int[TAM];

        void leerVector(int[] vector)
        {
            for(int i = 0; i < TAM; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce"));
            }
        }

        bool buscarElemento(int[] vector, out int num)
        {
            num = int.Parse(Interaction.InputBox("Introduce el numero a buscar"));
            bool encontrado = false;

            for(int i = 0; i < TAM && !encontrado ; i++)
            {
                if(num == vector[i])
                {
                    encontrado = true;
                }
            }
            return encontrado;
        }

        int buscarPosicion(int[] vector, ref int num)
        {
            int posicion = 0;
            for(int i = 0; i < TAM; i++)
            {
                if(num == vector[i])
                {
                    posicion = i;
                }
            }
            return posicion;
        }

        void ordenar(int[] vector)
        {
            int i = 0;
            while(i < TAM)
            {
                int j = i + 1;
                while (j < TAM)
                {
                    if (vector[j] > vector[i])
                    {
                        int aux = vector[i];
                        vector[i] = vector[j];
                        vector[j] = aux;
                    }
                    j++;
                }
                i++;
            }
        }

        string mostrarVector(int[] vector)
        {
            string texto = "La lista es \n";
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
            int num;

            if (buscarElemento(vector, out num))
            {
                MessageBox.Show("La posicion es la " + buscarPosicion(vector, ref num));
            }
            else
            {
                MessageBox.Show("No se ha encontrado");
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            ordenar(vector);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mostrarVector(vector));
        }
    }
}
