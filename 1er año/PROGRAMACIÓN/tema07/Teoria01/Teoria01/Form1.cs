using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Teoria01
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
            emp.Nombre = Interaction.InputBox("Introduzca el nombre del empleado.");
            emp.Edad = int.Parse(Interaction.InputBox("Introduzca la edad del empleado."));
        }
        private void btn1_Click(object sender, EventArgs e)
        {
            leerDatos();
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(emp.MostrarDatos());
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            emp.CumpleAnyos();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            double venta;
            venta = double.Parse(Interaction.InputBox("Introduzca la venta."));
           
            emp.AnyadirVenta(venta);
        }
    }
}
