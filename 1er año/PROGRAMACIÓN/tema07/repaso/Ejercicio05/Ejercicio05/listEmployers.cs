using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio05
{
    public class listEmployers
    {
        List<Employer> mLista;

        public listEmployers()
        {
            mLista = new List<Employer>();
        }

        public void addEmployer(string DNI, string Nombre, int Edad)
        {
            Employer emp = new Employer();
            emp.Dni = DNI;
            emp.Nombre = Nombre;
            emp.Edad = Edad;
            mLista.Add(emp);
        }

        public int searchEmp(string dni)
        {
            Employer emp;
            bool encontrado = false;
            int pos = -1;
            for(int i = 0; i < mLista.Count && !encontrado; i++)
            {
                emp = mLista[i];
                if(emp.Dni == dni)
                {
                    pos = i;
                    encontrado = true;
                }
            }
            return pos;
        }

        public void deleteEmp(string dni)
        {
            int pos = searchEmp(dni);
            if(pos > 0)
            {
                mLista.RemoveAt(pos);
            }
        }

        public bool isEmpty()
        {
            bool empty = true;
            if(mLista.Count > 0)
            {
                empty = false;
            }
            return empty;
        }

        public bool showListEmp(out string texto)
        {
            texto = "Datos de los empleados: \n";
            bool exist = false;
            Employer emp;

            if (mLista.Count > 0)
            {
                exist = true;
                for (int i = 0; i < mLista.Count; i++)
                {
                    emp = mLista[i];
                    texto += emp.showDataEmp() + "\n";
                }
            }
            return exist;
        }

        public string showEmp(string dni)
        {
            Employer emp;
            int pos = searchEmp(dni);
            emp = mLista[pos];
            string texto = emp.showDataEmp();
            return texto;
        }

        public void addSalesEmployer(string dni, int sales)
        {
            int pos = searchEmp(dni);
            Employer emp;
            emp = mLista[pos];
            emp.addSales(sales);
        }

        public void delSalesEmployer(string dni, out bool empty)
        {
            Employer emp;
            int pos = searchEmp(dni);
            emp = mLista[pos];
            empty = emp.delSales();
        }

        public string searchEmpMaySales()
        {
            Employer emp;
            int sumaVentas = 0;
            string texto = "";

            for(int i = 0; i < mLista.Count; i++)
            {
                emp = mLista[i];
                if(emp.sumaVentas() >= sumaVentas)
                {
                    sumaVentas = emp.sumaVentas();
                    texto = emp.Dni + "\n" + emp.Nombre;
                }
            }
            return texto;
        }

        public void orderByName()
        {
            Employer aux;
            for(int i = 0; i < mLista.Count; i++)
            {
                
                for(int j = 1; j < mLista.Count; j++)
                {

                    if (string.Compare(mLista[i].Nombre, mLista[j].Nombre) >= 0)
                    {
                        aux = mLista[i];
                        mLista[i] = mLista[j];
                        mLista[j] = aux;
                    }
                }
            }
        }

        public void orderBySales()
        {
            Employer aux;
            if(mLista.Count > 1)
            {
                for(int i = 0; i < mLista.Count; i++)
                {
                    for(int j = 1; j < mLista.Count; j++)
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
        }
    }
}
