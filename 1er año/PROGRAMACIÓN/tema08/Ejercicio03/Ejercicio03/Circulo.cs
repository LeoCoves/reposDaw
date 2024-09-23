using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    public class Circulo : Figura
    {
        private int mRadio;

        public int Radio
        {
            get { return mRadio; }
            set { mRadio = value; }
        }

        public Circulo(int x, int y, string color, int radio) : base(x, y, color)
        {
            mRadio = radio;
        }

        public override string quienSoy()
        {
            return "Soy un circulo";
        }

        public override string ToString()
        {
            string text = base.ToString();
            text += "Radio: " + mRadio + "\n";
            return text;
        }

        public override double Area()
        {
            return Math.PI * mRadio * mRadio;
        }
    }
}
