using System;
using System.Windows.Forms;

namespace Formularios1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new CFormularioPrincipal());
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                    ex.Message,
                    "Excepción capturada",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }
    }
}
