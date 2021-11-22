using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP3.ErrorHandler
{
    public static class ErrorManager
    {
        public static void MostrarException(Exception ex)
        {
            MessageBox.Show($"{ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void MostrarError(string error)
        {
            MessageBox.Show($"{error}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
