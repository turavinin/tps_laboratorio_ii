using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiCalculadora
{
    public partial class FormCalculadora : Form
    {
        public FormCalculadora()
        {
            InitializeComponent();
            this.Limpiar();
        }

        #region Metodos
        /// <summary>
        /// Limpia los campos de la calculadora. 
        /// </summary>
        private void Limpiar()
        {
            this.txtNumero1.Text = string.Empty;
            this.txtNumero2.Text = string.Empty;
            this.lblResultado.Text = "0";
            this.cmbOperador.SelectedIndex = 0;
            this.lstOperaciones.Items.Clear();
        }

        /// <summary>
        /// Realiza la operación entre los dos números.
        /// </summary>
        /// <param name="numero1"></param>
        /// <param name="numero2"></param>
        /// <param name="operador"></param>
        /// <returns>Retorna el resultado en formato double.</returns>
        private static double Operar(string numero1, string numero2, string operador)
        {
            double output = 0;
            Operando num1 = new Operando(numero1);
            Operando num2 = new Operando(numero2);
            output = Calculadora.Operar(num1, num2, operador.FirstOrDefault());
            return output;
        }
        #endregion

        #region Eventos
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
        }

        private void FormCalculadora_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Environment.Exit(0);
            }
            else
            {
                e.Cancel = true;
            }
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
            //DialogResult result = MessageBox.Show("¿Seguro que quiere salir?", "Salir", MessageBoxButtons.YesNo);
            //if (result == DialogResult.Yes)
            //{
            //    Environment.Exit(0);
            //}
        }

        private void btnOperar_Click(object sender, EventArgs e)
        {
            string num1 = double.TryParse(this.txtNumero1.Text, out _) ? this.txtNumero1.Text : "0";
            string num2 = double.TryParse(this.txtNumero2.Text, out _) ? this.txtNumero1.Text : "0";
            string operador = this.cmbOperador.Text;

            double result = FormCalculadora.Operar(num1, num2, operador);

            if (num2.Contains('-'))
                num2 = $"({num2})";

            if (string.IsNullOrEmpty(operador))
                operador = "+";

            string operacion = $"{num1} {operador} {num2} = {result}";

            this.lstOperaciones.Items.Add(operacion);
            this.lblResultado.Text = result.ToString();
        }

        private void btnConvertirABinario_Click(object sender, EventArgs e)
        {
            string resultado = this.lblResultado.Text;
            Operando num1 = new Operando();
            string resultadoBinario = num1.DecimalBinario(resultado);
            this.lblResultado.Text = resultadoBinario;
        }

        private void btnConvertirADecimal_Click(object sender, EventArgs e)
        {
            string resultadoBinario = this.lblResultado.Text;
            Operando num1 = new Operando();
            string resultadoDecimal = num1.BinarioDecimal(resultadoBinario);
            this.lblResultado.Text = resultadoDecimal;
        } 
        #endregion
    }
}
