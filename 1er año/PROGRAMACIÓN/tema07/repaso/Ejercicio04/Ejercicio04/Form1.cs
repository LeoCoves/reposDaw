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

        listEmployers company = new listEmployers();

        private void btnEmployer_Click(object sender, EventArgs e)
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

        private void btnShowList_Click(object sender, EventArgs e)
        {
            string texto;
            if (company.showListEmp(out texto))
            {
                
            }
            else
            {
                texto = "No hay empleados";
            }
            MessageBox.Show(texto);
        }

        private void btnBirthayEmp_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Nombre");
            company.isEmpBirthay(nombre);
        }

        private void btnAddSales_Click(object sender, EventArgs e)
        {
            string nombre = Interaction.InputBox("Nombre");
            int sales = int.Parse(Interaction.InputBox("Sales"));

            company.addSalesEmp(nombre, sales);


        }
    }
}
