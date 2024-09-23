using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio03
{
    class Date
    {
        private int mDay;
        private int mMonth;
        private int mYear;

        public int Day
        {
            get { return mDay; }
            set { mDay = value; }
        }

        public int Month
        {
            get { return mMonth; }
            set { mMonth = value; }
        }

        public int Year
        {
            get { return mYear; }
            set { mYear = value; }
        }
        public Date()
        {
            mDay = 0;
            mMonth = 0;
            mYear = 0;
        }

        private bool bisiesto(int año)
        {
            bool comprobar = false;

            if (año % 100 == 0 && año % 400 == 0 || año % 4 == 0 && año % 100 != 0)
            {
                comprobar = true;
            }
            return comprobar;
        }

        public bool validateDate()
        {
            if (mYear > 0 && mMonth >= 1 && mMonth <= 12)
            {
                bool esBisiesto = bisiesto(mYear);

                if (mDay >= 1 && mDay <= 31 && (mMonth != 2 || (esBisiesto && mDay <= 29) || (!esBisiesto && mDay <= 28)))
                {
                    if ((mMonth <= 7 && mMonth % 2 == 1) || (mMonth >= 8 || mMonth % 2 == 0))
                    {
                        return true;
                    }
                    else if (mMonth == 2 || mMonth == 9 || mMonth == 11)
                    {
                        return mDay <= 30;
                    }
                    else
                    {
                        return mDay <= 31;
                    }
                }
            }
            return false;
        }


        public string mostrarDatos()
        {
            string text = "";
            text += mDay + " del " + mMonth + " de " + mYear;
            return text;
        }
    }
}
