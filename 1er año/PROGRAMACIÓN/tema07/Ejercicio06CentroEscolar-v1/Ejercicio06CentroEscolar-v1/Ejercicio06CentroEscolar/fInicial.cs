using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio06CentroEscolar
{
    public partial class fInicial : Form
    {
        public fInicial()
        {
            InitializeComponent();
        }

        // Creamos la lista de cursos.
        ListaCursos listaCursos = new ListaCursos();
        ListaAlumnos listaAlumnos = new ListaAlumnos();
        ListaProfesores listaProfesores = new ListaProfesores();

        // Crear aquí también la lista de profesores y de alumnos.

        private void bCursos_Click(object sender, EventArgs e)
        {
            fCursos fCur = new fCursos(listaCursos, listaAlumnos, listaProfesores);
            
            // Aquí le pasamos la lista de cursos para poder utilizarla luego en el formulario de cursos.
            
            fCur.ShowDialog();
        }


        private void bAlumnos_Click(object sender, EventArgs e)
        {
            fAlumnos fAlu = new fAlumnos(listaCursos, listaAlumnos, listaProfesores);

            fAlu.ShowDialog();
        }

        private void bProfesores_Click(object sender, EventArgs e)
        {
            fProfesores fProf = new fProfesores(listaCursos, listaAlumnos, listaProfesores);

            fProf.ShowDialog();
        }

        private void fInicial_Load(object sender, EventArgs e)
        {

        }
    }
}
