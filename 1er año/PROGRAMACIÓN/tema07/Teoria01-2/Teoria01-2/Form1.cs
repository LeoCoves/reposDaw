using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Teoria01_2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Empleado emp = new Empleado();

        void leerDatos()
        {
            emp.Nombre = Interaction.InputBox("Introduce el nombre: ");
            emp.Edad = int.Parse(Interaction.InputBox("Introduce la edad: "));
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            leerDatos();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(emp.mostrarDatos());
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            emp.Cumpleanyos();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            double venta = double.Parse(Interaction.InputBox("Introduce una venta: "));
            emp.anyadirVenta(venta);
        }
    }
}
