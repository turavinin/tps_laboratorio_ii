using Entidades;
using Entidades.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3
{
    public partial class FormPrincipal : Form
    {
        private EncuestaManager _encuestaManager;

        public FormPrincipal()
        {
            InitializeComponent();
            _encuestaManager = new EncuestaManager();
        }

        private void FormPrincipal_Load(object sender, EventArgs e)
        {
            Task tareaPersonas = new Task(()=> _encuestaManager.CargarListaEntidad<Persona>());
            Task tareaPuesto = new Task(() => _encuestaManager.CargarListaEntidad<Puesto>());
            Task tareaExperiencias = new Task(() => _encuestaManager.CargarListaEntidad<Experiencia>());

            tareaExperiencias.Start();
            tareaPuesto.Start();
            tareaPersonas.Start();
        }

        private void btnCargaPersona_Click(object sender, EventArgs e)
        {
            FormPersona frmPersona = new FormPersona(_encuestaManager);
            frmPersona.ShowDialog();
        }

        private void btnConfiguracion_Click(object sender, EventArgs e)
        {
            FormConfiguracion formConfig = new FormConfiguracion(_encuestaManager);
            formConfig.ShowDialog();
        }

        private void btnResultados_Click(object sender, EventArgs e)
        {
            FormResultados frmResultado = new FormResultados(_encuestaManager);
            frmResultado.ShowDialog();
        }
    }
}
