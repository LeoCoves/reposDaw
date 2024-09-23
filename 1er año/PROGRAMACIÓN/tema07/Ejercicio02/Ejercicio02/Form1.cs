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

namespace Ejercicio02
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Empleado> listEmp = new List<Empleado>();

        void pedirDatos(List<Empleado> listEmp)
        {
            Empleado emp = new Empleado();

            emp.Nombre = Interaction.InputBox("Introduce un nombre: ");
            emp.Edad = int.Parse(Interaction.InputBox("Introduce la edad: "));

            do
            {
                emp.Numero = Interaction.InputBox("Introduce un numero: ");
            } while (emp.Numero.Length != 9);

            do
            {
                emp.Sexo = char.Parse(Interaction.InputBox("Introduce su sexo: "));
            } while (emp.Sexo == 'M' && emp.Sexo == 'F');

            DialogResult estadoCivil;
            estadoCivil = MessageBox.Show("Estas casado?", "casado", MessageBoxButtons.YesNo);

            if (estadoCivil == DialogResult.Yes)
            {
                emp.Casado = true;
            }
            else
            {
                emp.Casado = false;
            }

            listEmp.Add(emp);
        }

        string showEmpleados(List<Empleado> listEmp)
        {
            string text = "";
            Empleado emp;

            for(int i = 0; i < listEmp.Count; i++)
            {
                emp = listEmp[i];
                text += emp.mostrarDatos() + "\n";
            }
            return text;
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            pedirDatos(listEmp);
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            
            MessageBox.Show(showEmpleados(listEmp));
        }
    }
}
