using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06CentroEscolar
{
    public class ListaProfesores
    {
        List<Profesor> mLista;

        public ListaProfesores()
        {
            mLista = new List<Profesor>();
        }

        public void AddProfesor(string DNI, string Nombre, string Telf, string codigoCurso)
        {
            Profesor prof = new Profesor();
            prof.DNI = DNI;
            prof.Nombre = Nombre;
            prof.Telf = Telf;
            prof.CodigoCurso = codigoCurso;
            mLista.Add(prof);
        }

        public bool comprobarSiHayTutor(string codigoCurso)
        {
            bool tutor = false;
            Profesor prof;

            for(int i = 0; i < mLista.Count; i++)
            {
                prof = mLista[i];
                if(prof.CodigoCurso == codigoCurso)
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

            while (i < mLista.Count && !encontrado)
            {
                prof = mLista[i];
                if (prof.DNI == DNI)
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
        public bool existDNI(string DNI)
        {
            bool exist = false;
            int pos = buscarProfesor(DNI);
            if (pos >= 0)
            {
                exist = true;
            }
            return exist;
        }

        public bool eliminarProfesor(string DNI)
        {
            bool encontrado = false;
            int pos = buscarProfesor(DNI);

            if (pos >= 0)
            {
                mLista.RemoveAt(pos);
                encontrado = true;
            }
            return encontrado;
        }

        public string mostrarListaProfesores(out bool isEmpty)
        {
            string texto = "";
            Profesor prof;
            isEmpty = false;

            for (int i = 0; i < mLista.Count; i++)
            {
                prof = mLista[i];
                texto += prof.mostrarDatosProfesor() + "\n";
            }
            if (texto == "")
            {
                isEmpty = true;
            }
            return texto;
        }

        public bool Empty()
        {
            bool isEmpty = true;
            isEmpty = true;
            if (mLista.Count > 1)
            {
                isEmpty = false;
            }
            return isEmpty;
        }

        public void orderProfAlf()
        {
            Profesor aux;

            for (int i = 0; i < mLista.Count; i++)
            {
                for (int j = i + 1; j < mLista.Count; j++)
                {
                    if (string.Compare(mLista[i].Nombre, mLista[j].Nombre) >= 0)
                    {
                        aux = mLista[i];
                        mLista[i] = mLista[j];
                        mLista[j] = aux;
                    }
                }
            }
        }

        public string mostrarDatosUnProfesor(string DNI, out bool exist)
        {
            string texto = "";
            Profesor prof;
            exist = false;

            for (int i = 0; i < mLista.Count; i++)
            {
                prof = mLista[i];
                if (prof.DNI == DNI)
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
                prof = mLista[pos];
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
                prof = mLista[pos];
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
                prof = mLista[pos];
                prof.eliminarAsignaturas();
            }
        }

        public string mostrarProfImpartenAsignatura(string Asignatura)
        {
            string texto = "";
            Profesor prof;

            for(int i = 0; i <  mLista.Count; i++)
            {
                prof = mLista[i];
                if (prof.buscarAsignatura(Asignatura))
                {
                    texto += prof.Nombre + ", \n";
                }
            }
            if(texto == "")
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
            prof = mLista[pos];
            if (prof.buscarAsignatura(Asignatura))
            {
                existe = true;
            }
            return existe;
        }

    }
}
