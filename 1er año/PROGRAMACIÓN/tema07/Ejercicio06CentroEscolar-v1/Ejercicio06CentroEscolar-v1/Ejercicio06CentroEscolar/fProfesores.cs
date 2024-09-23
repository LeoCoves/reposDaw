using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06CentroEscolar
{
    public partial class fProfesores : Form
    {

        public ListaCursos listaCursos;
        public ListaAlumnos listaAlumnos;
        public ListaProfesores listaProfesores;
        public fProfesores()
        {
            InitializeComponent();
        }

        private void fPofesores_Load(object sender, EventArgs e)
        {

        }

        public fProfesores(ListaCursos listaCursos, ListaAlumnos listaAlumnos, ListaProfesores listaProfesores)
        {
            InitializeComponent();
            // Ponemos en la lista de cursos del formulario la lista
            // de cursos que se pasa desde el formulario inicial
            this.listaCursos = listaCursos;
            this.listaAlumnos = listaAlumnos;
            this.listaProfesores = listaProfesores;
        }

        private void bIntroducirProf_Click(object sender, EventArgs e)
        {
            string DNI;
            do
            {
                DNI = Interaction.InputBox("Introduce el DNI del Profesor");
                if (!Validacion.validarDNI(DNI))
                {
                    MessageBox.Show("DNI inválido, vuelva a introducir los datos correctamente");
                }
                else if (listaProfesores.existDNI(DNI) || listaAlumnos.existDNI(DNI))
                {
                    MessageBox.Show("DNI ya introducido anteriormente");
                }
            } while (!Validacion.validarDNI(DNI) || listaProfesores.existDNI(DNI) || listaAlumnos.existDNI(DNI));

            string Nombre = Interaction.InputBox("Introduce el nombre del profesor");

            string Telf;
            do
            {
                Telf = Interaction.InputBox("Introduce el número de teléfono del profesor");
                if (!Validacion.validarTelf(Telf))
                {
                    MessageBox.Show("Teléfono inválido, vuelva a introducir los datos correctamente");
                }
            } while (!Validacion.validarTelf(Telf));


            DialogResult more;
            more = MessageBox.Show("Es tutor?", "tutor", MessageBoxButtons.YesNo);
            string codigoCursoTutor = "";
            string codigoCurso;
            if (more == DialogResult.Yes)
            {
                do
                {
                    codigoCurso = Interaction.InputBox("Introduce el código del Curso del Tutor");
                    if (!listaCursos.validarCurso(codigoCurso))
                    {
                        MessageBox.Show("No existe el curso introducido, vuelva a introducir los datos correctamente");
                    }
                    else
                    {
                        if (listaProfesores.comprobarSiHayTutor(codigoCurso))
                        {
                            MessageBox.Show("Ya existe un tutor de ese curso");
                        }
                        else
                        {
                            codigoCursoTutor = codigoCurso;
                            MessageBox.Show("Codigo de curso introducido");
                        }
                    }
                } while (!listaCursos.validarCurso(codigoCurso) || listaProfesores.comprobarSiHayTutor(codigoCurso));
            }
            else
            {
                MessageBox.Show("Has seleccionado que no es tutor");
            }

            listaProfesores.AddProfesor(DNI, Nombre, Telf, codigoCursoTutor);
        }


        private void bEliminarProf_Click(object sender, EventArgs e)
        {
            string DNI = Interaction.InputBox("Introduce el DNI del Profesor a eliminar");
            bool eliminado = listaAlumnos.eliminarAlumno(DNI);
            if (eliminado)
            {
                MessageBox.Show("Eliminado correctamente");
            }
            else
            {
                MessageBox.Show("No has introducido correctamente bien el DNI o no existe el Profesor");
            }
        }

        private void bMostrarListaProf_Click(object sender, EventArgs e)
        {
            string texto = listaProfesores.mostrarListaProfesores(out bool isEmpty);
            if (isEmpty)
            {
                MessageBox.Show("No hay profesores");
            }
            else
            {
                MessageBox.Show("Lista de Profesores: \n" +
                                "--------------------- \n" + texto);
            }
        }

        private void bOrdenarProfAlfabeticamente_Click(object sender, EventArgs e)
        {
            if (listaProfesores.Empty())
            {
                MessageBox.Show("No hay profesores suficientes para ordenar alfabeticamente");
            }
            else
            {
                listaProfesores.orderProfAlf();
            }
        }

        private void bMostrarDatosProf_Click(object sender, EventArgs e)
        {
            string DNI = Interaction.InputBox("Introduzca el DNI del Profesor que quiere ver sus datos");
            string texto = listaProfesores.mostrarDatosUnProfesor(DNI, out bool exist);
            if (exist)
            {
                MessageBox.Show(texto);
            }
            else
            {
                MessageBox.Show("No se encuentra el DNI, vuelva a escribirlo");
            }
        }

        private void bAnyadirAsigProf_Click(object sender, EventArgs e)
        {
            string DNI = Interaction.InputBox("Introduce el DNI del profesor el cual quieres añadir asignaturas");
            if (listaProfesores.existDNI(DNI))
            {
                string asignatura = Interaction.InputBox("Introduce la asignatura");
                if (listaProfesores.existeAsignatura(DNI, asignatura))
                {
                    MessageBox.Show("La asignatura ya esta introducida anteriormente");
                }
                else
                {
                    listaProfesores.addAsignatura(DNI, asignatura);
                }
                    /*encontrado = listaProfesores.addAsignatura(DNI, asignatura);
                if (encontrado)
                {
                    MessageBox.Show("Asignatura añadida correctamente");
                }*/
            }
            else
            {
                MessageBox.Show("DNI incorrecto, no se encuentra");
            }
        }

        private void bEliminarAsigProf_Click(object sender, EventArgs e)
        {
            string DNI;
            do
            {
                DNI = Interaction.InputBox("Introduce el DNI que quieras eliminar sus Asignaturas");
                if (!Validacion.validarDNI(DNI))
                {
                    MessageBox.Show("DNI inválido, vuelva a introducir los datos correctamente");
                }
            } while (!Validacion.validarDNI(DNI));


            if (listaProfesores.existDNI(DNI))
            {
                if (listaProfesores.comprobarSiHayAsignaturas(DNI))
                {
                    listaProfesores.deleteAsignaturasProfesor(DNI);
                    MessageBox.Show("Asignaturas borradas correctamente");
                }
                else
                {
                    MessageBox.Show("No tiene Asignaturas para eliminar");
                }
            }
            else
            {
                MessageBox.Show("No se ha encontrado el Profesor");
            }
        }

        private void bMostrarProfDeAsig_Click_1(object sender, EventArgs e)
        {
            string Asignatura = Interaction.InputBox("Introduce la asignatura");

            if (Asignatura != null && Asignatura.Length > 0)
            {
                string texto = listaProfesores.mostrarProfImpartenAsignatura(Asignatura);
                MessageBox.Show("Profesores que imparten la asignatura " + Asignatura.ToUpper() + "\n" +
                                "-------------------------------------------------- \n" + texto);
            }
            else
            {
                MessageBox.Show("No has introducido ninguna asignatura, vuelva a introducirla");
            }
        }
    }

}