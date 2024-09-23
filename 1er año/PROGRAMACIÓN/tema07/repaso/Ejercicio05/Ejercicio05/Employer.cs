using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    public class Employer
    {
        private string mDni;
        private string mNombre;
        private int mEdad;
        private List<int> mVentas;

        public string Dni
        {
            get { return mDni; }
            set { mDni = value; }
        }

        public string Nombre
        {
            get { return mNombre; }
            set { mNombre = value; }
        }

        public int Edad
        {
            get { return mEdad; }
            set { mEdad = value; }
        }


        public Employer()
        {
            mDni = "";
            mNombre = "";
            mEdad = 0;
            mVentas = new List<int>();
        }

        private string showSales()
        {
            string texto;
            if (mVentas.Count > 0)
            {
                texto = "Ventas: ";
                for (int i = 0; i < mVentas.Count; i++)
                {
                    texto += mVentas[i] + ", ";
                }
            }
            else
            {
                texto = "No hay ventas";
            }
            return texto;
        }

        public string showDataEmp()
        {
            string texto = "DNI: " + mDni + "\n";
            texto += "Nombre: " + mNombre + "\n";
            texto += "Edad: " + mEdad + "\n";
            texto += showSales() + "\n";
            return texto;
        }

        public void addSales(int sales)
        {
            mVentas.Add(sales);
        }

        public bool delSales()
        {
            bool empty = true;
            if(mVentas.Count > 0)
            {
                empty = false;
                mVentas.Clear();
            }
            return empty;
        }

        public int sumaVentas()
        {
            int suma = 0;
            for(int i = 0; i < mVentas.Count; i++)
            {
                suma += mVentas[i];
            }
            return suma;
        }
    }
}
