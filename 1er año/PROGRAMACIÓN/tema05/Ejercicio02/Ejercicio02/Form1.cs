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

namespace Ejercicio02
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
            for (int i = 0; i < vector.Length; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce el numero: " + i));
            }
        }

        double mediaVector(int[] vector)
        {
            double media = 0;
            for (int i = 0; i < vector.Length; i++)
            {
                media += vector[i];
            }
            media = media / (double)TAM;
            return media;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            leerVector(vector);
            double media = mediaVector(vector);
            MessageBox.Show(media.ToString());   



        }
    }
}
