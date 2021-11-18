using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAS
{
    public partial class CFormulario : Form
    {
        #region // *----------------------------------------------=> Formulario
        // Default
        public CFormulario() { InitializeComponent(); }
        private void InformaExcepcion(Control pControl, string pMensaje)
        {
            try
            {
                ErrorProvider.SetError
                    (
                    pControl,
                    pMensaje
                    );
                MessageBox.Show
                    (
                    pMensaje,
                    "Algo ha fallado...",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            catch (Exception error)
            { InformaExcepcion(LabelInformacion, error.Message); }
        }

        // Variables globales
        string Usuario = String.Empty;

        // UI (Interfaz de Usuario) Eventos
        private void TimerReloj_Tick(object sender, EventArgs e)
        { this.LabelSesion.Text = DateTime.Now.ToString(); }
        // TBOX
        public void TboxAdquiereFoco(object sender, EventArgs e)
        {
            TextBox tbox = (TextBox)sender;
            if (tbox.Text == tbox.Tag.ToString())
            { tbox.Text = String.Empty; }
        }
        public void TboxPierdeFoco(object sender, EventArgs e)
        {
            TextBox tbox = (TextBox)sender;
            if (String.IsNullOrWhiteSpace(tbox.Text))
            { tbox.Text = tbox.Tag.ToString(); }
        }
        // MTBOX
        private void MTboxLegajo_Enter(object sender, EventArgs e)
        { LabelInformacion.Text = "FORMATO DE LEGAJO\n\n4 dígitos"; }
        private void MTboxCodigo_Enter(object sender, EventArgs e)
        { LabelInformacion.Text = "FORMATO DE CÓDIGO\n\n4 dígitos y  4 letras"; }
        private void MTboxLegajo_MouseHover(object sender, EventArgs e)
        { LabelInformacion.Text = "Legajo"; }
        private void MTboxCodigo_MouseHover(object sender, EventArgs e)
        { LabelInformacion.Text = "Código"; }
        // DTP
        private void DtpFechaOtorgamiento_MouseHover(object sender, EventArgs e)
        { LabelInformacion.Text = "Fecha de Otorgamiento"; }
        private void CalFechaCancelacion_MouseHover(object sender, EventArgs e)
        { LabelInformacion.Text = "Fecha de Cancelación"; }
        private void DtpFechaOtorgamiento_Enter(object sender, EventArgs e)
        { LabelInformacion.Text = "Fecha de Otorgamiento"; }
        private void CalFechaCancelacion_Enter(object sender, EventArgs e)
        { LabelInformacion.Text = "Fecha de Cancelación"; }

        // Llamadas internas
        private void IniciaFormulario()
        {
            try
            {
                while (true)
                {
                    if (!String.IsNullOrWhiteSpace(Usuario)) { break; }
                    Usuario = Interaction.InputBox
                        (
                        "Ingrese su nombre:",
                        "Usuario",
                        "Gerardo Tordoya"
                        );
                    if (String.IsNullOrWhiteSpace(Usuario)) { this.Close(); }
                }
                this.CenterToScreen();
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.Text += $" ({Usuario})";
                this.MaximizeBox = false;
                this.MinimizeBox = false;
            }
            catch (Exception error)
            { InformaExcepcion(LabelInformacion, error.Message); }
        }
        private void SimulaPlaceholder()
        {
            try
            {
                foreach (Control x in this.Controls)
                {
                    if (x is GroupBox)
                    {
                        foreach (Control box in x.Controls)
                        {
                            if (box is TextBox)
                            {
                                box.GotFocus += new EventHandler(TboxAdquiereFoco);
                                box.LostFocus += new EventHandler(TboxPierdeFoco);
                            }
                        }
                    }
                }
            }
            catch (Exception error)
            { InformaExcepcion(LabelInformacion, error.Message); }
        }

        // Carga
        private void CFormulario_Load(object sender, EventArgs e)
        {
            try
            {
                IniciaFormulario();
                SimulaPlaceholder();
                TEMPORAL();
            }
            catch (Exception error)
            { InformaExcepcion(LabelInformacion, error.Message); }
        }
        private void TEMPORAL()
        {
            DgvAdelantosPorEmpleado.Rows.Add(new object[] {
                    "Dato 1",
                    "Dato 2",
                    "Dato 3",
                    "Dato 4",
                    "Dato 5",
                    "Dato 6",
                    "Dato 7"
                });
            DgvAdelantosPorEmpleado.Rows.Add(new object[] {
                    "Dato 11",
                    "Dato 12",
                    "Dato 13",
                    "Dato 14",
                    "Dato 15",
                    "Dato 16",
                    "Dato 17"
                });
            DgvTodosLosAdelantos.Rows.Add(new object[] {
                    "Dato 1",
                    "Dato 2",
                    "Dato 3",
                    "Dato 4",
                    "Dato 5",
                    "Dato 6",
                    "Dato 7"
                });
            DgvTodosLosAdelantos.Rows.Add(new object[] {
                    "Dato 11",
                    "Dato 12",
                    "Dato 13",
                    "Dato 14",
                    "Dato 15",
                    "Dato 16",
                    "Dato 17"
                });
            DgvTodosLosEmpleados.Rows.Add(new object[] {
                    "Dato 1",
                    "Dato 2",
                    "Dato 3",
                    "Dato 4"
                });
            DgvTodosLosEmpleados.Rows.Add(new object[] {
                    "Dato 11",
                    "Dato 12",
                    "Dato 13",
                    "Dato 14"
                });
        }

        // Descarga
        private void CFormulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show
                (
                "¿Desea salir de la aplicación?",
                $"{Usuario}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ) == DialogResult.No)
            { e.Cancel = true; }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        #endregion

        #region // *--------------------------------------=> Eventos Operativos
        private void DgvTodosLosEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CmdG1Agregar.Enabled   = true;
            CmdG1Eliminar.Enabled  = false;
            CmdG1Modificar.Enabled = false;
        }
        private void DgvTodosLosEmpleados_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CmdG1Agregar.Enabled = false;
            CmdG1Eliminar.Enabled = true;
            CmdG1Modificar.Enabled = true;

            // PENDIENTE: COPIA DE LOS VALORES DEL DGV A LOS CONTROLES.
        }
        private void DgvTodosLosAdelantos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CmdG2Agregar.Enabled = true;
            CmdG2Eliminar.Enabled = false;
            CmdG2Modificar.Enabled = false;
            /* Hay un evento  de habilitación que falta cuando
             * se puede cobrar o no.
             * Depende de que el objeto tenga o no ya fecha de cancelación.
             * Si tiene, no se habilitan los controles del módulo de pago.
             * Si no tiene, sí, se habilitan.
             */
        }
        private void DgvTodosLosAdelantos_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CmdG2Agregar.Enabled = false;
            CmdG2Eliminar.Enabled = true;
            CmdG2Modificar.Enabled = true;

            // PENDIENTE: COPIA DE LOS VALORES DEL DGV A LOS CONTROLES.

            /* Hay un evento  de habilitación que falta cuando
             * se puede cobrar o no.
             * Depende de que el objeto tenga o no ya fecha de cancelación.
             * Si tiene, no se habilitan los controles del módulo de pago.
             * Si no tiene, sí, se habilitan.
             */
        }
        #endregion
    }
}
