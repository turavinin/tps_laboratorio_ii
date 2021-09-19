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

        public string DecimalBinario(double numero)
        {
            string output = "Valor Inválido";
            int numeroEntero = 0;
            string numBin = string.Empty;
            int resto;

            bool esValido = int.TryParse(Math.Round(numero).ToString(), out numeroEntero);

            if (esValido)
            {
                if (numeroEntero < 0)
                    numeroEntero *= -1;

                output = Convert.ToString(numeroEntero, 2);
            }

            return output;
        }

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
