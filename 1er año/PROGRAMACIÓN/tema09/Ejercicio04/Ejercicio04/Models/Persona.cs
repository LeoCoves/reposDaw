using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04.Models
{
    public abstract class Persona
    {
        // Miembros
        private string mDni, mNombre, mApellidos, mTlf;
        // Propiedades
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
        // Otra posible forma de hacer la propiedad
        public string Apellidos
        {
            get => mApellidos;
            set => mApellidos = value;
        }
        public string Tlf
        {
            get => mTlf;
            set => mTlf = value;
        }

        // Constructor
        public Persona(string Dni, string Nombre, string Apellidos,
        string Tlf)
        {
            mDni = Dni;
            mNombre = Nombre;
            mApellidos = Apellidos;
            mTlf = Tlf;
        }
    }
}
