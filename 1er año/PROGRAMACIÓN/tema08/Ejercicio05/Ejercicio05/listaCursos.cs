using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    public class listaCursos
    {
        private List<Curso> mLista;

        public listaCursos()
        {
            mLista = new List<Curso>();
        }

        public void AddCurso(int codigo, string nombre, out bool encontrado)
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

        private int buscarCurso(int codigo)
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

        public bool deleteCurso(int codigo)
        {
            bool encontrado = false;
            int pos = buscarCurso(codigo);

            if (pos >= 0)
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

            for (int i = 0; i < mLista.Count; i++)
            {
                cur = mLista[i];
                texto += cur.mostrarDatosCurso();
            }
            return texto;
        }

        public bool validarCurso(int codigo)
        {
            Curso cur;
            bool encontrado = false;
            for (int i = 0; i < mLista.Count && !encontrado; i++)
            {
                cur = mLista[i];
                if (cur.Codigo == codigo)
                {
                    encontrado = true;
                }
            }
            return encontrado;
        }
    }
}
