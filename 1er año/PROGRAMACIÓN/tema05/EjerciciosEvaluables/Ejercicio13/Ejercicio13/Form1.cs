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
        int[] vector1 = new int[TAM];
        

        void leerVector(int[] vector)
        {
            for(int i = 0; i < vector.Length; i++)
            {
                vector[i] = int.Parse(Interaction.InputBox("Introduce un numero"));
            }
        }

        bool buscarNum(int[] v1, ref int verificar)
        {
            bool encontrado = false;

            for(int i = 0; i < v1.Length;i++)
            {
                if (v1[i] == verificar)
                {
                    encontrado = true;
                }
            }
            return encontrado;
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            leerVector(vector1);
        }

        private void btnEncontrar_Click(object sender, EventArgs e)
        {
            int verificar = int.Parse(Interaction.InputBox("Introduce un numero"));
            
            bool encontrado = buscarNum(vector1, ref verificar);

            if (encontrado)
            {
                MessageBox.Show("SI SE ENCUENTRA");
            }
            else
            {
                MessageBox.Show("NO SE ENCUENTRA");
            }
        }
    }
}
