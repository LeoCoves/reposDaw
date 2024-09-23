using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    public class listaPersonas
    {
        private List<Persona> mListaPersonas;
        private List<Persona> mListaAlumnos;
        private List<Persona> mListaProfesores;

        public listaPersonas()
        {
            mListaPersonas = new List<Persona>();
            mListaAlumnos = new List<Persona>();
            mListaProfesores = new List<Persona>();
        }

        //Alumnos
        public void AddAlumno(string dni, string nombre, string telefono, int codCurso)
        {
            Alumno alu = new Alumno(dni, nombre, telefono, codCurso);
            mListaPersonas.Add(alu);
            mListaAlumnos.Add(alu);
        }

        private int buscarPersona(string DNI)
        {
            Persona per;
            int pos = -1;
            bool encontrado = false;
            int i = 0;

            while (i < mListaPersonas.Count && !encontrado)
            {
                per = (Persona)mListaPersonas[i];
                if (per.Dni == DNI)
                {
                    pos = i;
                    encontrado = true;
                }
                else
                {
                    i++;
                }
            }
            return pos;
        }

        private int buscarAlumno(string DNI)
        {
            Alumno alu;
            int pos = -1;
            bool encontrado = false;
            int i = 0;

            while (i < mListaAlumnos.Count && !encontrado)
            {
                alu = (Alumno)mListaAlumnos[i];
                if (alu.Dni == DNI)
                {
                    pos = i;
                    encontrado = true;
                }
                else
                {
                    i++;
                }
            }
            return pos;
        }

        public bool eliminarAlumno(string DNI)
        {
            bool encontrado = false;
            int pos = buscarAlumno(DNI);

            if (pos >= 0)
            {
                mListaAlumnos.RemoveAt(pos);
                encontrado = true;
            }
            pos = buscarPersona(DNI);
            mListaPersonas.RemoveAt(pos);
            return encontrado;
        }

        public string mostrarListaAlumnos(out bool isEmpty)
        {
            string texto = "";
            Alumno alu;
            isEmpty = false;

            for (int i = 0; i < mListaAlumnos.Count; i++)
            {
                alu = (Alumno)mListaAlumnos[i];
                texto += alu.mostrarDatosAlumno() + "\n";
            }
            if (texto == "")
            {
                isEmpty = true;
            }
            return texto;
        }


        public string mostrarAlumnosCurso(int codigo, out bool isEmpty)
        {
            string texto = "";
            Alumno alu;
            isEmpty = false;

            for (int i = 0; i < mListaAlumnos.Count; i++)
            {
                alu = (Alumno)mListaAlumnos[i];
                if (alu.CodigoCurso == codigo)
                {
                    texto += alu.Dni + " - " + alu.Nombre + ",\n";
                }
            }
            if (texto == "")
            {
                isEmpty = true;
            }
            return texto;
        }

        public bool EmptyAlumnos()
        {
            bool isEmpty = true;
            isEmpty = true;
            if (mListaAlumnos.Count > 1)
            {
                isEmpty = false;
            }
            return isEmpty;
        }


        public bool existDNI(string DNI)
        {
            bool exist = false;
            int pos = buscarPersona(DNI);
            if (pos >= 0)
            {
                exist = true;
            }
            return exist;
        }

        public void orderAluAlf()
        {
            Alumno aux;

            for (int i = 0; i < mListaAlumnos.Count; i++)
            {
                for (int j = i + 1; j < mListaAlumnos.Count; j++)
                {
                    if (string.Compare(mListaAlumnos[i].Nombre, mListaAlumnos[j].Nombre) >= 0)
                    {
                        aux = (Alumno)mListaAlumnos[i];
                        mListaAlumnos[i] = mListaAlumnos[j];
                        mListaAlumnos[j] = aux;
                    }
                }
            }
        }

        public string mostrarDatosUnAlumno(string DNI, out bool exist)
        {
            string texto = "";
            Alumno alu;
            exist = false;

            for (int i = 0; i < mListaAlumnos.Count; i++)
            {
                alu = (Alumno)mListaAlumnos[i];
                if (alu.Dni == DNI)
                {
                    texto += alu.mostrarDatosAlumno();
                    exist = true;
                }
            }
            return texto;
        }

        public bool addNotas(string DNI, double nota)
        {
            Alumno alu;
            int pos = buscarAlumno(DNI);
            bool encontrado = false;

            if (pos >= 0)
            {
                alu = (Alumno)mListaAlumnos[pos];
                alu.anyadirNota(nota);
                encontrado = true;
            }
            return encontrado;
        }

        public void deleteNotasAlumno(string DNI)
        {
            Alumno alu;
            int pos = buscarAlumno(DNI);

            if (pos >= 0)
            {
                alu = (Alumno)mListaAlumnos[pos];
                alu.eliminarNotas();
            }
        }

        public bool comprobarSiHayNotas(string DNI)
        {
            Alumno alu;
            int pos = buscarAlumno(DNI);
            bool encontrado = true;

            if (pos >= 0)
            {
                alu = (Alumno)mListaAlumnos[pos];
                if (alu.sumaNotas() == 0)
                {
                    encontrado = false;
                }
            }
            return encontrado;
        }

        public string mostrarAluNotaMayMedia(out bool empty)
        {
            Alumno alu;
            string texto = "";
            empty = false;

            for (int i = 0; i < mListaAlumnos.Count; i++)
            {
                alu = (Alumno)mListaAlumnos[i];
                if (alu.mediaNotas() >= 5)
                {
                    texto += alu.Nombre + ", \n";
                }
            }
            if (texto == "")
            {
                empty = true;
            }
            return texto;
        }

        public string mostrarAluNotaMenMedia(out bool empty)
        {
            Alumno alu;
            string texto = "";
            empty = false;

            for (int i = 0; i < mListaAlumnos.Count; i++)
            {
                alu = (Alumno)mListaAlumnos[i];
                if (alu.mediaNotas() < 5)
                {
                    texto += alu.Nombre + ", \n";
                }
            }
            if (texto == "")
            {
                empty = true;
            }
            return texto;
        }

        //Profesor

        public void AddProfesor(string DNI, string Nombre, string Telf, int codigoCurso, string correo)
        {
            Profesor prof = new Profesor(DNI, Nombre, Telf, codigoCurso, correo);
            mListaPersonas.Add(prof);
            mListaProfesores.Add(prof);
        }

        public bool comprobarSiHayTutor(int codigoCurso)
        {
            bool tutor = false;
            Profesor prof;

            for (int i = 0; i < mListaProfesores.Count; i++)
            {
                prof = (Profesor)mListaProfesores[i];
                if (prof.CodigoCursoTutor == codigoCurso)
                {
                    tutor = true;
                }
            }
            return tutor;
        }

        private int buscarProfesor(string DNI)
        {
            Profesor prof;
            int pos = -1;
            bool encontrado = false;
            int i = 0;

            while (i < mListaProfesores.Count && !encontrado)
            {
                prof = (Profesor)mListaProfesores[i];
                if (prof.Dni == DNI)
                {
                    pos = i;
                    encontrado = true;
                }
                else
                {
                    i++;
                }
            }
            return pos;
        }

        public bool eliminarProfesor(string DNI)
        {
            bool encontrado = false;
            int pos = buscarProfesor(DNI);

            if (pos >= 0)
            {
                mListaProfesores.RemoveAt(pos);
                encontrado = true;
            }
            pos = buscarPersona(DNI);
            mListaPersonas.RemoveAt(pos);
            return encontrado;
        }

        public string mostrarListaProfesores(out bool isEmpty)
        {
            string texto = "";
            Profesor prof;
            isEmpty = false;

            for (int i = 0; i < mListaProfesores.Count; i++)
            {
                prof = (Profesor)mListaProfesores[i];
                texto += prof.mostrarDatosProfesor() + "\n";
            }
            if (texto == "")
            {
                isEmpty = true;
            }
            return texto;
        }

        public bool EmptyProfesores()
        {
            bool isEmpty = true;
            isEmpty = true;
            if (mListaProfesores.Count > 1)
            {
                isEmpty = false;
            }
            return isEmpty;
        }

        public void orderProfAlf()
        {
            Profesor aux;

            for (int i = 0; i < mListaProfesores.Count; i++)
            {
                for (int j = i + 1; j < mListaProfesores.Count; j++)
                {
                    if (string.Compare(mListaProfesores[i].Nombre, mListaProfesores[j].Nombre) >= 0)
                    {
                        aux = (Profesor)mListaProfesores[i];
                        mListaProfesores[i] = mListaProfesores[j];
                        mListaProfesores[j] = aux;
                    }
                }
            }
        }

        public string mostrarDatosUnProfesor(string DNI, out bool exist)
        {
            string texto = "";
            Profesor prof;
            exist = false;

            for (int i = 0; i < mListaProfesores.Count; i++)
            {
                prof = (Profesor)mListaProfesores[i];
                if (prof.Dni == DNI)
                {
                    texto += prof.mostrarDatosProfesor();
                    exist = true;
                }
            }
            return texto;
        }

        public bool addAsignatura(string DNI, string asignatura)
        {
            Profesor prof;
            int pos = buscarProfesor(DNI);
            bool encontrado = false;

            if (pos >= 0)
            {
                prof = (Profesor)mListaProfesores[pos];
                prof.anyadirAsignatura(asignatura);
                encontrado = true;
            }
            return encontrado;
        }
        public bool comprobarSiHayAsignaturas(string DNI)
        {
            Profesor prof;
            int pos = buscarProfesor(DNI);
            bool encontrado = true;

            if (pos >= 0)
            {
                prof = (Profesor)mListaProfesores[pos];
                if (prof.sinAsignaturas())
                {
                    encontrado = false;
                }
            }
            return encontrado;
        }

        public void deleteAsignaturasProfesor(string DNI)
        {
            Profesor prof;
            int pos = buscarProfesor(DNI);

            if (pos >= 0)
            {
                prof = (Profesor)mListaProfesores[pos];
                prof.eliminarAsignaturas();
            }
        }

        public string mostrarProfImpartenAsignatura(string Asignatura)
        {
            string texto = "";
            Profesor prof;

            for (int i = 0; i < mListaProfesores.Count; i++)
            {
                prof = (Profesor)mListaProfesores[i];
                if (prof.buscarAsignatura(Asignatura))
                {
                    texto += prof.Nombre + ", \n";
                }
            }
            if (texto == "")
            {
                texto += "Esa Asignatura no la imparte nadie o no existe";
            }
            return texto;
        }

        public bool existeAsignatura(string DNI, string Asignatura)
        {
            int pos = buscarProfesor(DNI);
            bool existe = false;
            Profesor prof;
            prof = (Profesor)mListaProfesores[pos];
            if (prof.buscarAsignatura(Asignatura))
            {
                existe = true;
            }
            return existe;
        }

    }
}
