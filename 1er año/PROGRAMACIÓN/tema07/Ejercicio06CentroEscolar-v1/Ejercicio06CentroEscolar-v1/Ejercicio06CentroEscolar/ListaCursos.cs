using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06CentroEscolar
{
    public class ListaCursos
    {
        List<Curso> mLista;

        public ListaCursos()
        {
            mLista = new List<Curso>();
        }

        public void AddCurso(string codigo, string nombre, out bool encontrado)
        {
            Curso cur = new Curso();
            encontrado = validarCurso(codigo);

            if (!encontrado)
            {
                cur.Codigo = codigo;
                cur.Nombre = nombre;
                mLista.Add(cur);
            }
        }

        private int buscarCurso(string codigo)
        {
            Curso cur;
            int pos = -1;
            bool encontrado = false;
            int i = 0;

            while (i < mLista.Count && !encontrado)
            {
                cur = mLista[i];
                if (cur.Codigo == codigo)
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

        public bool deleteCurso(string codigo)
        {
            bool encontrado = false;
            int pos = buscarCurso(codigo);

            if(pos >= 0)
            {
                mLista.RemoveAt(pos);
                encontrado = true;
            }
            return encontrado;
        }

        public string mostrarTodosLosCursos()
        {
            Curso cur;
            string texto = "Lista de los Cursos \n";

            for(int i = 0; i < mLista.Count; i++)
            {
                cur = mLista[i];
                texto += cur.mostrarDatosCurso();
            }
            return texto;
        }

        public bool validarCurso(string codigo)
        {
            Curso cur;
            bool encontrado = false;
            for(int i = 0; i < mLista.Count && !encontrado; i++)
            {
                cur = mLista[i];
                if(cur.Codigo == codigo)
                {
                    encontrado = true;
                }
            }
            return encontrado;
        }

    }
}
