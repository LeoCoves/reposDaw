using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Ejercicio3.Models
{
    public class Coche
    {
        // Miembros
        private string mMatricula, mMarca, mModelo;
        private int mPotencia;
        private string mColor, mAnyo;
        private double mPrecio;
        // Propiedades
        public string Matricula
        {
            get { return mMatricula; }
            set { mMatricula = value; }
        }
        public string Marca
        {
            get { return mMarca; }
            set { mMarca = value; }
        }
        // Otra posible forma de hacer la propiedad
        public string Modelo
        {
            get => mModelo;
            set => mModelo = value;
        }
        public int Potencia
        {
            get => mPotencia;
            set => mPotencia = value;
        }
        public string Color
        {
            get => mColor;
            set => mColor = value;
        }

        public string Anyo
        {
            get => mAnyo;
            set => mAnyo = value;
        }
        public double Precio
        {
            get => mPrecio;
            set => mPrecio = value;
        }

        // Constructor
        public Coche(string Matricula, string Marca, string Modelo,
        int Potencia, string Color, string Anyo, double Precio)
        {
            mMatricula = Matricula;
            mMarca = Marca;
            mModelo = Modelo;
            mPotencia = Potencia;
            mColor = Color;
            mAnyo = Anyo;
            mPrecio = Precio;
        }


    }
}
