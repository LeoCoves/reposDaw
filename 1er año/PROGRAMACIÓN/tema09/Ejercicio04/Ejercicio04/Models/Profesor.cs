using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04.Models
{
    public class Profesor:Persona
    {
        //Miembros
        private string mEmail;

        public string Email
        {
            get => mEmail;
            set => mEmail = value;
        }

        // Constructor
        public Profesor(string Dni, string Nombre, string Apellidos,
        string Tlf, string Email):base(Dni, Nombre, Apellidos, Tlf)
        {
            mEmail = Email;
        }


    }
}
