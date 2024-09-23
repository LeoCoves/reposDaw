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
using Microsoft.VisualBasic.Logging;

namespace Ejercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Persona pers = new Persona();

        void pedirDatos()
        {
            pers.Nombre = Interaction.InputBox("Introduce el nombre: ");
            pers.Edad = int.Parse(Interaction.InputBox("Introduce la edad: "));

            do
            {
                pers.Numero = Interaction.InputBox("Introduce el numero de telefono");
            } while (pers.Numero.Length != 9);
            do
            {
                pers.Sexo = char.Parse(Interaction.InputBox("Introduce el sexo: "));
            } while (pers.Sexo != 'M' && pers.Sexo != 'F');

            DialogResult estadoCivil;
            estadoCivil = MessageBox.Show("Esta casado?", "casado", MessageBoxButtons.YesNo);

            if (estadoCivil == DialogResult.Yes)
            {
                pers.Casado = true;
            }
            else
            {
                pers.Casado = false;
            }
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            pedirDatos();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(pers.mostrarDatos());
        }
    }
}
