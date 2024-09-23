using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04.Models
{
    public class Curso
    {
        private int mCodigo;
        private string mNombre;

        public int Codigo
        {
            get => mCodigo;
            set => mCodigo = value;
        }

        public string Nombre
        {
            get => mNombre;
            set => mNombre = value;
        }

        public Curso(int codigo, string nombre)
        {
            mCodigo = codigo;
            mNombre = nombre;
        }

    }
}
