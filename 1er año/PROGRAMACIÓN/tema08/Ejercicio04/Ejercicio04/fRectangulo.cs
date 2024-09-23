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
    public partial class fRectangulo : Form
    {
        List<Figura> listaFiguras;

        public fRectangulo(List<Figura> listaFiguras)
        {
            InitializeComponent();

            this.listaFiguras = listaFiguras;
        }

        private void btnAnyadirRectangulo_Click(object sender, EventArgs e)
        {
            int posX = int.Parse(txtPosX.Text);
            int posY = int.Parse(txtPosY.Text);
            string color = txtColor.Text;
            int bas = int.Parse(txtBase.Text);
            int altura = int.Parse(txtAltura.Text);
            Rectangulo rectangulo = new Rectangulo(posX, posY, color, bas, altura);
            listaFiguras.Add(rectangulo);
            MessageBox.Show("Rectangulo Añadido correctamente");
        }
    }
}
