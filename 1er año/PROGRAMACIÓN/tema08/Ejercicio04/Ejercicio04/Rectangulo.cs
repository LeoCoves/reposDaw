using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    public class Rectangulo:Figura
    {
        private int mBase;
        private int mAltura;

        public int Base
        {
            get { return mBase; }
            set { mBase = value; }
        }

        public int Altura
        {
            get { return mAltura; }
            set { mAltura = value; }
        }

        public Rectangulo(int x, int y, string color, int bas, int altura) : base(x, y, color)
        {
            mBase = bas;
            mAltura = altura;
        }

        public override string quienSoy()
        {
            return "Soy un cuadrado";
        }

        public override string ToString()
        {
            string text = base.ToString();
            text += "Base: " + mBase + "\n";
            text += "Altura: " + mAltura + "\n";
            return text;
        }

        public override double Area()
        {
            return mBase * mAltura;
        }

        public override double Perimetro()
        {
            return 2*(mBase + mAltura);
        }
    }
}
