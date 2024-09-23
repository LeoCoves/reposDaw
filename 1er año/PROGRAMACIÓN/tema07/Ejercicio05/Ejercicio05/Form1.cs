using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio05
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        listaEmpleados empresa = new listaEmpleados();

        private void btnEnterEmployer_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduce su nombre");
            int edad = int.Parse(Interaction.InputBox("Introduce la edad"));

            empresa.anyadirEmpleado(nombre, edad);
        }

        private void btnDelEmployer_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduce el nombre del empleado a eliminar");

            bool encontrado = empresa.eliminarEmpleado(nombre);
            if (encontrado)
            {
                MessageBox.Show("Empleado Eliminado");
            }
            else
            {
                MessageBox.Show("No se ha encontrado el usuario");
            }
        }

        private void btnShowListEmployer_Click(object sender, EventArgs e)
        {
            string texto = empresa.mostrarListaEmpleados();

            if (empresa.comprobarSiHayEmpleados())
            {
                MessageBox.Show(texto);
            }
            else
            {
                MessageBox.Show("No hay empleados");
            }
        }

        private void btnOrderEmployerAlf_Click(object sender, EventArgs e)
        {
            if (empresa.comprobarSiHayEmpleados())
            {
                empresa.orderEmpAlf();
                MessageBox.Show("Ordenado correctamente");
            }
            else
            {
                MessageBox.Show("No hay empleados");
            }
        }

        private void btnShowDataEmployer_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduce el nombre del empleado para ver sus datos");
            bool encontrado;
            string texto;
            empresa.mostrarDatosEmpleado(nombre, out encontrado, out texto);

            if (encontrado)
            {
                MessageBox.Show(texto);
            }
            else
            {
                MessageBox.Show("No se ha encontrado el usuario");
            }
        }

        private void btnAddSales_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduce el empleado que ha hecho una venta");
            double ventas = double.Parse(Interaction.InputBox("Numero de ventas"));
            bool encontrado = empresa.addVenta(nombre, ventas);

            if (encontrado)
            {
                MessageBox.Show("Ventas introducidas");
            }
            else
            {
                MessageBox.Show("No se ha encontrado al empleado");
            }
        }

        private void btnShowEmpBestSales_Click(object sender, EventArgs e)
        {
            string texto = empresa.showDataEmpBestSales();
            if (empresa.comprobarEmpleadosSinVentas())
            {
                MessageBox.Show("Ningun empleado tiene ventas");
            }
            else
            {
                MessageBox.Show(texto);
            }
        }

        private void btnDelSales_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Introduce el empleado que quieras eliminar sus ventas");

            if (empresa.deleteVentas(nombre))
            {
                if (empresa.comprobarSiHayVentas(nombre))
                {
                    MessageBox.Show("No tiene ventas para eliminar");
                }
                else
                {
                    MessageBox.Show("Ventas borradas correctamente");
                }
            }
            else
            {
                MessageBox.Show("No se ha encontrado el empleado");
            }
        }

        private void btnOrderEmpXSales_Click(object sender, EventArgs e) 
        {
            if (empresa.comprobarEmpleadosSinVentas())
            {
                MessageBox.Show("Ningun empleado tiene ventas");
            }
            else
            {
                empresa.ordenarEmpleadoPorVentas();
            }
        }
    }
}
