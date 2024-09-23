using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    public class Cuadrado:Figura
    {
        private int mLado;

        public int Lado
        {
            get { return mLado; }
            set { mLado = value; }
        }

        public Cuadrado(int x, int y, string color, int lado):base(x, y, color)
        {
            mLado = lado;
        }

        public override string quienSoy()
        {
            return "Soy un cuadrado";
        }

        public override string ToString()
        {
            string text = base.ToString();
            text += "Lado: " + mLado + "\n";
            return text;
        }

        public override double Area()
        {
            return mLado * mLado;
        }

        public override double Perimetro()
        {
            return mLado * mLado;
        }
    }
}
