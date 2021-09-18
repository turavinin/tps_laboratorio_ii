using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        private static char ValidarOperador(char operador)
        {
            char output = '+';
            if (operador == '-' || operador == '/' || operador == '*')
                output = operador;

            return output;
        }
    }
}
