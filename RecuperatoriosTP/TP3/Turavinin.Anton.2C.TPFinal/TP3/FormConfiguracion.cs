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
    public partial class FormConfiguracion : Form
    {
        private EncuestaManager _encuestaManager;
        public FormConfiguracion(EncuestaManager encuestaManager)
        {
            InitializeComponent();
            _encuestaManager = encuestaManager;
        }

        private void FormConfiguracion_Load(object sender, EventArgs e)
        {
            this.ActualizarListaPuesto(_encuestaManager.Puestos);
        }

        private void btnAgregarPuesto_Click(object sender, EventArgs e)
        {
            Puesto nuevoPuesto = new Puesto();
            FormOperacionesPuesto formOperacionesPuesto = new FormOperacionesPuesto(_encuestaManager, "Agregar Puesto");
            formOperacionesPuesto.ShowDialog();
            this.ActualizarListaPuesto(_encuestaManager.Puestos);
        }

        private void btnEditarPuesto_Click(object sender, EventArgs e)
        {
            int id = this.GetIdOfPuestos();
            FormOperacionesPuesto formOperacionesPuesto = new FormOperacionesPuesto(_encuestaManager, "Editar Puesto", id);
            formOperacionesPuesto.ShowDialog();
            this.ActualizarListaPuesto(_encuestaManager.Puestos);
        }

        private void btnEliminarPuesto_Click(object sender, EventArgs e)
        {
            int id = this.GetIdOfPuestos();
            var confirmacion = MessageBox.Show("¿Esta seguro de querer eliminar el puesto?",
                                               "Eliminar", MessageBoxButtons.YesNo);

            if(confirmacion == DialogResult.Yes)
            {
                var puesto = _encuestaManager.EncontrarRegistro<Puesto>(id);
                _encuestaManager.EliminarRegistro(puesto);
                _encuestaManager.GuardarEntidad(_encuestaManager.Puestos, "puestos.json");
                this.ActualizarListaPuesto(_encuestaManager.Puestos);
            }

        }


        #region Metodos Privados
        private int GetIdOfPuestos()
        {
            return int.Parse(this.dgvPuestos.SelectedRows[0].Cells[0].Value.ToString());
        }

        private void ActualizarListaPuesto(List<Puesto> puestos)
        {
            this.dgvPuestos.Rows.Clear();
            puestos.ForEach(x => this.dgvPuestos.Rows.Add(x.Id, x.Descripcion));
        } 
        #endregion
    }
}
