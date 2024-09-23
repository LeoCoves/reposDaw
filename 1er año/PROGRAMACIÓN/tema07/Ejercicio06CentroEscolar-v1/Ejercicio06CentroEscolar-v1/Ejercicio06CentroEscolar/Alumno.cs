using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio06CentroEscolar
{
    public class Alumno
    {
        private string mDNI;
        private string mNombre;
        private string mTelf;
        private List<double> mNotas;
        private string mCodigoCurso;

        public string DNI
        {
            get { return mDNI; }
            set
            {
                mDNI = value;
            }
        }

        public string Nombre
        {
            get { return mNombre; }
            set { mNombre = value; }
        }

        public string Telf
        {
            get { return mTelf; }
            set {
                    mTelf = value;
                }
        }

        public string CodigoCurso
        {
            get { return mCodigoCurso;}
            set { mCodigoCurso = value; }
        }

        //Constructor

        public Alumno()
        {
            mDNI = "";
            mNombre = "";
            mTelf = "";
            mNotas = new List<double>();
            mCodigoCurso = "";
        }

        public string mostrarNotasAlumno()
        {
            string texto = "";
            if(mNotas.Count > 0)
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
            texto += "DNI: " + mDNI + "\n";
            texto += "Nombre: " + mNombre + "\n";
            texto += "Telefono: " + mTelf + "\n";
            texto += "Notas: " + mostrarNotasAlumno() + "\n";
            texto += "Curso: " + mCodigoCurso + "\n";
            return texto;
        }
    }
}
