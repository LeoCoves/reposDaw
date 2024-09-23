using Ejercicio06CentroEscolar;
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

namespace Ejercicio05
{
    public partial class fProfesores : Form
    {
        public fProfesores()
        {
            InitializeComponent();
        }

        public listaCursos listaCursos;
        public listaPersonas listaPersonas;

        public fProfesores(listaCursos listaCursos, listaPersonas listaPersonas)
        {
            InitializeComponent();
            // Ponemos en la lista de cursos del formulario la lista
            // de cursos que se pasa desde el formulario inicial
            this.listaCursos = listaCursos;
            this.listaPersonas = listaPersonas;
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
                else if (listaPersonas.existDNI(DNI))
                {
                    MessageBox.Show("DNI ya introducido anteriormente");
                }
            } while (!Validacion.validarDNI(DNI) || listaPersonas.existDNI(DNI));

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
            int codigoCurso = 0;
            if (more == DialogResult.Yes)
            {
                do
                {
                    codigoCurso = int.Parse(Interaction.InputBox("Introduce el código del Curso del Tutor"));
                    if (!listaCursos.validarCurso(codigoCurso))
                    {
                        MessageBox.Show("No existe el curso introducido, vuelva a introducir los datos correctamente");
                    }
                    else
                    {
                        if (listaPersonas.comprobarSiHayTutor(codigoCurso))
                        {
                            MessageBox.Show("Ya existe un tutor de ese curso");
                        }
                        else
                        {
                            MessageBox.Show("Codigo de curso introducido");
                        }
                    }
                } while (!listaCursos.validarCurso(codigoCurso) || listaPersonas.comprobarSiHayTutor(codigoCurso));
            }
            else
            {
                MessageBox.Show("Has seleccionado que no es tutor");
            }

            string correo = Interaction.InputBox("Introduce el correo del profesor");

            listaPersonas.AddProfesor(DNI, Nombre, Telf, codigoCurso, correo);
        }

        private void bEliminarProf_Click(object sender, EventArgs e)
        {
            string DNI = Interaction.InputBox("Introduce el DNI del Profesor a eliminar");
            bool eliminado = listaPersonas.eliminarAlumno(DNI);
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
            string texto = listaPersonas.mostrarListaProfesores(out bool isEmpty);
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
            if (listaPersonas.EmptyProfesores())
            {
                MessageBox.Show("No hay profesores suficientes para ordenar alfabeticamente");
            }
            else
            {
                listaPersonas.orderProfAlf();
            }
        }

        private void bMostrarDatosProf_Click(object sender, EventArgs e)
        {
            string DNI = Interaction.InputBox("Introduzca el DNI del Profesor que quiere ver sus datos");
            string texto = listaPersonas.mostrarDatosUnProfesor(DNI, out bool exist);
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
            if (listaPersonas.existDNI(DNI))
            {
                string asignatura = Interaction.InputBox("Introduce la asignatura");
                if (listaPersonas.existeAsignatura(DNI, asignatura))
                {
                    MessageBox.Show("La asignatura ya esta introducida anteriormente");
                }
                else
                {
                    listaPersonas.addAsignatura(DNI, asignatura);
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


            if (listaPersonas.existDNI(DNI))
            {
                if (listaPersonas.comprobarSiHayAsignaturas(DNI))
                {
                    listaPersonas.deleteAsignaturasProfesor(DNI);
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

        private void bMostrarProfDeAsig_Click(object sender, EventArgs e)
        {
            string Asignatura = Interaction.InputBox("Introduce la asignatura");

            if (Asignatura != null && Asignatura.Length > 0)
            {
                string texto = listaPersonas.mostrarProfImpartenAsignatura(Asignatura);
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
