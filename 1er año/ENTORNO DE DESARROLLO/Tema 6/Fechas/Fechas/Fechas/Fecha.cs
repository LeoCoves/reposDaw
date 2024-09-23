using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fechas
{
    internal class Fecha
    {
        public int mDia;
        public int mMes;
        public int mAnyo;

        //TODO validar los valores introducidos
        /// <summary>
        /// Constructor de Fecha sin parámetros
        /// Se establecen los valores a 1
        /// </summary>
        public Fecha()
        {
            mDia = 1;
            mMes= 1;
            mAnyo = 1;
        }

        /// <summary>
        /// Constructor de Fecha con 3 parámetros
        /// Si algún parámetro no es correcto se establece a 1
        /// </summary>
        /// <param name="mes">Mes</param>
        /// <param name="anyo">Anyo (entre 1 y 2500)</param>
        /// <param name="dia">Dia</param>
        /// <param name="bi">Indica si es bisiesto</param>
        
        public Fecha(int mes, int anyo, int dia)
        {
            //Validamos el Anyo
            if (anyo >= 1 && anyo <= 2500)
            {
                this.mAnyo = anyo;
            }
            else
            {
                this.mAnyo = 1;
            }

            bool bisiesto = EsBisiesto();

            //Validamos el Mes
            if (mes >= 1 && mes <= 12)
                this.mMes = mes;
            else
                this.mMes = 1;

            int diasMes = 0;

            if(mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10 || mes == 12)
            {
                diasMes = 31;
            }
            else if(mes == 4 || mes == 6 || mes == 9 || mes == 11)
            {
                diasMes = 30;
            }
            else
            {
                if (bisiesto)
                {
                    diasMes = 29;
                }
                else
                {
                    diasMes = 28;
                }
            }

            //Validamos el Dia
            if (dia >= 1 && dia <= diasMes)
                this.mDia = dia;
            else
                this.mDia = 1;
        }

        public bool EsBisiesto()
        {
            bool bisiesto = false;
            if ((mAnyo % 400 == 0) || ((mAnyo % 4 == 0) && (mAnyo % 100 != 0)))
                bisiesto = true;
            else bisiesto = false;
            return bisiesto;
        }


        /// <summary>
        /// Devuelve un string con la fecha en formato dia/mes/anyo
        /// </summary>
        /// <remarks> la palabra clave override indica que se  sobreescribe el metodo ToString</remarks>
        /// <returns>un string con la fecha en formato dia/mes/anyo</returns> public override string
        override
        public string ToString()
        {
            string texto = "";
            texto += mDia + "/" + mMes + "/" + mAnyo;
            return texto;
        }
    }
}
