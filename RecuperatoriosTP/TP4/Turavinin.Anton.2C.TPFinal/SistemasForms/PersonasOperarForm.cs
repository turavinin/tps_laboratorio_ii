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
    public partial class PersonasOperarForm : Form
    {
        private Manager manager;
        private Persona persona;
        private string titulo;

        public PersonasOperarForm(Manager manager, string titulo, int idPersona = 0)
        {
            this.manager = manager;
            this.titulo = titulo;

            if (idPersona > 0)
            {
                this.persona = manager.ObtenerEntidadPorId<Persona>(idPersona);
            }

            InitializeComponent();
        }

        private void PersonasOperarForm_Load(object sender, EventArgs e)
        {
            this.Text = this.titulo;
            this.CargarCmb();

            if(this.persona is not null)
            {
                this.CargarFormulario();
            }
        }

        private void btnAceptarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                if (!VerificacionCorrecta())
                {
                    MessagesHelper.MostrarListaErrores("Se encontraron los siguientes errores de validación:");
                }
                else
                {
                    if (this.persona is not null)
                    {
                        this.EditarPersona();
                        this.manager.ActualizarEntidad<Persona>(this.persona);
                    }
                    else
                    {
                        this.manager.GuardarEntidad<Persona>(this.CrearPersona());
                    }

                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessagesHelper.MostrarException(ex);
            }

        }

        private void btnCancelarPersona_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargarCmb()
        {
            List<Genero> enumsGenero = this.manager.ObtenerListaEnum<Genero>();
            enumsGenero.ForEach(x => this.cmbGeneroPersona.Items.Add(x.ToString()));

            List<Experiencia> enumsExp = this.manager.ObtenerListaEnum<Experiencia>();
            enumsExp.ForEach(x => this.cmbExpPersona.Items.Add(x.ToString()));

            if (this.manager.ListaRoles.Count > 0)
            {
                this.manager.ListaRoles.ForEach(x => this.cmbRolPersona.Items.Add(x.Descripcion));
            }
        }

        private void CargarFormulario()
        {
            Roles rol = this.manager.ObtenerEntidadPorId<Roles>(this.persona.RolId);

            this.txtIdPersona.Text = this.persona.Id.ToString();
            this.txtnombrePersona.Text = this.persona.Nombre.ToString();
            this.txtEdadPersona.Text = this.persona.Edad.ToString();
            this.txtSalarioPersona.Text = this.persona.Salario.ToString("N");
            this.cmbGeneroPersona.SelectedIndex = this.cmbGeneroPersona.Items.IndexOf(this.persona.Genero);
            this.cmbRolPersona.SelectedIndex = this.cmbRolPersona.Items.IndexOf(rol.Descripcion);
            this.cmbExpPersona.SelectedIndex = this.cmbExpPersona.Items.IndexOf(this.persona.Experiencia);
        }

        private bool VerificacionCorrecta()
        {
            bool retorno = true;

            if (string.IsNullOrWhiteSpace(txtnombrePersona.Text))
            {
                MessagesHelper.Errores.Add("El nombre es obligatorio");
                retorno = false;
            }

            if (string.IsNullOrWhiteSpace(txtEdadPersona.Text))
            {
                MessagesHelper.Errores.Add("La edad es obligatoria");
                retorno = false;
            }
            else
            {
                if (!int.TryParse(txtEdadPersona.Text, out _))
                {
                    MessagesHelper.Errores.Add("La edad debe ser un número entero.");
                    retorno = false;
                }
            }

            if (string.IsNullOrWhiteSpace(txtSalarioPersona.Text))
            {
                MessagesHelper.Errores.Add("El salario es obligatorio");
                retorno = false;
            }
            else
            {
                if (!decimal.TryParse(txtSalarioPersona.Text, out _))
                {
                    MessagesHelper.Errores.Add("El salario debe ser un número");
                    retorno = false;
                }
            }

            if (this.cmbGeneroPersona.SelectedItem is null)
            {
                MessagesHelper.Errores.Add("El género es obligatorio");
                retorno = false;
            }

            if (this.cmbRolPersona.SelectedItem is null)
            {
                MessagesHelper.Errores.Add("El rol es obligatorio");
                retorno = false;
            }

            if (this.cmbExpPersona.SelectedItem is null)
            {
                MessagesHelper.Errores.Add("La experiencia es obligatoria");
                retorno = false;
            }

            return retorno;
        }

        private Persona CrearPersona()
        {
            Persona persona = new Persona()
            {
                Nombre = txtnombrePersona.Text,
                Edad = int.Parse(txtEdadPersona.Text),
                Genero = this.cmbGeneroPersona.SelectedItem.ToString(),
                RolId = manager.ObtenerIdPorNombreEnLista<Roles>(this.cmbRolPersona.SelectedItem.ToString()),
                Experiencia = this.cmbExpPersona.SelectedItem.ToString(),
                Salario = decimal.Parse(txtSalarioPersona.Text)
            };

            return persona;
        }

        private void EditarPersona()
        {
            this.persona.Nombre = txtnombrePersona.Text;
            this.persona.Edad = int.Parse(txtEdadPersona.Text);
            this.persona.Genero = this.cmbGeneroPersona.SelectedItem.ToString();
            this.persona.RolId = manager.ObtenerIdPorNombreEnLista<Roles>(this.cmbRolPersona.SelectedItem.ToString());
            this.persona.Experiencia = this.cmbExpPersona.SelectedItem.ToString();
            this.persona.Salario = decimal.Parse(txtSalarioPersona.Text);
        }
    }
}
