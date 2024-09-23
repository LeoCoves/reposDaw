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

namespace Ejercicio05
{
    public partial class fCursos : Form
    {
        public fCursos()
        {
            InitializeComponent();
        }

        public listaCursos listaCursos;
        public listaPersonas listaPersonas;

        public fCursos(listaCursos listaCursos, listaPersonas listaPersonas)
        {
            InitializeComponent();
            // Ponemos en la lista de cursos del formulario la lista
            // de cursos que se pasa desde el formulario inicial
            this.listaCursos = listaCursos;
            this.listaPersonas = listaPersonas;
        }

        private void btnAñadirCurso_Click(object sender, EventArgs e)
        {
            int codigoCurso = int.Parse(Interaction.InputBox("Introduce el codigo del Curso"));
            string nombreCurso = Interaction.InputBox("Introduce el nombre del Curso");
            listaCursos.AddCurso(codigoCurso, nombreCurso.ToUpper(), out bool encontrado);
            if (encontrado)
            {
                MessageBox.Show("Has introducido un curso que ya existe");
            }
        }

        private void btnEliminarCurso_Click(object sender, EventArgs e)
        {
            int codigoCurso = int.Parse(Interaction.InputBox("Introduce el codigo del Curso para eliminar"));
            bool encontrado = listaCursos.deleteCurso(codigoCurso);
            if (encontrado)
            {
                MessageBox.Show("Eliminado correctamente");
            }
            else
            {
                MessageBox.Show("El codigo introducido no existe");
            }
        }

        private void btnMostrarCursos_Click(object sender, EventArgs e)
        {
            string texto = listaCursos.mostrarTodosLosCursos();
            MessageBox.Show(texto);
        }

        private void btnMostrarAlumnosDelCurso_Click(object sender, EventArgs e)
        {
            int codigoCurso = int.Parse(Interaction.InputBox("Introduce el codigo del Curso"));
            bool validarCurso = listaCursos.validarCurso(codigoCurso);
            if (validarCurso)
            {
                string texto = listaPersonas.mostrarAlumnosCurso(codigoCurso, out bool isEmpty);
                if (isEmpty)
                {
                    MessageBox.Show("No hay alumnos en este curso");
                }
                else
                {
                    MessageBox.Show(texto);
                }
            }
            else
            {
                MessageBox.Show("No existe el curso introducido");
            }
        }
    }
}
