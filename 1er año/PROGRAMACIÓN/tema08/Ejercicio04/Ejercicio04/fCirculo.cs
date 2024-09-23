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
    public partial class fCirculo : Form
    {
        List<Figura> listaFiguras;

        public fCirculo(List<Figura> listaFiguras)
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
            MessageBox.Show("Circulo Añadido correctamente");
        }
    }
}
