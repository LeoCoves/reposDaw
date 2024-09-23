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
            int numero;
            vector[0] = int.Parse(Interaction.InputBox("Introduce"));

            while (i < TAM)
            {
                numero = int.Parse(Interaction.InputBox("Introduce"));
                if (buscarNum(vector, numero))
                {
                    MessageBox.Show("Introduce otro numero");
                }
                else
                {
                    vector[i] = numero;
                    i++;
                }
            }
        }

        bool buscarNum(int[] vector, int num)
        {
            bool encontrado = false;
            for(int i = 0; i <  TAM; i++)
            {
                if(num == vector[i])
                {
                    encontrado = true;
                }
            }
            return encontrado;
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

        private void btnRead_Click(object sender, EventArgs e)
        {
            leerVector(vector);
            MessageBox.Show(mostrarVector(vector));
        }
    }
}
