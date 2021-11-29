using Entidades;
using Entidades.BasesDatos;
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
    public partial class PersonasForm : Form
    {
        private Manager manager;

        public PersonasForm(Manager manager)
        {
            this.manager = manager;
            InitializeComponent();
        }

        private void PersonasForm_Load(object sender, EventArgs e)
        {
            this.ActualizarPersonas();
        }

        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            bool listaRolesCargada = this.manager.ListaRoles.Count > 0;
            if (BasesDatosHelper.conexionLograda && listaRolesCargada)
            {
                PersonasOperarForm personaOperarForm = new PersonasOperarForm(this.manager, "Agregar Persona");
                personaOperarForm.FormClosed += this.ActualizarAlCerrar;
                personaOperarForm.ShowDialog();
            }
            else
            {
                if (!BasesDatosHelper.conexionLograda) MessagesHelper.MensajeAceptar("Por favor primero conectese a una base.");
                else if (!listaRolesCargada) MessagesHelper.MensajeAceptar("Es necesario cargar primero los roles.");

            }
        }

        private void btnEditarPersona_Click(object sender, EventArgs e)
        {
            bool hayRegistros = this.manager.ListaPersonas.Count > 0;
            if (BasesDatosHelper.conexionLograda && hayRegistros)
            {
                int idPersona = this.ObtenerIdSeleccionado();
                PersonasOperarForm personaOperarForm = new PersonasOperarForm(this.manager, "Editar Persona", idPersona);
                personaOperarForm.FormClosed += this.ActualizarAlCerrar;
                personaOperarForm.ShowDialog();
            }
            else
            {
                if (!BasesDatosHelper.conexionLograda) MessagesHelper.MensajeAceptar("Por favor primero conectese a una base.");
                else MessagesHelper.MensajeAceptar("No hay registros para editar.");
            }
        }

        private void btnEliminarPersona_Click(object sender, EventArgs e)
        {
            if (this.dgvPersonas.SelectedRows.Count > 0)
            {
                int idPersona = this.ObtenerIdSeleccionado();
                if (DialogResult.Yes == MessagesHelper.MensajeSiNo("¿Esta seguro de querer eliminar a la persona?", "Eliminar"))
                {
                    if (manager.EliminarEntidad<Persona>(idPersona))
                    {
                        this.ActualizarPersonas();
                    }
                }
            }
            else
            {
                MessagesHelper.MensajeAceptar("No hay registros para eliminar.");
            }
        }

        private void ActualizarPersonas()
        {
            try
            {
                if (BasesDatosHelper.conexionLograda)
                {
                    this.manager.CargarListaEntidad<Persona>();
                    this.dgvPersonas.Rows.Clear();
                    if (this.manager.ListaPersonas.Count > 0)
                    {
                        this.manager.ListaPersonas.ForEach(x => this.CargarPersonaALista(x));
                    }
                }
            }
            catch (Exception ex)
            {
                MessagesHelper.MostrarException(ex);
            }
        }

        private void CargarPersonaALista(Persona persona)
        {
            Roles rol = this.manager.ObtenerEntidadPorId<Roles>(persona.RolId);

            if (rol is not null)
            {
                this.dgvPersonas.Rows.Add(persona.Id, persona.Nombre, persona.Edad, persona.Genero, rol.Descripcion, persona.Experiencia, persona.Salario.ToString("N"));
            }
        }

        private void ActualizarAlCerrar(object sender, FormClosedEventArgs e)
        {
            this.ActualizarPersonas();
        }

        private int ObtenerIdSeleccionado()
        {
            return int.Parse(this.dgvPersonas.SelectedRows[0].Cells[0].Value.ToString());

        }
    }
}
