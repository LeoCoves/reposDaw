using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02.Models
{
    public class Profesor
    {
        // Miembros
        private string mDni, mNombre, mApellidos, mTlf, mEmail;
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
        public string eMail
        {
            get => mEmail;
            set => mEmail = value;
        }

        // Constructor
        public Profesor(string Dni, string Nombre, string Apellidos,
        string Tlf, string eMail)
        {
            mDni = Dni;
            mNombre = Nombre;
            mApellidos = Apellidos;
            mTlf = Tlf;
            mEmail = eMail;
        }


    }
}
