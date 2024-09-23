using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06CentroEscolar
{
    public class Curso
    {
        private string mCodigo;
        private string mNombre;

        public string Codigo
        {
            get { return mCodigo; }
            set { mCodigo = value; }
        }

        public string Nombre
        {
            get { return mNombre; }
            set { mNombre = value; }
        }

        //Constructor

        public Curso()
        {
            Codigo = "";
            Nombre = "";
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
