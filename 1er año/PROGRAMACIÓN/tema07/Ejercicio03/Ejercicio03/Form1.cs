using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Ejercicio03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Date> listDate = new List<Date>();

        void pedirDatos(List<Date> listDate)
        {
            Date fecha = new Date();

            do
            {
                fecha.Day = int.Parse(Interaction.InputBox("Introduce el dia"));
                fecha.Month = int.Parse(Interaction.InputBox("Introduce el mes"));
                fecha.Year = int.Parse(Interaction.InputBox("Introduce el año"));

            } while (!fecha.validateDate());

            listDate.Add(fecha);
        }

        bool compareDate(Date fecha1, Date fecha2)
        {
            bool menor = false;

            if(fecha2.Year < fecha1.Year)
            {
                menor = true;
            }
            else if(fecha2.Year == fecha1.Year )
            {
                if(fecha2.Month < fecha1.Month)
                {
                    menor = true;
                }
                else if( fecha2.Month == fecha1.Month)
                {
                    if(fecha2.Day < fecha1.Day)
                    {
                        menor = true;
                    }
                }
            }
            return menor;
        }

        void orderList(List<Date> listDate)
        {
            int i = 0;
            Date aux;

            while (i < listDate.Count)
            {
                int j = i + 1;
                Date fecha1 = listDate[i]; 
                
                while (j < listDate.Count)
                {
                    Date fecha2 = listDate[j];
                    if (compareDate(fecha1, fecha2))
                    {
                        aux = listDate[i];
                        listDate[i] = listDate[j];
                        listDate[j] = aux;
                    }
                    j++;
                }
                i++;
            }
        }

        string mostrarLista(List<Date> listDate)
        {
            string texto = "";
            Date fecha;

            for(int i = 0; i < listDate.Count; i++)
            {
                fecha = listDate[i];
                texto += fecha.mostrarDatos() + "\n";
            }
            return texto;
        }

        private void btnLeer_Click(object sender, EventArgs e)
        {
            pedirDatos(listDate);
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            orderList(listDate);
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MessageBox.Show(mostrarLista(listDate));
        }
    }
}
