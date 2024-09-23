using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio05
{
    class listaEmpleados
    {
        List<Empleado> mLista;

        public listaEmpleados()
        {
            mLista = new List<Empleado>();
        }

        //metodos

        public void anyadirEmpleado(string nombre, int Edad)
        {
            Empleado emp = new Empleado();
            emp.Nombre = nombre;
            emp.Edad = Edad;

            mLista.Add(emp);
        }

        private int buscarEmpleado(string nombre)
        {
            Empleado emp;
            int pos = -1;
            bool encontrado = false;
            int i = 0;

            while(i < mLista.Count && !encontrado)
            {
                emp = mLista[i];
                if(emp.Nombre == nombre)
                {
                    pos = i;
                    encontrado = true;
                }
                else
                {
                    i++;
                }
            }
            return pos;
        }

        public bool eliminarEmpleado(string nombre)
        {
            bool encontrado = false;
            int pos = buscarEmpleado(nombre);

            if (pos >= 0)
            {
                mLista.RemoveAt(pos);
                encontrado = true;
            }
            return encontrado;
        }

        public void mostrarDatosEmpleado(string nombre, out bool encontrado, out string texto)
        {
            texto = "";
            int pos = buscarEmpleado(nombre);
            encontrado = false;

            if(pos >= 0)
            {
                Empleado emp;
                emp = mLista[pos];
                texto += emp.mostrarDatosEmpleado();
                encontrado = true;
            }
        }

        public string mostrarListaEmpleados()
        {
            Empleado emp;
            string texto = "Empleados:\n";
            for(int i = 0; i < mLista.Count; i++)
            {
                emp = mLista[i];
                texto += emp.mostrarDatosEmpleado();
            }
            return texto;
        }

        public void orderEmpAlf()
        {
            Empleado aux;

            for(int i = 0; i < mLista.Count; i++)
            {             
                for (int j = i+1; j < mLista.Count; j++)
                { 
                    if (string.Compare(mLista[i].Nombre, mLista[j].Nombre)>=0)
                    {
                        aux = mLista[i];
                        mLista[i] = mLista[j];
                        mLista[j] = aux;
                    }
                }
            }
        }

        public bool addVenta(string nombre, double venta)
        {
            Empleado emp;
            int pos = buscarEmpleado(nombre);
            bool encontrado = false;

            if(pos >= 0)
            {
                emp = mLista[pos];
                emp.anyadirVenta(venta);
                encontrado = true;
            }
            return encontrado;
        }

        public bool deleteVentas(string nombre)
        {
            Empleado emp;
            int pos = buscarEmpleado(nombre);
            bool encontrado = false;

            if (pos >= 0)
            {
                emp = mLista[pos];
                emp.eliminarVentas();
                encontrado = true;
            }
            return encontrado;
        }

        public int employerBestSales()
        {
            Empleado emp;
            emp = mLista[0];
            double maxVentas = emp.sumaVentas();
            int pos = 0;

            for (int i = 1; i < mLista.Count; i++)
            {
                emp = mLista[i];
                if (emp.sumaVentas() > maxVentas)
                {
                    maxVentas = emp.sumaVentas();
                    pos = i;
                }
            }
            return pos;
        }

        public string showDataEmpBestSales()
        {
            string texto = "El empleado con mas ventas es: \n";
            int pos = employerBestSales();
            Empleado emp;
            emp = mLista[pos];
            texto += emp.mostrarDatosEmpleado();
            return texto;
        }

        public bool comprobarEmpleadosSinVentas()
        {
            bool encontrado = false;
            double suma = 0;
            for(int i = 0; i < mLista.Count; i++)
            {
                suma += mLista[i].sumaVentas();
            }
            if(suma == 0)
            {
                encontrado = true;
            }
            return encontrado;
        }

        public void ordenarEmpleadoPorVentas()
        {
            Empleado aux;

            for (int i = 0; i < mLista.Count; i++)
            {
                for (int j = i + 1; j < mLista.Count; j++)
                {
                    if (mLista[i].sumaVentas() < mLista[j].sumaVentas())
                    {
                        aux = mLista[i];
                        mLista[i] = mLista[j];
                        mLista[j] = aux;
                    }
                }
            }
        }
        
        public bool comprobarSiHayVentas(string nombre)
        {
            Empleado emp;
            int pos = buscarEmpleado(nombre);
            bool encontrado = false;

            if (pos >= 0)
            {
                emp = mLista[pos];
                if (emp.sumaVentas() == 0)
                {
                    encontrado = true;
                }
            }
            return encontrado;
        }

        public bool comprobarSiHayEmpleados()
        {
            bool encontrado = false;
            if(mLista.Count > 0)
            {
                encontrado = true;
            }
            return encontrado;
        }
    }
}
