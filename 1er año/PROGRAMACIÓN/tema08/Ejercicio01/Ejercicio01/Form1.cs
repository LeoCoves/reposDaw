using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCirculo_Click(object sender, EventArgs e)
        {
            Circulo circulo = new Circulo(10, 20, "azul", 5);
            Figura figura = circulo;
            MessageBox.Show(figura.quienSoy());
            MessageBox.Show(figura.ToString());
            MessageBox.Show("El area es: " + figura.Area());
        }

        private void btnCuadrado_Click(object sender, EventArgs e)
        {
            Cuadrado cuadrado = new Cuadrado(10, 20, "Rojo", 10);
            Figura figura = cuadrado;
            MessageBox.Show(figura.quienSoy());
            MessageBox.Show(figura.ToString());
            MessageBox.Show("El area es: " + figura.Area());
        }
    }
}
