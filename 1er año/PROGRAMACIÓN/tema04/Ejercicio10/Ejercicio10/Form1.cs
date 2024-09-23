using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        void elevar(int num, out int elevar2, out int elevar5, out int elevar7)
        {
            elevar2 = num;
            elevar5 = num;
            elevar7 = num;
            int i;

            for (i = 1; i < 2; i++)
            {
                elevar2 *= num; 
            }

            for (i = 1; i < 5; i++)
            {
                elevar5 *= num;
            }

            for (i = 1; i < 7; i++)
            {
                elevar7 *= num;
            }

        }

        int calcularPoten(int baseNum, int exponente)
        {
            int resultado = 1;

            for (int i = 0; i < exponente; i++)
            {
                resultado *= baseNum;
            }

            return resultado;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int elevar2, elevar5, elevar7;
            int num = int.Parse(txt1.Text);

            elevar(num, out elevar2, out elevar5, out elevar7);

            MessageBox.Show("Elevado a 2: " + elevar2 + "\n" +
                            "Elevado a 5: " + elevar5 + "\n" +
                            "Elevado a 7: " + elevar7);
        }

        private void btnCalcular2_Click(object sender, EventArgs e)
        {
            int num = int.Parse(txt1.Text);

            if (num > 0)
            {
                int cuadrado = calcularPoten(num, 2);
                int quinta = calcularPoten(num, 5);
                int septima = calcularPoten(num, 7);

                MessageBox.Show("Elevado a 2: " + cuadrado + "\n" +
                            "Elevado a 5: " + quinta + "\n" +
                            "Elevado a 7: " + septima);
            }
        }
    }
}
