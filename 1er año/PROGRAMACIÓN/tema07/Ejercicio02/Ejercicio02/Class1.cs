using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    class Empleado
    {
        private string mNombre;
        private int mEdad;
        private string mNumero;
        private char mSexo;
        private bool mCasado;

        public string Nombre
        {
            get { return mNombre; }
            set { mNombre = value; }
        }

        public int Edad
        {
            get { return mEdad; }
            set
            {
                if (value > 0 && value < 100)
                {
                    mEdad = value;
                }
            }
        }

        public string Numero
        {
            get { return mNumero; }
            set
            {
                if(value.Length == 9)
                {
                    mNumero = value;
                }
            }
        }

        public char Sexo
        {
            get { return mSexo; }
            set
            {
                if(value == 'M' || value == 'F')
                {
                    mSexo = value;
                }
            }
        }

        public bool Casado
        {
            get { return mCasado; }
            set { mCasado = value; }
        }

        //Constructor
        public Empleado()
        {
            mNombre = "";
            mEdad = 0;
            mNumero = "";
            mCasado = false;
        }

        private string sexo()
        {
            string sexualidad = "El sexo es : ";
            if(mSexo == 'M')
            {
                sexualidad += "Masculino";
            }
            else
            {
                sexualidad += "Femenino";
            }
            return sexualidad;
        }

        private string estaCasado()
        {
            string estadoCivil = "Su estado civil es: ";

            if(mCasado == true)
            {
                estadoCivil += "Casado";
            }
            else
            {
                estadoCivil += "No Casado";
            }
            return estadoCivil;
        }

        public string mostrarDatos()
        {
            string text = "\n" + "Los datos del empleado: ";
            text += mNombre + "\n";
            text += "Edad: " + mEdad + "\n";
            text += "Numero de telefono: " + mNumero + "\n";
            text += "Sexo: " + sexo() + "\n";
            text += "Estado Civil: " + estaCasado();
            return text;
        }

    }
}
