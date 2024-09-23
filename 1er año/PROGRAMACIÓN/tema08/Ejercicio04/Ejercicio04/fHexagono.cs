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
    public partial class fHexagono : Form
    {
        List<Figura> listaFiguras;

        public fHexagono(List<Figura> listaFiguras)
        {
            InitializeComponent();

            this.listaFiguras = listaFiguras;
        }

        private void btnAnyadirHexagono_Click(object sender, EventArgs e)
        {
            int posX = int.Parse(txtPosX.Text);
            int posY = int.Parse(txtPosY.Text);
            string color = txtColor.Text;
            int lado = int.Parse(txtLado.Text);
            Hexagono hexagono = new Hexagono(posX, posY, color, lado);
            listaFiguras.Add(hexagono);
            MessageBox.Show("Cuadrado Añadido correctamente");
        }
    }
}
