using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Ejercicio06CentroEscolar
{
    static class Validacion
    {
        public static bool validarDNI(string DNI)
        {
            string regexPattner = "^[0-9]{8}[A-Z]$";
            return new Regex(regexPattner).IsMatch(DNI);
        }


        public static bool validarTelf(string telf)
        {
            string regexPattner = "^[6|7|9][0-9]{8}$";
            return new Regex(regexPattner).IsMatch(telf);
        }

        public static bool validarNota(double nota)
        {
            string regexPattner = "^(10|[0-9](,[0-9]{1,2})?)$";
            return new Regex(regexPattner).IsMatch(nota.ToString());
        }
    }
}
