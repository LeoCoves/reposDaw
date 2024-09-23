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

        List<Figura> listaFiguras = new List<Figura>();

        void obtenerDatosFigura(out int posX, out int posY, out string color)
        {
            posX = int.Parse(Interaction.InputBox("Introduce pos X"));
            posY = int.Parse(Interaction.InputBox("Introduce pos Y"));
            color = Interaction.InputBox("Introduce el color");
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            obtenerDatosFigura(out int posX, out int posY, out string color);
            int radio = int.Parse(Interaction.InputBox("Introduce el radio"));
            Circulo circulo = new Circulo(posX, posY, color, radio);
            listaFiguras.Add(circulo);
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            obtenerDatosFigura(out int posX, out int posY, out string color);
            int lado = int.Parse(Interaction.InputBox("Introduce el lado"));
            Cuadrado cuadrado = new Cuadrado(posX, posY, color, lado);
            listaFiguras.Add(cuadrado);
        }

        private void btnMostrarFiguras_Click(object sender, EventArgs e)
        {
            int contador = 1;
            string texto = "Lista de figuras\n";
            foreach(Figura figura in listaFiguras)
            {
                texto += "Figura " + contador + "\n";
                texto += figura.quienSoy() + "\n";
                texto += figura.ToString();
                texto += "Mi area es " + figura.Area() + "\n";
                contador++;
            }
            MessageBox.Show(texto);
        }

        private void btnMostrarCirculos_Click(object sender, EventArgs e)
        {
            string texto = "Datos de los círculos:\n\n";
            int cont = 1;
            foreach (Figura figura in listaFiguras)
            {
                // Con este if comprobamos si la figura
                // es un círculo
                if (figura.GetType() == typeof(Circulo))
                {
                    texto = texto + "Círculo num " + cont + "\n";
                    texto = texto + figura.ToString();
                    texto = texto + "Mi área es " + figura.Area() + "\n\n";
                    cont++;
                }
            }
            MessageBox.Show(texto);
        }

        private void btnMostrarCuadrados_Click(object sender, EventArgs e)
        {
            string texto = "Datos de los círculos:\n\n";
            int cont = 1;
            foreach (Figura figura in listaFiguras)
            {
                // Con este if comprobamos si la figura
                // es un círculo
                if (figura.GetType() == typeof(Cuadrado))
                {
                    texto = texto + "\nCírculo num " + cont + "\n";
                    texto = texto + figura.ToString();
                    texto = texto + "Mi área es " + figura.Area() + "\n";
                    cont++;
                }
            }
            MessageBox.Show(texto);
        }
    }
}
