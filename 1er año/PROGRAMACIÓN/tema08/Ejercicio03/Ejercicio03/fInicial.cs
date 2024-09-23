using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio03
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
            fCirculos fCir = new fCirculos(listaFiguras);

            fCir.ShowDialog();
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            fCuadrados fCua = new fCuadrados(listaFiguras);

            // Aquí le pasamos la lista de cursos para poder utilizarla luego en el formulario de cursos.

            fCua.ShowDialog();
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
