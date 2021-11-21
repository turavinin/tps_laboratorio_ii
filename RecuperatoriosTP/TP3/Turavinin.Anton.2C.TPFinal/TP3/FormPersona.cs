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

namespace TP3
{
    public partial class FormPersona : Form
    {
        private EncuestaManager _encuestaManager;

        public FormPersona(EncuestaManager encuestaManager)
        {
            InitializeComponent();
            _encuestaManager = encuestaManager;
        }

        private void FormPersona_Load(object sender, EventArgs e)
        {
            this.ActualizarListaPersonas(_encuestaManager.Personas);
        }

        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            FormOperacionesPersonas frmPersonas = new FormOperacionesPersonas(_encuestaManager, "Crear Persona");
            frmPersonas.ShowDialog();
            this.ActualizarListaPersonas(_encuestaManager.Personas);
        }

        private void btnEditarPersona_Click(object sender, EventArgs e)
        {
            int id = this.GetIdPersona();
            FormOperacionesPersonas frmPersonas = new FormOperacionesPersonas(_encuestaManager, "Editar Persona", id);
            frmPersonas.ShowDialog();
            this.ActualizarListaPersonas(_encuestaManager.Personas);
        }

        private void btnEliminarPersona_Click(object sender, EventArgs e)
        {
            int id = this.GetIdPersona();

            var confirmacion = MessageBox.Show("¿Esta seguro de querer eliminar a la persona?",
                                               "Eliminar Persona", MessageBoxButtons.YesNo);

            if (confirmacion == DialogResult.Yes)
            {
                var persona = _encuestaManager.EncontrarRegistro<Persona>(id);
                _encuestaManager.EliminarRegistro(persona);
                _encuestaManager.GuardarEntidad(_encuestaManager.Personas, "personas.json");
                this.ActualizarListaPersonas(_encuestaManager.Personas);
            }
        }



        #region Metodos Privados
        private int GetIdPersona()
        {
            return int.Parse(this.dgvPersonas.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void ActualizarListaPersonas(List<Persona> personas)
        {
            this.dgvPersonas.Rows.Clear();
            personas.ForEach(x => this.CargarPersona(x));
        }

        private void CargarPersona(Persona persona)
        {
            string puesto = _encuestaManager.Puestos.Where(x => x.Id == persona.PuestoId).FirstOrDefault().Descripcion;
            string experiencia = _encuestaManager.Experiencias.Where(x => x.Id == persona.ExperienciaId).FirstOrDefault().TipoExperiencia;
            this.dgvPersonas.Rows.Add(persona.Id, persona.Nombre, persona.Edad, persona.Sexo, puesto, experiencia, persona.Salario.ToString("F2"));
        }
        #endregion
    }
}
