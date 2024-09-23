using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    public class Employer
    {
        private string mDNI;
        private string mNombre;
        private int mEdad;
        private List<int> mVentas;

        public string DNI
        {
            get { return mDNI; }
            set { mDNI = value; }
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
            mDNI = "";
            mNombre = "";
            mEdad = 0;
            mVentas = new List<int>();
        }

        private string showSales()
        {
            string texto;
            if(mVentas.Count > 0)
            {
                texto = "Ventas: ";
                for(int i = 0; i < mVentas.Count; i++)
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
            string texto = "DNI: " + mDNI + "\n";
            texto += "Nombre: " + mNombre + "\n";
            texto += "Edad: " + mEdad + "\n";
            texto += showSales() + "\n";
            return texto;
        }

        public void birthay()
        {
            mEdad += 1;
        }

        public void addSales(int sales)
        {
            mVentas.Add(sales);
        }

    }
}
