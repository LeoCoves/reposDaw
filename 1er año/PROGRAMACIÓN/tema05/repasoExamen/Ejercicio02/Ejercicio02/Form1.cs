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

        void readVector(int[] vector)
        {
            for(int i = 0; i < TAM; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce numeros"));
            }
        }

        int mediaVector(int[] vector)
        {
            int media = 0;
            for(int i = 0; i < TAM; i++)
            {
                media += vector[i];
            }
            media /= TAM;
            return media;
        }


        private void btnRead_Click(object sender, EventArgs e)
        {
            readVector(vector);
            int media = mediaVector(vector);
            MessageBox.Show("La media es " + media);
        }
    }
}
