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

namespace Ejercicio13
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

        void pedirNumero(out int num)
        {
            num = int.Parse(Interaction.InputBox("Introduce un numero"));
        }

        bool comprobar(int[] vector, int num)
        {
            bool encontrado = false;

            for(int i = 0; i < TAM; i++)
            {
                if (vector[i] == num)
                {
                    encontrado = true;
                }
            }
            return encontrado;
        }


        private void btnRead_Click(object sender, EventArgs e)
        {
            leerVector(vector);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int num;
            pedirNumero(out num);
            if(comprobar(vector, num))
            {
                MessageBox.Show("Si esta");
            }
            else
            {
                MessageBox.Show("No esta");
            }
        }
    }
}
