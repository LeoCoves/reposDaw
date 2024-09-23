using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Ejercicio04.Models
{
    public class Alumno:Persona
    {

        private string mEmail, mDireccion;
        // Propiedades

        public string Email
        {
            get => mEmail;
            set => mEmail = value;
        }

        public string Direccion
        {
            get => mDireccion;
            set => mDireccion = value;
        }


        // Constructor
        public Alumno(string Dni, string Nombre, string Apellidos, string Tlf, string Email, string Direccion):base(Dni, Nombre, Apellidos, Tlf)
        {
            mEmail = Email;
            mDireccion = Direccion;
        }
    }
}
