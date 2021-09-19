using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Operando
    {
        private double numero;
        public string Numero
        {
            set
            {
                this.numero = ValidarOperando(value);
            }
        }

        #region Constructores
        public Operando() : this("0")
        { }

        public Operando(double numero) : this(numero.ToString())
        { }

        public Operando(string strNumero)
        {
            this.Numero = strNumero;
        }
        #endregion

        #region Metodos
        /// <summary>
        /// Valida el operanod (número) ingresado. 
        /// </summary>
        /// <param name="strNumero">Número en tipo string.</param>
        /// <returns>En caso número, retorna el número en tipo double. Caso contrario, retorna 0 en tipo double.</returns>
        private double ValidarOperando(string strNumero)
        {
            double output = 0;
            double auxDouble;
            bool esNumValido;

            esNumValido = double.TryParse(strNumero, out auxDouble);
            if (esNumValido)
                output = auxDouble;

            return output;
        }

        /// <summary>
        /// Verifica si la cadena de texto pasada es un número binario.
        /// </summary>
        /// <param name="binario">Cadena de texto a analizar</param>
        /// <returns>True, si es binario. False, si no es binario.</returns>
        private bool EsBinario(string binario)
        {
            bool output = true;
            foreach (char charNumero in binario)
            {
                if (charNumero != '0' && charNumero != '1')
                {
                    output = false;
                    break;
                }
            }
            return output;
        }

        /// <summary>
        /// Realiza la conversión de binario a decimal.
        /// </summary>
        /// <param name="binario">Binario a convertir.</param>
        /// <returns>Retorna el número decimal en string</returns>
        public string BinarioDecimal(string binario)
        {
            string output = "Valor Inválido";
            int numDecimal;

            bool esBinario = this.EsBinario(binario);

            if (esBinario)
            {
                numDecimal = Convert.ToInt32(binario, 2);
                output = numDecimal.ToString();
            }

            return output;
        }

        /// <summary>
        /// Realiza la conversión de decimal a binario.
        /// </summary>
        /// <param name="numero">Decimal a convertir en tipo double.</param>
        /// <returns>De ser un número valido, retorna el binario en formato string. Caso contrario retorna 0 en formato string.</returns>
        public string DecimalBinario(double numero)
        {
            string output = "Valor Inválido";
            int numeroEntero = 0;

            bool esValido = int.TryParse(Math.Round(numero).ToString(), out numeroEntero);

            if (esValido)
            {
                if (numeroEntero < 0)
                    numeroEntero *= -1;

                output = Convert.ToString(numeroEntero, 2);
            }

            return output;
        }

        /// <summary>
        /// Realiza la conversión de decimal a binario.
        /// </summary>
        /// <param name="strNumero">Decimal a convertir en tipo string.</param>
        /// <returns>De ser un número valido, retorna el binario en formato string. Caso contrario retorna 0 en formato string.</returns>
        public string DecimalBinario(string strNumero)
        {
            string output = "Valor Inválido";
            double numero;
            bool esValido = double.TryParse(strNumero, out numero);
            if (esValido)
            {
                output = this.DecimalBinario(numero);
            }

            return output;
        }
        #endregion

        #region Sobrecarga Operadores
        public static double operator +(Operando n1, Operando n2)
        {
            return n1.numero + n2.numero;
        }

        public static double operator -(Operando n1, Operando n2)
        {
            return n1.numero - n2.numero;
        }

        public static double operator /(Operando n1, Operando n2)
        {
            double output;
            if(n2.numero == 0)
            {
                output = double.MinValue;
            }
            else
            {
                output = n1.numero / n2.numero;
            }
            return output;
        }

        public static double operator *(Operando n1, Operando n2)
        {
            return n1.numero * n2.numero;
        }
        #endregion
    }
}
