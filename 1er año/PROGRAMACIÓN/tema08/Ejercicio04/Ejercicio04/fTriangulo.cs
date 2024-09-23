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
    public partial class fTriangulo : Form
    {
        List<Figura> listaFiguras;

        public fTriangulo(List<Figura> listaFiguras)
        {
            InitializeComponent();

            this.listaFiguras = listaFiguras;
        }

        private void btnAnyadirTriangulo_Click(object sender, EventArgs e)
        {
            int posX = int.Parse(txtPosX.Text);
            int posY = int.Parse(txtPosY.Text);
            string color = txtColor.Text;
            int lado = int.Parse(txtLado.Text);
            Triangulo triangulo = new Triangulo(posX, posY, color, lado);
            listaFiguras.Add(triangulo);
            MessageBox.Show("Triangulo Añadido correctamente");
        }
    }
}
