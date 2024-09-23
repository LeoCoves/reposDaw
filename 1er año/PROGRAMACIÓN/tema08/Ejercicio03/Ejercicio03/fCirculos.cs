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
    public partial class fCirculos : Form
    {
        List<Figura> listaFiguras;

        public fCirculos(List<Figura> listaFiguras)
        {
            InitializeComponent();

            this.listaFiguras = listaFiguras;
        }


        private void btnAnyadirCirculo_Click(object sender, EventArgs e)
        {
            int posX = int.Parse(txtPosX.Text);
            int posY = int.Parse(txtPosY.Text);
            string color = txtColor.Text;
            int radio = int.Parse(txtRadio.Text);
            Circulo circulo = new Circulo(posX, posY, color, radio);
            listaFiguras.Add(circulo);
            MessageBox.Show("Añadida correctamente");
        }

        private void fCirculos_Load(object sender, EventArgs e)
        {

        }
    }
}
