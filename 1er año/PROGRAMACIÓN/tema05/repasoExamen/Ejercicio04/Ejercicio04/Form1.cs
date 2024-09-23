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

        double[] vector = new double[10];

        void readVector(double[] vector)
        {
            for(int i = 0; i < vector.Length; i++)
            {
                vector[i] = double.Parse(Interaction.InputBox("Introduce numeros"));
            }
        }

        double contarNeg(double[] vector)
        {
            double negativos = 0;
            for(int i = 0; i < vector.Length; i++)
            {
                if (vector[i] < 0)
                {
                    negativos++;
                }
                else
                {
                    vector[i] = 0;
                }
            }
            return negativos;
        }

        string mostrarVector(double[] vector)
        {
            string texto = "La lista es: \n";
            for(int i = 0; i < vector.Length; i++)
            {
                texto += vector[i] + ", ";
            }
            texto += "\n" + "El numero de negativos son " + contarNeg(vector);
            return texto;
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            readVector(vector);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            contarNeg(vector);
            string texto = mostrarVector(vector);
            MessageBox.Show(texto); ;
        }
    }
}
