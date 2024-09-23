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
    public partial class fAlumnos : Form
    {
        public fAlumnos()
        {
            InitializeComponent();
        }

        public listaCursos listaCursos;
        public listaPersonas listaPersonas;

        public fAlumnos(listaCursos listaCursos, listaPersonas listaPersonas)
        {
            InitializeComponent();
            // Ponemos en la lista de cursos del formulario la lista
            // de cursos que se pasa desde el formulario inicial
            this.listaCursos = listaCursos;
            this.listaPersonas = listaPersonas;
        }

        private void bIntroducirAlumno_Click(object sender, EventArgs e)
        {
            string DNI;
            do
            {
                DNI = Interaction.InputBox("Introduce el DNI del alumno");
                if (!Validacion.validarDNI(DNI))
                {
                    MessageBox.Show("DNI inválido, vuelva a introducir los datos correctamente");
                }
                if (listaPersonas.existDNI(DNI))
                {
                    MessageBox.Show("DNI ya introducido anteriormente");
                }
            } while (!Validacion.validarDNI(DNI) || listaPersonas.existDNI(DNI));

            string Nombre = Interaction.InputBox("Introduce el Nombre del alumno");

            string Telf;
            do
            {
                Telf = Interaction.InputBox("Introduce el número de teléfono del alumno");
                if (!Validacion.validarTelf(Telf))
                {
                    MessageBox.Show("Teléfono inválido, vuelva a introducir los datos correctamente");
                }
            } while (!Validacion.validarTelf(Telf));

            int codigoCurso;
            do
            {
                codigoCurso = int.Parse(Interaction.InputBox("Introduce el código del Curso del alumno"));
                if (!listaCursos.validarCurso(codigoCurso))
                {
                    MessageBox.Show("No existe el curso introducido, vuelva a introducir los datos correctamente");
                }
            } while (!listaCursos.validarCurso(codigoCurso));

            listaPersonas.AddAlumno(DNI, Nombre, Telf, codigoCurso);
        }

        private void bEliminarAlumno_Click(object sender, EventArgs e)
        {
            string DNI = Interaction.InputBox("Introduce el DNI del Alumno a eliminar");
            bool eliminado = listaPersonas.eliminarAlumno(DNI);
            if (eliminado)
            {
                MessageBox.Show("Eliminado correctamente");
            }
            else
            {
                MessageBox.Show("No has introducido correctamente bien el DNI o no existe el Alumno");
            }
        }

        private void bMostrarListaAlumnos_Click(object sender, EventArgs e)
        {
            string texto = listaPersonas.mostrarListaAlumnos(out bool isEmpty);
            if (isEmpty)
            {
                MessageBox.Show("No hay alumnos");
            }
            else
            {
                MessageBox.Show("Lista de alumnos: \n" +
                                "-----------------" + texto);
            }
        }

        private void bOrdenarAlumnosAlfabeticamente_Click(object sender, EventArgs e)
        {
            listaPersonas.orderAluAlf();
            if (listaPersonas.EmptyAlumnos())
            {
                MessageBox.Show("No hay alumnos suficientes para ordenar alfabeticamente");
            }
        }

        private void bMostrarDatosAlumno_Click(object sender, EventArgs e)
        {
            string DNI = Interaction.InputBox("Introduzca el DNI del alumno que quiere ver sus datos");
            string texto = listaPersonas.mostrarDatosUnAlumno(DNI, out bool exist);
            if (exist)
            {
                MessageBox.Show(texto);
            }
            else
            {
                MessageBox.Show("No se encuentra el DNI, vuelva a escribirlo");
            }
        }

        private void bMostrarAlumnosDeCurso_Click(object sender, EventArgs e)
        {
            int codigoCurso = int.Parse(Interaction.InputBox("Introduce el codigo del curso el cual quieres ver los alumnos que hay"));
            string texto = listaPersonas.mostrarAlumnosCurso(codigoCurso, out bool isEmpty);
            bool validarCurso = listaCursos.validarCurso(codigoCurso);

            if (validarCurso)
            {
                if (isEmpty)
                {
                    MessageBox.Show("No hay alumnos");
                }
                else
                {
                    MessageBox.Show("Alumnos del Curso: \n" +
                                    "------------------ \n" + texto);
                }
            }
            else
            {
                MessageBox.Show("No existe el curso introducido");
            }
        }

        private void bAñadirNotasAlumno_Click(object sender, EventArgs e)
        {
            double nota;
            bool encontrado;

            string DNI;
            do
            {
                DNI = Interaction.InputBox("Introduce el DNI del alumno que quieres introducir notas");
                if (!Validacion.validarDNI(DNI))
                {
                    MessageBox.Show("DNI inválido, vuelva a introducir los datos correctamente");
                }
            } while (!Validacion.validarDNI(DNI));
            do
            {
                nota = double.Parse(Interaction.InputBox("Introduce una nota"));
                if (!Validacion.validarNota(nota))
                {
                    MessageBox.Show("Nota inválida, vuelva a introducir los datos correctamente\n " +
                                    "(Maximo dos decimales / Numero entero de 0 a 10)");
                }

            } while (!Validacion.validarNota(nota));

            encontrado = listaPersonas.addNotas(DNI, nota);
            if (encontrado)
            {
                MessageBox.Show("Nota añadida correctamente");
            }
            else
            {
                MessageBox.Show("No se encuentra al Alumno, introduzca el DNI de nuevo");
            }
        }

        private void bEliminarNotasAlumno_Click(object sender, EventArgs e)
        {
            string DNI;
            do
            {
                DNI = Interaction.InputBox("Introduce el DNI que quieras eliminar sus notas");
                if (!Validacion.validarDNI(DNI))
                {
                    MessageBox.Show("DNI inválido, vuelva a introducir los datos correctamente");
                }
            } while (!Validacion.validarDNI(DNI));


            if (listaPersonas.existDNI(DNI))
            {
                if (listaPersonas.comprobarSiHayNotas(DNI))
                {
                    listaPersonas.deleteNotasAlumno(DNI);
                    MessageBox.Show("Notas borradas correctamente");
                }
                else
                {
                    MessageBox.Show("No tiene notas para eliminar");
                }
            }
            else
            {
                MessageBox.Show("No se ha encontrado el Alumno");
            }
        }

        private void bMostrarAluNotaMediaMayor5_Click(object sender, EventArgs e)
        {
            string texto = listaPersonas.mostrarAluNotaMayMedia(out bool empty);
            if (empty)
            {
                MessageBox.Show("No hay alumnos con Notas ni Notas Medias");
            }
            else
            {
                MessageBox.Show("Alumnos con Media mayor o igual a 5: \n " +
                                "------------------------------------ \n " + texto);
            }
        }

        private void bMostrarAluNotaMediaMenor5_Click(object sender, EventArgs e)
        {
            string texto = listaPersonas.mostrarAluNotaMenMedia(out bool empty);
            if (empty)
            {
                MessageBox.Show("No hay alumnos con Notas ni Notas Medias");
            }
            else
            {
                MessageBox.Show("Alumnos con Media menor a 5: \n " +
                                "---------------------------- \n " + texto);
            }
        }
    }
}
