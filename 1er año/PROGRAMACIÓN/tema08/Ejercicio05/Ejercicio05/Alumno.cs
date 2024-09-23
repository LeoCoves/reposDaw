using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    public class Alumno:Persona
    {
        private int mCodigoCurso;
        private List<double> mNotas;

        public int CodigoCurso
        {
            get { return mCodigoCurso; }
            set { mCodigoCurso = value;}
        }
        
        public Alumno(string dni, string nombre, string telefono, int codigoCurso) : base(dni, nombre, telefono)
        {
            mCodigoCurso = codigoCurso;
            mNotas = new List<double>();
        }

        public string mostrarNotasAlumno()
        {
            string texto = "";
            if (mNotas.Count > 0)
            {
                for (int i = 0; i < mNotas.Count; i++)
                {
                    texto += mNotas[i] + ", ";
                }
            }
            else
            {
                texto += "No hay notas almacenadas";
            }
            return texto;
        }

        public void anyadirNota(double nota)
        {
            if (nota > 0)
            {
                mNotas.Add(nota);
            }
        }

        public void eliminarNotas()
        {
            mNotas.Clear();
        }

        public double sumaNotas()
        {
            double suma = 0;
            for (int i = 0; i < mNotas.Count; i++)
            {
                suma += mNotas[i];
            }
            return suma;
        }

        public double mediaNotas()
        {
            double media = sumaNotas();
            media = media / mNotas.Count;
            return media;
        }

        public string mostrarDatosAlumno()
        {
            string texto = "\nDatos del alumno: \n";
            texto += "DNI: " + Dni + "\n";
            texto += "Nombre: " + Nombre + "\n";
            texto += "Telefono: " + Telefono + "\n";
            texto += "Notas: " + mostrarNotasAlumno() + "\n";
            texto += "Curso: " + CodigoCurso + "\n";
            return texto;
        }
    }
}
