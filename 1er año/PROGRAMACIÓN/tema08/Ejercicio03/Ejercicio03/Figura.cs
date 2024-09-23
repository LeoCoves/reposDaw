using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    public abstract class Figura
    {
        private int mPosicionX, mPosicionY;
        private string mColor;

        public string Color
        {
            get { return mColor; }
            set { mColor = value; }
        }

        public Figura(int x, int y, string color)
        {
            mPosicionX = x;
            mPosicionY = y;
            mColor = color;
        }

        public virtual string quienSoy()
        {
            return "Soy una figura";
        }

        public override string ToString()
        {
            string text = "Posicion X: " + mPosicionX + "\n" +
                           "Posicion Y: " + mPosicionY + "\n" +
                           "Color: " + mColor + "\n";
            return text;
        }

        public abstract double Area();
    }
}
