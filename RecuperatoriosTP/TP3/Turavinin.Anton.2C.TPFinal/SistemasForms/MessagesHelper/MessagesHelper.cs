using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemasForms.ErrorMessages
{
    public class MessagesHelper
    {
        private static List<string> errores;

        public static List<string> Errores { get => MessagesHelper.errores; set => MessagesHelper.errores = value.Count > 0 ? value : MessagesHelper.errores; }

        static MessagesHelper()
        {
            MessagesHelper.errores = new List<string>();
        }

        public static void MostrarException(Exception ex)
        {
            MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MostrarError(string error)
        {
            MessageBox.Show($"{error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MensajeAceptar(string mensaje)
        {
            MessageBox.Show(mensaje);
        }

        public static DialogResult MensajeSiNo(string mensaje, string accion)
        {
            return MessageBox.Show(mensaje, accion, MessageBoxButtons.YesNo);
        }

        public static void MostrarListaErrores(string tituloErrores, bool reiniciarLista = true)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{tituloErrores}");
            if(MessagesHelper.errores.Count > 0)
            {
                foreach(string error in MessagesHelper.Errores)
                {
                    sb.AppendLine($" - {error}");
                }
            }

            if (reiniciarLista)
            {
                MessagesHelper.errores = new List<string>();
            }

            MessagesHelper.MostrarError(sb.ToString());
        }
    }
}
