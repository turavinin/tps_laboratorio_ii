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
    public partial class RolesOperarForm : Form
    {
        private Manager manager;
        private Roles rol;
        private string titulo;
        public bool operacionCancelada;
        public RolesOperarForm(Manager manager, string titulo, int idRol = 0)
        {
            this.titulo = titulo;
            this.manager = manager;
            this.operacionCancelada = false;

            if(idRol > 0)
            {
                this.rol = this.manager.ObtenerEntidadPorId<Roles>(idRol);
            }

            InitializeComponent();
        }

        private void RolesOperarForm_Load(object sender, EventArgs e)
        {
            this.Text = this.titulo;

            if (this.rol is not null)
            {
                this.txtIdRol.Text = this.rol.Id.ToString();
                this.txtDescRol.Text = this.rol.Descripcion;
            }
        }

        private void btnAceptarCambioRol_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtDescRol.Text))
            {
                MessagesHelper.MostrarError("La descripción es obligatoria.");
            }
            else
            {
                if (this.rol is not null)
                {
                    this.rol.Descripcion = this.txtDescRol.Text;
                }
                else
                {
                    this.manager.GuardarEntidad(new Roles(this.manager.ObtenerSiguienteId<Roles>(), this.txtDescRol.Text));
                }

                this.Close();
            }
        }

        private void btnCancelarCambioRol_Click(object sender, EventArgs e)
        {
            this.operacionCancelada = true;
            this.Close();
        }
    }
}
