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
    public partial class fCuadrados : Form
    {
        List<Figura> listaFiguras;
        public fCuadrados(List<Figura> listaFiguras)
        {
            InitializeComponent();
            this.listaFiguras = listaFiguras;
        }

        private void btnAnyadirCuadrado_Click(object sender, EventArgs e)
        {
            int posX = int.Parse(txtPosX.Text);
            int posY = int.Parse(txtPosY.Text);
            string color = txtColor.Text;
            int lado = int.Parse(txtLado.Text);
            Cuadrado cuadrado = new Cuadrado(posX, posY, color, lado);
            listaFiguras.Add(cuadrado);
            MessageBox.Show("Añadido correctamente");
        }
    }
}
