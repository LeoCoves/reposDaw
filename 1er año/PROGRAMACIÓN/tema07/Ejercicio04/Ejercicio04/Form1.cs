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

namespace Ejercicio04
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

         listaEmpleados empresa = new listaEmpleados(); 

        private void btn1_Click(object sender, EventArgs e)
        {
            string Nombre = Interaction.InputBox("Introduce el nombre del empleado");
            int Edad = int.Parse(Interaction.InputBox("Introduce su edad"));

            empresa.addEmployer(Nombre, Edad);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            string texto = empresa.showListEmployer();
            MessageBox.Show(texto);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduce el nombre");
            bool encontrado = empresa.Birthay(nombre);

            if (!encontrado)
            {
                MessageBox.Show("No se ha encontrado a ningun empleado");
            }
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduce el nombre");
            double venta = double.Parse(Interaction.InputBox("Introduce una venta"));
            bool encontrado = empresa.addVenta(nombre, venta);

            if (!encontrado)
            {
                MessageBox.Show("No se ha encontrado a ningun empleado");
            }
        }
    }
}
