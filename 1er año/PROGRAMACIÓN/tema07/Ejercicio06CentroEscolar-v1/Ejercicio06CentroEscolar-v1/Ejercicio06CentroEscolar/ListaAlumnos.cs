using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06CentroEscolar
{
    public class ListaAlumnos
    {
        List<Alumno> mLista;

        public ListaAlumnos()
        {
            mLista = new List<Alumno>();
        }

        public void AddAlumno(string DNI, string Nombre, string Telf, string codigoCurso)
        {
            Alumno alu = new Alumno();
            alu.DNI = DNI;
            alu.Nombre = Nombre;
            alu.Telf = Telf;
            alu.CodigoCurso = codigoCurso;
            mLista.Add(alu);
        }

        private int buscarAlumno(string DNI)
        {
            Alumno alu;
            int pos = -1;
            bool encontrado = false;
            int i = 0;

            while (i < mLista.Count && !encontrado)
            {
                alu = mLista[i];
                if (alu.DNI == DNI)
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
                mLista.RemoveAt(pos);
                encontrado = true;
            }
            return encontrado;
        }

        public string mostrarListaAlumnos(out bool isEmpty)
        {
            string texto = "";
            Alumno alu;
            isEmpty = false;

            for(int i = 0;  i < mLista.Count; i++)
            {
                alu = mLista[i];
                texto += alu.mostrarDatosAlumno() + "\n";
            }
            if (texto == "")
            {
                isEmpty = true;
            }
            return texto;
        }


        public string mostrarAlumnosCurso(string codigo, out bool isEmpty)
        {
            string texto = "";
            Alumno alu;
            isEmpty = false;

            for (int i = 0; i < mLista.Count; i++)
            {
                alu = mLista[i];
                if(alu.CodigoCurso == codigo)
                {
                    texto += alu.DNI + " - " + alu.Nombre + ",\n";
                }
            }
            if(texto == "")
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

        public bool existDNI(string DNI)
        {
            bool exist = false;
            int pos = buscarAlumno(DNI);
            if(pos >= 0)
            {
                exist = true;
            }
            return exist;
        }

        public void orderAluAlf()
        {
            Alumno aux;

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

        public string mostrarDatosUnAlumno(string DNI, out bool exist)
        {
            string texto = "";
            Alumno alu;
            exist = false;

            for(int i = 0; i < mLista.Count; i++)
            {
                alu = mLista[i];
                if (alu.DNI == DNI)
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
                alu = mLista[pos];
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
                alu = mLista[pos];
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
                alu = mLista[pos];
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

            for (int i = 0; i < mLista.Count; i++)
            {
                alu = mLista[i];
                if(alu.mediaNotas() >= 5)
                {
                    texto += alu.Nombre + ", \n";
                }
            }
            if(texto == "")
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

            for (int i = 0; i < mLista.Count; i++)
            {
                alu = mLista[i];
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


    }
}
