using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
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
                if(value > 0 || value < 100)
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

        public string mostrarDatosEmpleado()
        {
            string texto = "\nDatos de el empleado: \n";
            texto += "Nombre: " + mNombre + "\n";
            texto += "Edad: " + mEdad + "\n";
            texto += mostrarVentas() + "\n";
            return texto;
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

        public void eliminarVentas()
        {
            mVentas.Clear();
        }

        public double sumaVentas()
        {
            double suma = 0;
            for(int i = 0; i < mVentas.Count; i++)
            {
                suma += mVentas[i];
            }
            return suma;
        }

    }
}
