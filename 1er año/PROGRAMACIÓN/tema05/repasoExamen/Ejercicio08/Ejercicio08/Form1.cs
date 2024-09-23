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

        const int TAM = 6;
        int[] vector = new int[TAM];

        void readVector(int[] vector)
        {
            for(int i = 0; i < TAM; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce numeros"));
            }
        }

        int sustituir(int[] vector)
        {
            int modificados = 0;

            for(int i = 0; i < TAM; i++)
            {
                if (vector[i] != -1)
                {
                    for(int j = i + 1; j < TAM; j++)
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

        string showVector(int[] vector)
        {
            string texto = "La lista es : \n";
            for(int i = 0; i < TAM; i++)
            {
                texto += vector[i] + ", ";
            }
            return texto;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            readVector(vector);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int num = sustituir(vector);
            MessageBox.Show(showVector(vector) + "\n" + "Los modificados son: \n" + num);
        }
    }
}
