using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    public class Curso
    {
        private int mCodigo;
        private string mNombre;

        public int Codigo
        {
            get { return mCodigo; } 
            set { mCodigo = value; }
        }

        public string Nombre
        {
            get { return mNombre; }
            set { mNombre = value; }
        }

        public Curso()
        {
            mCodigo = 0;
            mNombre = "";
        }

        public string mostrarDatosCurso()
        {
            string texto = "\n" + "Datos del curso \n";
            texto += "Codigo: " + mCodigo + "\n";
            texto += "Nombre: " + mNombre + "\n";
            return texto;
        }

    }
}
