using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06CentroEscolar
{
    internal class Profesor
    {
        private string mDNI;
        private string mNombre;
        private string mTelf;
        private List<string> mAsignaturas;
        private string mCodigoCurso;

        public string DNI
        {
            get { return mDNI; }
            set { mDNI = value; }
        }

        public string Nombre
        {
            get { return mNombre; }
            set { mNombre = value; }
        }

        public string Telf
        {
            get { return mTelf; }
            set { mTelf = value; }
        }

        public string CodigoCurso
        {
            get { return mCodigoCurso;}
            set
            {
                mCodigoCurso = value;
            }
        }

        public Profesor()
        {
            mDNI = "";
            mNombre = "";
            mTelf = "";
            mAsignaturas = new List<string>();
            mCodigoCurso = "";
        }

        private string mostrarAsignaturasImpartidas()
        {
            string texto = "";

            if(mAsignaturas.Count > 0)
            {
                for (int i = 0; i < mAsignaturas.Count; i++)
                {
                    texto += mAsignaturas[i] + ", ";
                }
            }
            else
            {
                texto += "No hay Asignaturas almacenadas";
            }
            return texto;
        }

        public string mostrarDatosProfesor()
        {
            string texto = "\nDatos del Profesor: \n";
            texto += "DNI: " + mDNI + "\n";
            texto += "Nombre: " + mNombre + "\n";
            texto += "Telefono: " + mTelf + "\n";
            texto += "Notas: " + mostrarAsignaturasImpartidas() + "\n";
            if(mCodigoCurso != "")
            {
                texto += "Codigo Curso el cual tutoriza: " + mCodigoCurso + "\n";
            }
            else
            {
                texto += "No es tutor";
            }
            return texto;
        }
        public void anyadirAsignatura(string asignatura)
        {
            mAsignaturas.Add(asignatura);
        }

        public bool sinAsignaturas()
        {
            string texto = mostrarAsignaturasImpartidas();
            bool vacio = false;

            if(texto == "No hay Asignaturas almacenadas")
            {
                vacio = true;
            }
            return vacio;
        }

        public void eliminarAsignaturas()
        {
            mAsignaturas.Clear();
        }

        public bool buscarAsignatura(string Asignatura)
        {
            bool encontrado = false;
            
            for(int i = 0; i < mAsignaturas.Count; i++)
            {
                if (string.Equals(mAsignaturas[i], Asignatura, StringComparison.OrdinalIgnoreCase))
                {
                    encontrado = true;
                }
            }
            return encontrado;
        }
    }
}
