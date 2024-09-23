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

namespace Ejercicio15
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
            for(int i = 0; i < TAM; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce numeros"));
            }
        }

        void numMayMen(int[] vector, out int numMenor, out int numMayor)
        {
            numMayor = vector[0];
            numMenor = vector[0];

            for(int i = 0; i < TAM; i++)
            {
                if(numMenor < vector[i])
                {
                    numMenor = vector[i];
                }
                else if(numMayor > vector[i])
                {
                    numMayor = vector[i];
                }
            }
        }

        void numRep(int[] vector, out int numMayRep, out int numMenRep)
        {
            numMayMen(vector, out int numMay, out int numMen);
            numMayRep = 0;
            numMenRep = 0;

            for(int i = 0; i < TAM; i++)
            {
                if (vector[i] == numMay)
                {
                    numMayRep++;
                }
                else if (vector[i] == numMen)
                {
                    numMenRep++;
                }
            }
        }



        private void btnRead_Click(object sender, EventArgs e)
        {
            leerVector(vector);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int numMayRep, numMenRep;
            numRep(vector, out numMayRep, out numMenRep);
            MessageBox.Show("Numeros mayores repetidos: " + numMayRep + "\n" +
                            "Numeros menores repetidos: " + numMenRep);
        }
    }
}
