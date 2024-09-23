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


namespace Ejercicio08
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool validarNota(double num1, double num2, double num3)
        {
            bool validar = false;
            

            if ((num1 >= 0 && num1 <= 10) && (num2 >= 0 && num2 <= 10) && (num3 >= 0 && num3 <= 10))
            {
                validar = true;
            }

            return validar;
        }

        double calculoNotaMedia(double num1, double num2, double num3)
        {
            double media = 0;

            media = (num1 + num2 + num3) / 3;

            return media;
        }

        

        private void btnCalcular_Click(object sender, EventArgs e)
        {

            double nota1 = double.Parse(txt1.Text);
            double nota2 = double.Parse(txt2.Text);
            double nota3 = double.Parse(txt3.Text);

            bool valido = validarNota(nota1, nota2, nota3);

            if (valido)
            {
                double notaMedia = calculoNotaMedia(nota1, nota2, nota3);

                MessageBox.Show("La media es: " + notaMedia);
            }

            else
            {
                MessageBox.Show("Introduce notas validas");
            }

        }
    }
}
