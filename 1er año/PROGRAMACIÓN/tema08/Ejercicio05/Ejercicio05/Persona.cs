using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    public abstract class Persona
    {
        private string mDni;
        private string mNombre;
        private string mTelefono;

        public string Dni
        {
            get { return mDni; }
            set { mDni = value; }
        }
        public string Nombre
        {
            get { return mNombre; }
            set { mNombre = value; }
        }
        public string Telefono
        {
            get { return mTelefono; }
            set { mTelefono = value; }
        }

        public Persona(string dni, string nombre, string telefono)
        {
            mDni = dni;
            mNombre = nombre;
            mTelefono = telefono;
        }

    }
}
