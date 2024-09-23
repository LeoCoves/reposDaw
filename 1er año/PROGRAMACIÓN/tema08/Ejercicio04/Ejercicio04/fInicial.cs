using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio04
{
    public partial class fInicial : Form
    {
        public fInicial()
        {
            InitializeComponent();
        }

        List<Figura> listaFiguras = new List<Figura>();

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            fCirculo fCir = new fCirculo(listaFiguras);

            fCir.ShowDialog();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            fCuadrado fCua = new fCuadrado(listaFiguras);

            fCua.ShowDialog();
        }

        private void btnTriangulo_Click(object sender, EventArgs e)
        {
            fTriangulo fTri = new fTriangulo(listaFiguras);

            fTri.ShowDialog();
        }

        private void btnRectangulo_Click(object sender, EventArgs e)
        {
            fRectangulo fRec = new fRectangulo(listaFiguras);

            fRec.ShowDialog();
        }

        private void btnHexagono_Click(object sender, EventArgs e)
        {
            fHexagono fHex = new fHexagono(listaFiguras);

            fHex.ShowDialog();
        }

        private void btnMostrarFiguras_Click(object sender, EventArgs e)
        {
            int contador = 1;
            string texto = "Lista de figuras\n";
            foreach (Figura figura in listaFiguras)
            {
                texto += "Figura " + contador + "\n";
                texto += figura.quienSoy() + "\n";
                texto += figura.ToString() + "\n";
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
                    texto += "Círculo num " + cont + "\n";
                    texto += figura.ToString();
                    texto += "Mi área es " + figura.Area() + "\n";
                    texto += "Mi perimetro es " + figura.Perimetro() + "\n";
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
                    texto += "\nCírculo num " + cont + "\n";
                    texto += figura.ToString();
                    texto += "Mi área es " + figura.Area() + "\n";
                    texto += "Mi perimetro es " + figura.Perimetro() + "\n";
                    cont++;
                }
            }
            MessageBox.Show(texto);
        }

        private void btnMostrarTriangulos_Click(object sender, EventArgs e)
        {
            string texto = "Datos de los círculos:\n\n";
            int cont = 1;
            foreach (Figura figura in listaFiguras)
            {
                // Con este if comprobamos si la figura
                // es un círculo
                if (figura.GetType() == typeof(Triangulo))
                {
                    texto += "\nCírculo num " + cont + "\n";
                    texto += figura.ToString();
                    texto += "Mi área es " + figura.Area() + "\n";
                    texto += "Mi perimetro es " + figura.Perimetro() + "\n";
                    cont++;
                }
            }
            MessageBox.Show(texto);
        }

        private void btnMostrarRectangulos_Click(object sender, EventArgs e)
        {
            string texto = "Datos de los círculos:\n\n";
            int cont = 1;
            foreach (Figura figura in listaFiguras)
            {
                // Con este if comprobamos si la figura
                // es un círculo
                if (figura.GetType() == typeof(Rectangulo))
                {
                    texto += "\nCírculo num " + cont + "\n";
                    texto += figura.ToString();
                    texto += "Mi área es " + figura.Area() + "\n";
                    texto += "Mi perimetro es " + figura.Perimetro() + "\n";
                    cont++;
                }
            }
            MessageBox.Show(texto);
        }

        private void btnMostrarHexagonos_Click(object sender, EventArgs e)
        {
            string texto = "Datos de los círculos:\n\n";
            int cont = 1;
            foreach (Figura figura in listaFiguras)
            {
                // Con este if comprobamos si la figura
                // es un círculo
                if (figura.GetType() == typeof(Hexagono))
                {
                    texto += "\nCírculo num " + cont + "\n";
                    texto += figura.ToString();
                    texto += "Mi área es " + figura.Area() + "\n";
                    texto += "Mi perimetro es " + figura.Perimetro() + "\n";
                    cont++;
                }
            }
            MessageBox.Show(texto);
        }
    }
}
