using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    public class Triangulo:Figura
    {
        private int mLado;

        public int Lado
        {
            get { return mLado; }
            set { mLado = value; }
        }

        public Triangulo(int x, int y, string color, int lado) : base(x, y, color)
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

        private double Altura()
        {
            return  (mLado * Math.Sqrt(3)) / 2;
        }

        public override double Area()
        {
            
            return (mLado * Altura()) / 2;
        }

        public override double Perimetro()
        {
            return 3 * mLado;
        }
    }
}
