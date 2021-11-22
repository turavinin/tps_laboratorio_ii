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
    public partial class FormOperacionesPuesto : Form
    {
        private string _tituloVentana;
        private EncuestaManager _encuestaManager;
        private Puesto _puesto;

        public FormOperacionesPuesto(EncuestaManager encuestaManager, string tituloVentana, int id = 0)
        {
            InitializeComponent();
            _tituloVentana = tituloVentana;
            _encuestaManager = encuestaManager;
            
            if(id > 0)
            {
                _puesto = _encuestaManager.EncontrarRegistroLista<Puesto>(id);
            }
        }

        private void FormOperacionesPuesto_Load(object sender, EventArgs e)
        {
            this.Text = _tituloVentana;

            if(_puesto is not null)
            {
                this.txtIdPuesto.Text = _puesto.Id.ToString();
                this.txtDescPuesto.Text = _puesto.Descripcion;
            }
        }

        private void btnAceptarCambioPuesto_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtDescPuesto.Text))
            {
                ErrorManager.MostrarError("La descripción es obligatoria.");
            }
            else
            {
                if (_puesto is not null)
                {
                    _puesto.Descripcion = this.txtDescPuesto.Text;
                    _encuestaManager.ActualizarEntidad(_puesto);
                }
                else
                {
                    _encuestaManager.GuardarEntidad(new Puesto(this.txtDescPuesto.Text));
                }
            }

            _encuestaManager.CargarListaEntidad<Puesto>();
            this.Close();
        }

        private void btnCancelarCambioPuesto_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
