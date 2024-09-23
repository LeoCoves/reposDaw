using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio04
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
            emp.DNI = DNI;
            emp.Nombre = Nombre;
            emp.Edad = Edad;
            mLista.Add(emp);
        }

        public bool showListEmp(out string texto)
        {
            texto = "Datos de los empleados: \n";
            bool exist = false;
            Employer emp;

            if(mLista.Count > 0)
            {
                exist = true;
                for(int i = 0; i < mLista.Count; i++)
                {
                    emp = mLista[i];
                    texto += emp.showDataEmp() + "\n";
                }
            }
            return exist;
        }

        public void isEmpBirthay(string Nombre)
        {
            Employer emp;

            for(int i = 0; i < mLista.Count; i++)
            {
                emp = mLista[i];
                if(emp.Nombre == Nombre)
                {
                    emp.birthay();
                }
            }
        }

        public void addSalesEmp(string Nombre, int sales)
        {
            Employer emp;

            for (int i = 0; i < mLista.Count; i++)
            {
                emp = mLista[i];
                if (emp.Nombre == Nombre)
                {
                    emp.addSales(sales);
                }
            }
        }
    }
}
