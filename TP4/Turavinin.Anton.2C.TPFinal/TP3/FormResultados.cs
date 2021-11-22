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
using System.Runtime.InteropServices;

namespace TP3
{
    public partial class FormResultados : Form
    {
        private EncuestaManager _encuestaManager;
        public FormResultados(EncuestaManager encuestaManager)
        {
            InitializeComponent();
            _encuestaManager = encuestaManager;
        }

        private void FormResultados_Load(object sender, EventArgs e)
        {
            this.RecargarInfo();
        }


        private void RecargarInfo()
        {
            _encuestaManager.EstablecerEstadisticasPuestos();
            _encuestaManager.CalcularPerfilPersonas();

            // Puestos
            this.txtPuestoMasNum.Text = _encuestaManager.EstadisticaPuestos.PuestoMasNumeroso;
            this.txtPuestoMenosNum.Text = _encuestaManager.EstadisticaPuestos.PuestoMenosNumeroso;
            this.txtPuestoMejorPago.Text = _encuestaManager.EstadisticaPuestos.PuestoMejorPagado;
            this.txtPuestoPeorPago.Text = _encuestaManager.EstadisticaPuestos.PuestoPeorPagado;

            // Genero
            this.txtTotalPersonas.Text = _encuestaManager.PerfilPersonas.TotalPersonas.ToString();
            this.barHomCis.Value = _encuestaManager.PerfilPersonas.PorcentajeHombresCis;
            this.barMujCis.Value = _encuestaManager.PerfilPersonas.PorcentajeMujeresCis;
            this.barHomTrans.Value = _encuestaManager.PerfilPersonas.PorcentajeHombresTrans;
            this.barMujTrans.Value = _encuestaManager.PerfilPersonas.PorcentajeMujeresTrans;
            this.barBin.Value = _encuestaManager.PerfilPersonas.PorcentajeNoBinarie;
            this.barAgen.Value = _encuestaManager.PerfilPersonas.PorcentajeAgenero;

            // Rangos Etarios
            this.bar2030.Value = _encuestaManager.PerfilPersonas.PorcentajeEntre20y30;
            this.bar3040.Value = _encuestaManager.PerfilPersonas.PorcentajeEntre30y40;
            this.bar4050.Value = _encuestaManager.PerfilPersonas.PorcentajeEntre40y50;
            this.barMas50.Value = _encuestaManager.PerfilPersonas.PorcentajeMasDe50;
        }

 
    }
}
