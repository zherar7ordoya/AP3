using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARCIAL_1
{
    public partial class CAdministradorDeAdelantos : Form
    {
        #region CARGA
        public CAdministradorDeAdelantos()
        {
            InitializeComponent();

            txtLegajoBeneficiario.GotFocus        += new EventHandler(EventosUnificados);
            txtTipoBeneficiario.GotFocus          += new EventHandler(EventosUnificados);
            txtNombreBeneficiario.GotFocus        += new EventHandler(EventosUnificados);
            txtApellidoBeneficiario.GotFocus      += new EventHandler(EventosUnificados);
            txtSueldoBeneficiario.GotFocus        += new EventHandler(EventosUnificados);

            txtCodigoAdelanto.GotFocus            += new EventHandler(EventosUnificados);
            txtFechaOtorgamientoAdelanto.GotFocus += new EventHandler(EventosUnificados);
            txtFechaCancelacionAdelanto.GotFocus  += new EventHandler(EventosUnificados);
            txtImporteOtorgadoAdelanto.GotFocus   += new EventHandler(EventosUnificados);
            txtImportePagadoAdelanto.GotFocus     += new EventHandler(EventosUnificados);
            txtBeneficioAdelanto.GotFocus         += new EventHandler(EventosUnificados);
            txtSaldoAdeudadoAdelanto.GotFocus     += new EventHandler(EventosUnificados);
        }
        private void CAdministradorDeAdelantos_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        #endregion

        private List<CAdelanto> adelantos = new List<CAdelanto>();
        private List<CEmpleado> empleados = new List<CEmpleado>();

        #region BOTONES
        private void btnAltaBeneficiario_Click(object sender, EventArgs e)
        {
            try
            {
                CEmpleado empleado = new CEmpleado
                                (
                                Convert.ToUInt16(txtLegajoBeneficiario.Text),
                                txtTipoBeneficiario.Text,
                                txtNombreBeneficiario.Text,
                                txtApellidoBeneficiario.Text,
                                Convert.ToDecimal(txtSueldoBeneficiario.Text)
                                );
                empleados.Add(empleado);

                dgvBeneficiarios.DataSource = null;
                dgvBeneficiarios.DataSource = empleados;
                this.dgvBeneficiarios.Columns["Acumulador"].Visible = false;
                this.dgvBeneficiarios.Columns["Contador"].Visible = false;
            }
            catch (Exception excepcion) { CapturadorErrores(excepcion); }
        }
        private void btnBajaBeneficiario_Click(object sender, EventArgs e)
        {
            try
            {
                CEmpleado empleado = empleados.Find(x => x.Legajo == Convert.ToUInt16(txtLegajoBeneficiario.Text));
                empleados.Remove(empleado);

                dgvBeneficiarios.DataSource = null;
                dgvBeneficiarios.DataSource = empleados;
                this.dgvBeneficiarios.Columns["Acumulador"].Visible = false;
                this.dgvBeneficiarios.Columns["Contador"].Visible = false;
            }
            catch (Exception excepcion) { CapturadorErrores(excepcion); }
        }
        private void btnModificacionBeneficiario_Click(object sender, EventArgs e)
        {
            try
            {
                CEmpleado empleado = empleados.Find(x => x.Legajo == Convert.ToUInt16(txtLegajoBeneficiario.Text));
                empleado.Tipo = txtTipoBeneficiario.Text;
                empleado.Nombre = txtNombreBeneficiario.Text;
                empleado.Apellido = txtApellidoBeneficiario.Text;
                empleado.Sueldo = Convert.ToDecimal(txtSueldoBeneficiario.Text);

                dgvBeneficiarios.DataSource = null;
                dgvBeneficiarios.DataSource = empleados;
                this.dgvBeneficiarios.Columns["Acumulador"].Visible = false;
                this.dgvBeneficiarios.Columns["Contador"].Visible = false;
            }
            catch (Exception excepcion) { CapturadorErrores(excepcion); }
        }
        private void btnAltaAdelanto_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception excepcion) { CapturadorErrores(excepcion); }
        }
        private void btnBajaAdelanto_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception excepcion) { CapturadorErrores(excepcion); }
        }
        private void btnModificacionAdelanto_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception excepcion) { CapturadorErrores(excepcion); }
        }
        private void btnAsignarAdelanto_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception excepcion) { CapturadorErrores(excepcion); }
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception excepcion) { CapturadorErrores(excepcion); }
        }
        private void CapturadorErrores(Exception excepcion)
        {
            MessageBox.Show
                (
                excepcion.Message,
                "Error",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
        }
        #endregion

        #region EVENTOS
        private void dgvBeneficiarios_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvAdelantosPorBeneficiario_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }
        private void EventosUnificados(object sender, EventArgs e)
        {
            TextBox origen = (sender as TextBox);
            origen.Text = String.Empty;
        }
        #endregion

        #region DESCARGA
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void CAdministradorDeAdelantos_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show
                (
                "¿Desea salir de esta aplicación?",
                "Pregunta",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion
    }
}
