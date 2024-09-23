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

namespace Ejercicio04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int TAM = 5;

        int[] vector = new int [TAM];

        void leerVector(int[] vector)
        {
            for(int i = 0; i < vector.Length; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce el numero " + i));
            }
        }

        string mostrarNum(int[] vector)
        {
            string texto = "Los numeros introducidos son: \n";
            int numNegativos = 0;

            for (int i = 0; i < vector.Length;i++)
            {

                if (vector[i] > 0)
                {
                    vector[i] = 0;
                }
                else if (vector[i] < 0)
                {
                    numNegativos++;
                }

                texto += vector[i] + ", ";  
            }

            texto += "\n" + "Los numeros negativos son " + numNegativos;

            return texto;
        }

       

        private void btnLeer_Click(object sender, EventArgs e)
        {
            leerVector(vector);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string texto = mostrarNum(vector);
            MessageBox.Show(texto);
        }
    }
}
