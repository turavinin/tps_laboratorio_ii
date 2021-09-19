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

        public static double Operar(Operando num1, Operando num2, char operador)
        {
            double output;

            char operadorVerificado = ValidarOperador(operador);
            switch (operadorVerificado)
            {
                case '-':
                    output = num1 - num2;
                    break;
                case '/':
                    output = num1 / num2;
                    break;
                case '*':
                    output = num1 * num2;
                    break;
                default:
                    output = num1 + num2;
                    break;
            }
            return output;
        }
    }
}
