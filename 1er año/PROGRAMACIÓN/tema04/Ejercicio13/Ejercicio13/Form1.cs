using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        bool bisiesto(int año)
        {
            bool comprobar = false;

            if (año % 100 == 0 && año % 400 == 0 || año % 4 == 0 && año % 100 != 0)
            {
                comprobar = true;
            }
            return comprobar;
        }

        bool validarFecha(int dia, int mes, int año)
        {


            if (año > 0 && mes >= 1 && mes <= 12)
            {
                bool esBisiesto = (año % 4 == 0 && año % 100 != 0) || año % 400 == 0;

                if (dia >= 1 && dia <= 31 && (mes != 2 || (esBisiesto && dia <= 29) || (!esBisiesto && dia <= 28)))
                {

                    if ((mes <= 7 && mes % 2 == 1) || (mes >= 8 || mes % 2 == 0))
                    {
                        return true;
                    }

                    else if (mes == 2 || mes == 9 || mes == 11)
                    {
                        return dia <= 30;
                    }

                    else
                    {
                        return dia <= 31;
                    }
                }
            }

            return false;


        }

        void mostrarFecha(ref int dia, ref int mes,ref int año)
        {
            if (validarFecha(dia, mes, año))
            {
                dia++;

                if (!validarFecha(dia, mes, año))
                {
                    dia = 1;
                    mes++;
                    
                }
                if (!validarFecha(dia, mes, año))
                {
                    mes = 1;
                    año++;
                }
            }

            
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int dia = int.Parse(txtDia.Text);
            int mes = int.Parse(txtMes.Text);
            int año = int.Parse(txtAño.Text);

            if (validarFecha(dia, mes, año))
            {
                mostrarFecha(ref dia, ref mes, ref año);
                MessageBox.Show("El dia es " + dia + ", el mes " + mes + " y el año " + año);
            }

            else
            {
                MessageBox.Show("No valido");
            }
        }
    }
}
