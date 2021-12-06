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
    public partial class ConexionForm : Form
    {
        private BasesDatosHelper basesDatos;

        public ConexionForm(BasesDatosHelper basesDatos)
        {
            this.basesDatos = basesDatos;
            InitializeComponent();
        }

        private void btnConnStringAceptar_Click(object sender, EventArgs e)
        {
            string server = this.txtConnString.Text;

            if (string.IsNullOrWhiteSpace(server))
            {
                MessagesHelper.MostrarError("Debe ingresar un servidor.");
            }
            else
            {
                try
                {
                    BasesDatosHelper.ConnectionString = server;

                    if (this.basesDatos.ConexionLograda())
                    {
                        MessagesHelper.MensajeAceptar("¡Conexión exitosa!");
                        this.Close();
                    }
                    else
                    {
                        MessagesHelper.MostrarError("No fue posible realizar la conexión. Revise el servidor.");
                    }

                }
                catch (Exception ex)
                {
                    MessagesHelper.MostrarException(ex);
                }
            }
        }

        private void btnConnStringCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
