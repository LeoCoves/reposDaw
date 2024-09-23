using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    public class Hexagono:Figura
    {
        private int mLado;

        public int Lado
        {
            get { return mLado; }
            set { mLado = value; }
        }

        public Hexagono(int x, int y, string color, int lado) : base(x, y, color)
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

        private double Apotema()
        {
            double cateto = mLado / 2;
            return Math.Sqrt(Math.Pow(mLado, 2) - Math.Pow(cateto, 2));
        }

        public override double Area()
        {
            return (Perimetro() * Apotema()) / 2;
        }

        public override double Perimetro()
        {
            return mLado + mLado + mLado + mLado + mLado + mLado;
        }
    }
}
