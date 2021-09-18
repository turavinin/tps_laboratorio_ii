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
        #endregion
    }
}
