using Entidades;
using SistemasForms.ErrorMessages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasForms
{
    public partial class ResultadosForm : Form
    {
        private Manager manager;

        public ResultadosForm(Manager manager)
        {
            this.manager = manager;
            InitializeComponent();
        }

        private void ResultadosForm_Load(object sender, EventArgs e)
        {
            this.RecargarInformacion();
        }

        private void RecargarInformacion()
        {
            try
            {
                this.manager.CalcularResultados();

                // Roles
                this.txtTotalPersonas.Text = this.manager.TotalPersonas.ToString();
                this.txtRolMasNum.Text = this.manager.Estadisticas.RolMasNumeroso;
                this.txtRolMenosNum.Text = this.manager.Estadisticas.RolMenosNumeroso;
                this.txtRolMejorPago.Text = this.manager.Estadisticas.RolMejorPagado;
                this.txtRolPeorPago.Text = this.manager.Estadisticas.RolPeorPagado;

                // Genero
                this.barHomCis.Value = this.manager.Estadisticas.PorcentajeHombresCis;
                this.barMujCis.Value = this.manager.Estadisticas.PorcentajeMujeresCis;
                this.barHomTrans.Value = this.manager.Estadisticas.PorcentajeHombresTrans;
                this.barMujTrans.Value = this.manager.Estadisticas.PorcentajeMujeresTrans;
                this.barBin.Value = this.manager.Estadisticas.PorcentajeNoBinarie;
                this.barAgen.Value = this.manager.Estadisticas.PorcentajeAgenero;

                // Rangos Etarios
                this.bar2030.Value = this.manager.Estadisticas.PorcentajeEntre20y30;
                this.bar3040.Value = this.manager.Estadisticas.PorcentajeEntre30y40;
                this.bar4050.Value = this.manager.Estadisticas.PorcentajeEntre40y50;
                this.barMas50.Value = this.manager.Estadisticas.PorcentajeMasDe50;
            }
            catch (Exception ex)
            {
                MessagesHelper.MostrarException(ex);
            }
        }
    }
}
