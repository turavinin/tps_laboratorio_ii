using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Calculadora
    {
        /// <summary>
        /// Valida operador
        /// </summary>
        /// <param name="operador">Operador a validar del tipo char</param>
        /// <returns>Retorna el operador pasado en caso válido, en caso inválido retorna el operador '+' </returns>
        private static char ValidarOperador(char operador)
        {
            char output = '+';
            if (operador == '-' || operador == '/' || operador == '*')
                output = operador;

            return output;
        }

        /// <summary>
        /// Realiza la operacion matemática.
        /// </summary>
        /// <param name="num1">El primer número</param>
        /// <param name="num2">El segundo número</param>
        /// <param name="operador">El operador matemático</param>
        /// <returns>Retorna el resultado</returns>
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
