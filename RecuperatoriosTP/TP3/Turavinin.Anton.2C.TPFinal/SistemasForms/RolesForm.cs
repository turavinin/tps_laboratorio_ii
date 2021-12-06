using Entidades;
using Entidades.Archivos;
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
    public partial class RolesForm : Form
    {
        private Manager manager;
        public RolesForm(Manager manager)
        {
            this.manager = manager;
            InitializeComponent();
        }

        private void RolesForm_Load(object sender, EventArgs e)
        {
            this.ActualizarRoles();
        }

        private void btnAgregarRol_Click(object sender, EventArgs e)
        {
            RolesOperarForm operarForm = new RolesOperarForm(this.manager, "Agregar Rol");
            operarForm.FormClosed += this.ActualizarAlCerrar;
            operarForm.ShowDialog();
        }

        private void btnEditarRol_Click(object sender, EventArgs e)
        {
            bool hayRegistros = this.manager.ListaRoles.Count > 0;
            if (hayRegistros)
            {
                int idRol = this.ObtenerIdSeleccionado();
                RolesOperarForm operarForm = new RolesOperarForm(this.manager, "Editar Rol", idRol);
                operarForm.FormClosed += this.ActualizarAlCerrar;
                operarForm.ShowDialog();
            }
            else
            {
                MessagesHelper.MensajeAceptar("No hay registros para editar.");
            }
        }

        private void btnEliminarRol_Click(object sender, EventArgs e)
        {
            if (this.dgvListaRoles.SelectedRows.Count > 0)
            {
                int idRol = this.ObtenerIdSeleccionado();

                if (this.manager.ListaPersonas.Where(x => x.RolId == idRol).FirstOrDefault() != null)
                {
                    MessagesHelper.MostrarError("Hay personas que tienen cargado el rol. Primero elimine a las personas.");
                }
                else if (DialogResult.Yes == MessagesHelper.MensajeSiNo("¿Esta seguro de querer eliminar el puesto?", "Eliminar"))
                {
                    if (manager.EliminarEntidad<Roles>(idRol))
                    {
                        this.ActualizarRoles();
                    }
                }
            }
            else
            {
                MessagesHelper.MensajeAceptar("No hay registros para eliminar.");
            }
        }

        private void ActualizarAlCerrar(object sender, FormClosedEventArgs e)
        {
            this.ActualizarRoles();
        }

        private void ActualizarRoles()
        {

            if (this.manager.ListaRoles.Count > 0)
            {
                this.dgvListaRoles.Rows.Clear();
                this.manager.ListaRoles.ForEach(x => this.dgvListaRoles.Rows.Add(x.Id, x.Descripcion));
                Task guardarArchivos = Task.Run(() => JsonHelper<List<Roles>>.Exportar(this.manager.ListaRoles, "roles.json"));
            }
        }

        private int ObtenerIdSeleccionado()
        {
            return int.Parse(this.dgvListaRoles.SelectedRows[0].Cells[0].Value.ToString());
        }
    }
}
