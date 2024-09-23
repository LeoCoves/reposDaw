using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejemplo01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bMostrar_Click(object sender, EventArgs e)
        {
            
            string nombre, apellido;
            string nombreCompleto;

            //Recogemos el TextBox correspondiente con su .text
            nombre = tCuadroTexto1.Text;
            apellido = tCuadroTexto2.Text;

            nombreCompleto = "Tu nombre completo es: " + nombre + " " + apellido;

            MessageBox.Show(nombreCompleto);
        }
    }
}
