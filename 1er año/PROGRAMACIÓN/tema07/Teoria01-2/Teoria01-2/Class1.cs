using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teoria01_2
{
    class Empleado
    {
        private string mNombre;
        private int mEdad;

        private List<double> mVentas;

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
                if(value > 0 && value < 100)
                {
                    mEdad = value;
                }
            }
        }

        public Empleado()
        {
            mNombre = "";
            mEdad = 0;
            mVentas = new List<double>();

        }

        public void Cumpleanyos()
        {
            mEdad += 1;
        }

        public void anyadirVenta(double venta)
        {
            if(venta > 0)
            {
                mVentas.Add(venta);
            }
        }

        private string mostrarVentas()
        {
            string texto = "";

            if(mVentas.Count > 0)
            {
                texto += "Las ventas son: ";

                for(int i = 0; i < mVentas.Count; i++)
                {
                    texto += mVentas[i] + ", ";
                }
            }
            else
            {
                texto += "No tiene ventas";
            }
            return texto;
        }

        public string mostrarDatos()
        {
            string texto = "Datos del empleado: \n";
            texto += "El nombre es: " + mNombre + "\n";
            texto += "La edad es: " + mEdad + "\n";
            texto += mostrarVentas();
            return texto;
        }
    }
}
