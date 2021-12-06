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
    public partial class PrincipalForm : Form
    {
        private Manager manager;
        private Task tareaListas;

        public PrincipalForm()
        {
            this.manager = new Manager();
            tareaListas = new Task(() => this.CargarListas());

            InitializeComponent();
        }

        private void PrincipalForm_Load(object sender, EventArgs e)
        {
            tareaListas.Start();
        }

        private void btnPrincipalResultados_Click(object sender, EventArgs e)
        {
            bool listaPersonasCargada = this.manager.TotalPersonas > 0;
            if (listaPersonasCargada)
            {
                ResultadosForm resultadosForm = new ResultadosForm(manager);
                resultadosForm.ShowDialog();
            }
            else
            {
                MessagesHelper.MensajeAceptar("No hay datos cargados. Cargue primero algunas personas.");
            }
        }

        private void btnPrincipalPersona_Click(object sender, EventArgs e)
        {
            PersonasForm personasForm = new PersonasForm(this.manager);
            personasForm.ShowDialog();
        }

        private void btnPrincipalRoles_Click(object sender, EventArgs e)
        {
            RolesForm rolesForm = new RolesForm(this.manager);
            rolesForm.ShowDialog();
        }

        private void CargarListas()
        {
            try
            {

                this.manager.CargarListaEntidad<Roles>();
                this.manager.CargarListaEntidad<Persona>();
            }
            catch (Exception ex)
            {
                MessagesHelper.MostrarException(ex);
            }
        }
    }
}
