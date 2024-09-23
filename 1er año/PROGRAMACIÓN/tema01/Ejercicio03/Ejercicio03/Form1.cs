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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Boton1_Click(object sender, EventArgs e)
        {
            tCuadroTexto1.Text = "Se ha pulsado el boton 1";
        }

        private void Boton2_Click(object sender, EventArgs e)
        {
            tCuadroTexto1.Text = "Se ha pulsado el boton 2";
        }

        private void Boton3_Click(object sender, EventArgs e)
        {
            tCuadroTexto1.Clear();
            //tCuadrotexto.Text = String.Empty; tambien puede ser
        }
    }
}
