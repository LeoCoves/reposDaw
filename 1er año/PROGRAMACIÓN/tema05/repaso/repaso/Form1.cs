using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using Microsoft.VisualBasic;

namespace repaso
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        const int TAM = 20;
        int[] vector = new int[TAM];

        void leerVector(int[] vector)
        {
            int i = 0;
            int num;

            while (i < TAM)
            {
                num = int.Parse(Interaction.InputBox("Introduce un numero"));

                if (esPerfecto(num))
                {
                    i = 0;
                    MessageBox.Show("Error");
                }
                else
                {
                    vector[i] = num;
                    i++;
                }
            }
        }
        bool esPerfecto(int num)
        {
            int suma = 0;
            bool perfecto = false;
            
            for(int i = 1; i < num; i++)
            {
                if(num % i == 0)
                {
                    suma += i;
                } 
            }
            if(suma == num)
            {
                perfecto = true;
            }
            return perfecto;
        }

        string mostrarVector(int[] vector)
        {
            string texto = "";

            for(int i = 0; i < TAM; i++)
            {
                texto += vector[i] + ", ";
            }
            return texto;
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            leerVector(vector);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            string texto = mostrarVector(vector);
        }
    }
}
