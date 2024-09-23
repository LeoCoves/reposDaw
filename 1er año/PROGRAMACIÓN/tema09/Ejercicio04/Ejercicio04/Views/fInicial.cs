using Ejercicio04.Views;
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
    public partial class fInicial : Form
    {
        public fInicial()
        {
            InitializeComponent();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            fCursos fCur = new fCursos();

            // Aquí le pasamos la lista de cursos para poder utilizarla luego en el formulario de cursos.

            fCur.ShowDialog();
        }

        private void btnAlumnos_Click(object sender, EventArgs e)
        {
            fAlumnos fAlu = new fAlumnos();

            fAlu.ShowDialog();
        }

        private void btnProfesores_Click(object sender, EventArgs e)
        {
            fProfesores fProf = new fProfesores();

            fProf.ShowDialog();
        }
    }
}
