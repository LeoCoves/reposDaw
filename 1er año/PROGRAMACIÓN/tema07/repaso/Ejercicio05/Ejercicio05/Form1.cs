using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Cryptography;
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

        listEmployers company = new listEmployers();

        private void btnAddEmployer_Click(object sender, EventArgs e)
        {
            string DNI = Interaction.InputBox("DNI");
            string Nombre = Interaction.InputBox("Nombre");
            int Edad;
            do
            {
                Edad = int.Parse(Interaction.InputBox("Edad"));
            } while (Edad <= 0 || Edad >= 100);

            company.addEmployer(DNI, Nombre, Edad);
        }

        private void btnDelEmployer_Click(object sender, EventArgs e)
        {
            string dni = Interaction.InputBox("DNI");
            if (company.isEmpty())
            {
                MessageBox.Show("No hay empleados");
            }
            else
            {
                if (company.searchEmp(dni) > 0)
                {
                    company.deleteEmp(dni);
                    MessageBox.Show("Borrado correctamente");
                }
                else
                {
                    MessageBox.Show("No existe");
                }
            }
        }

        private void brnShowListEmp_Click(object sender, EventArgs e)
        {
            string texto;
            if (company.isEmpty())
            {
                MessageBox.Show("No hay empleados");
            }
            else
            {
                if (company.showListEmp(out texto))
                {

                }
                else
                {
                    texto = "No hay empleados";
                }
                MessageBox.Show(texto);
            }
        }

        private void btnOrderEmpAlf_Click(object sender, EventArgs e)
        {
            if (company.isEmpty())
            {
                MessageBox.Show("No hay empleados");
            }
            else
            {
                company.orderByName();
            }
        }

        private void showDataEmp_Click(object sender, EventArgs e)
        {
            string dni = Interaction.InputBox("DNI");
            string texto;
            if (company.isEmpty())
            {
                MessageBox.Show("No hay empleados");
            }
            else
            {
                if (company.searchEmp(dni) > 0)
                {
                    texto = company.showEmp(dni);
                }
                else
                {
                    texto = "No existe";
                    MessageBox.Show(texto);
                }
            }
        }

        private void btnAddSales_Click(object sender, EventArgs e)
        {
            string dni = Interaction.InputBox("DNI");
            int sales = int.Parse(Interaction.InputBox("Sales"));

            if (company.isEmpty())
            {
                MessageBox.Show("No hay empleados");
            }
            else
            {
                if (company.searchEmp(dni)>0)
                {
                    if(sales > 0)
                    {
                        company.addSalesEmployer(dni, sales);
                    }
                    else
                    {
                        MessageBox.Show("La venta debe ser positiva");
                    }
                }
                else
                {
                    MessageBox.Show("No existe ese empleado");
                }
            }
        }

        private void btnDelSales_Click(object sender, EventArgs e)
        {
            string dni = Interaction.InputBox("dni");
            bool empty;
            if (company.isEmpty())
            {
                MessageBox.Show("No hay empleados");
            }
            else
            {
                if (company.searchEmp(dni) > 0)
                {
                    company.delSalesEmployer(dni, out empty);
                    if (empty)
                    {
                        MessageBox.Show("No tiene ventas para eliminar");
                    }
                }
                else
                {
                    MessageBox.Show("No existe el empleado");
                }
            }
        }

        private void btnShowEmpMaySales_Click(object sender, EventArgs e)
        {
            string nombre; 
            if (company.isEmpty())
            {
                MessageBox.Show("No hay empleados");
            }
            else
            {
                nombre = company.searchEmpMaySales();
                if(nombre == "")
                {
                    MessageBox.Show("No hay nadie con mayores ventas");
                }
                else
                {
                    MessageBox.Show(nombre);
                }
            }
        }

        private void btnOrderEmpSales_Click(object sender, EventArgs e)
        {
            if (company.isEmpty())
            {
                MessageBox.Show("No hay empleados");
            }
            else
            {
                company.orderBySales();
                MessageBox.Show("Ordenado");
            }
        }
    }
}
