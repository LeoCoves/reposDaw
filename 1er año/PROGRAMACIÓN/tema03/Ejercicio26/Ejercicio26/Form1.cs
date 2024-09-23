using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            const int NUMERO = 99;
            string multiplos = " ";
            int resultado = 0;
            int contador = 0;
            

            for(int i = 3; i <= NUMERO; i += 3)
            {
                contador++;
                multiplos += i + ", ";

                if(contador == 7)
                {
                    contador = 0;
                    multiplos += "\n";
                }

                resultado += i;
            }
            
            MessageBox.Show("Serie:\n" + multiplos + "\n" + "Suma:" + resultado);
        }
    }
}
