using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formularios2
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new CFormulario());

            //try
            //{
                
            //}
            //catch (Exception error)
            //{
            //    MessageBox.Show
            //        (
            //        error.Message,
            //        "Algo ha fallado...",
            //        MessageBoxButtons.OK,
            //        MessageBoxIcon.Error
            //        );
            //}
        }
    }
}
