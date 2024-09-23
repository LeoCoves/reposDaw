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

namespace Ejercicio07
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
            int i = 1;
            vector[0] = int.Parse(Interaction.InputBox("Introduce el numero 0"));

            while (i < TAM)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce el numero " + i));
                
                if (vector[i] < vector[i-1])
                {
                    MessageBox.Show("Introduce un numero mayor");
                    
                }
                else
                {
                    i++;
                }
                
            }
        }

        string mostrarVector(int[] vector)
        {
            string texto = "Los numeros son: \n";
            vector[0] = int.Parse(Interaction.InputBox("Introduce el numero 0"));
            int i = 1;

            while (i < TAM)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce el numero " + i));

                if (vector[i] <= vector[i-1])
                {
                    MessageBox.Show("Introduce un numero mayor");
                }
                else
                {
                    texto += vector[i] + ", ";
                    i++;
                }
            }
            return texto;
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            leerVector(vector);
            string texto = mostrarVector(vector);
            MessageBox.Show(texto);
        }
        
    }
}
