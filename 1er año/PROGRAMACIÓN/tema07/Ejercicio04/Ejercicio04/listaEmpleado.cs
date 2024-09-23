using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
{
    class listaEmpleados
    {
        private List<Empleado> mLista;

        public listaEmpleados()
        {
            mLista = new List<Empleado>();
        }

        //metodos

        public void addEmployer(string nombre, int edad)
        {
            Empleado emp = new Empleado();

            emp.Nombre = nombre;
            emp.Edad = edad;

            mLista.Add(emp);
        }

        private int searchEmployer(string nombre)
        {
            int pos = -1;
            bool encontrado = false;
            Empleado emp;
            int i = 0;

            while (i < mLista.Count && !encontrado)
            {
                emp = mLista[i];

                if (emp.Nombre == nombre)
                {
                    pos = i;
                    encontrado = true;
                }
                else
                    i++;
            }
            return pos;
        }

        public bool addVenta(string nombre, double venta)
        {
            bool encontrado = false;
            Empleado emp;
            int pos = searchEmployer(nombre);

            if(pos >= 0)
            {
                emp = mLista[pos];
                emp.anyadirVenta(venta);
                encontrado = true;
            }
            return encontrado;
        }

        public bool Birthay(string nombre)
        {
            bool encontrado = false;
            Empleado emp;
            int pos = searchEmployer(nombre);

            if(pos >= 0)
            {
                emp = mLista[pos];
                emp.Cumpleanyos();
                encontrado = true;
            }
            return encontrado;
        }

        public string showListEmployer()
        {
            string texto = "\n";

            for (int i = 0; i < mLista.Count; i++)
            {
                Empleado emp = mLista[i];
                texto += emp.mostrarDatos();
            }
            return texto;
        }
    }
}
