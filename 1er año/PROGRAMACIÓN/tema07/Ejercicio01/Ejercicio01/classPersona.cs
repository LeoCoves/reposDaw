using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio01
{
    class Persona
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
                if(value > 0 && value < 110)
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
                if (value == 'M' || value == 'F')
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

        public Persona()
        {
            mNombre = "";
            mEdad = 0;
            mNumero = "";
            mCasado = false;
        }

        private string sexo()
        {
            string sexo = "Sexo de la persona: ";

            if (mSexo == 'M')
            {
                sexo += "Masculino";
            }
            else
            {
                sexo += "Femenino";
            }
            return sexo;
        }

        private string estaCasado()
        {
            string texto = "Estado cvil: ";

            if (mCasado)
            {
                texto += "Casado";
            }
            else
            {
                texto += "No casado";
            }
            return texto;
        }

        public string mostrarDatos()
        {
            string text = "Los datos de la persona: \n";
            text += "El nombre es : " + mNombre + "\n";
            text += "La edad es: " + mEdad + "\n";
            text += "El numero de telefono es: " + mNumero + "\n";
            text += sexo() + "\n";
            text += estaCasado() + "\n";
            return text;
        }

    }
}
