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
using TP3.ErrorHandler;

namespace TP3
{
    public partial class FormOperacionesPersonas : Form
    {
        private string _tituloVentana;
        private EncuestaManager _encuestaManager;
        private Persona _persona;

        public FormOperacionesPersonas(EncuestaManager encuestaManager, string tituloVentana, int idPersona = 0)
        {
            InitializeComponent();
            _tituloVentana = tituloVentana;
            _encuestaManager = encuestaManager;


            if (idPersona > 0)
            {
                _persona = _encuestaManager.EncontrarRegistro<Persona>(idPersona);
            }
        }

        private void FormOperacionesPersonas_Load(object sender, EventArgs e)
        {
            this.Text = _tituloVentana;
            this.CompletarCmbs();

            if (_persona is not null)
            {
                this.CargarFormulario(_persona);
            }
        }

        private void btnAceptarPersona_Click(object sender, EventArgs e)
        {
            if(!this.VerificarCampos(out string error))
            {
                ErrorManager.MostrarError($"{error}");
            }
            else
            {
                if(_persona is not null)
                {
                    this.EditarPersona();
                }
                else
                {
                    this.CrearPersona();
                }
                _encuestaManager.GuardarEntidad(_encuestaManager.Personas, "personas.json");
            }

            this.Close();
        }

        private void btnCancelarPersona_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        #region Metodos Privados
        private void CargarFormulario(Persona persona)
        {
            string puesto = _encuestaManager.Puestos.Where(x => x.Id == persona.PuestoId).FirstOrDefault().Descripcion;
            string experiencia = _encuestaManager.Experiencias.Where(x => x.Id == persona.ExperienciaId).FirstOrDefault().TipoExperiencia;

            this.txtIdPersona.Text = persona.Id.ToString();
            this.txtnombrePersona.Text = persona.Nombre.ToString();
            this.txtEdadPersona.Text = persona.Edad.ToString();
            this.txtSalarioPersona.Text = persona.Salario.ToString();
            this.cmbSexoPersona.SelectedIndex = this.cmbSexoPersona.Items.IndexOf(persona.Sexo);
            this.cmbPuestoPersona.SelectedIndex = this.cmbPuestoPersona.Items.IndexOf(puesto);
            this.cmbExpPersona.SelectedIndex = this.cmbExpPersona.Items.IndexOf(experiencia);
        }
        private void CompletarCmbs()
        {
            _encuestaManager.Puestos.ForEach(x => this.cmbPuestoPersona.Items.Add(x.Descripcion));
            _encuestaManager.Experiencias.ForEach(x => this.cmbExpPersona.Items.Add(x.TipoExperiencia));
        }
        private bool VerificarCampos(out string error)
        {
            error = string.Empty;

            if (string.IsNullOrWhiteSpace(txtnombrePersona.Text))
            {
                error = "El nombre es obligatorio";
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtEdadPersona.Text))
            {
                error = "La edad es obligatoria";
                return false;
            }
            else if (string.IsNullOrWhiteSpace(txtSalarioPersona.Text))
            {
                error = "El salario es obligatorio";
                return false;
            }
            else if (this.cmbExpPersona.SelectedItem is null)
            {
                error = "La experiencia es obligatoria";
                return false;
            }
            else if (this.cmbPuestoPersona.SelectedItem is null)
            {
                error = "El puesto es obligatorio";
                return false;
            }
            else if (this.cmbSexoPersona.SelectedItem is null)
            {
                error = "El sexo es obligatorio";
                return false;
            }

            if (!decimal.TryParse(txtSalarioPersona.Text, out _) || !int.TryParse(txtEdadPersona.Text, out _))
            {
                error = "Error en los campos numericos.";
                return false;
            }

            return true;
        }
        private void CrearPersona()
        {
            int nextId = _encuestaManager.ObtenerSiguienteId<Persona>();
            Persona nuevaPersona = new Persona()
            {
                Id = nextId,
                Nombre = txtnombrePersona.Text,
                Edad = int.Parse(txtEdadPersona.Text),
                Sexo = this.cmbSexoPersona.SelectedItem.ToString(),
                PuestoId = _encuestaManager.GetIdByNombre<Puesto>(this.cmbPuestoPersona.SelectedItem.ToString()),
                ExperienciaId = _encuestaManager.GetIdByNombre<Experiencia>(this.cmbExpPersona.SelectedItem.ToString()),
                Salario = decimal.Parse(txtSalarioPersona.Text)
            };
            _encuestaManager.Personas.Add(nuevaPersona);
        }
        private void EditarPersona()
        {
            _persona.Nombre = txtnombrePersona.Text;
            _persona.Edad = int.Parse(txtEdadPersona.Text);
            _persona.Sexo = this.cmbSexoPersona.SelectedItem.ToString();
            _persona.PuestoId = _encuestaManager.GetIdByNombre<Puesto>(this.cmbPuestoPersona.SelectedItem.ToString());
            _persona.ExperienciaId = _encuestaManager.GetIdByNombre<Experiencia>(this.cmbExpPersona.SelectedItem.ToString());
            _persona.Salario = decimal.Parse(txtSalarioPersona.Text);
        } 
        #endregion
    }
}
