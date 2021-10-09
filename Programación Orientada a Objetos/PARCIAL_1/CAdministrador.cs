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

            txtLegajoBeneficiario.GotFocus   += new EventHandler(AdquiereFoco);
            txtTipoBeneficiario.GotFocus     += new EventHandler(AdquiereFoco);
            txtNombreBeneficiario.GotFocus   += new EventHandler(AdquiereFoco);
            txtApellidoBeneficiario.GotFocus += new EventHandler(AdquiereFoco);
            txtSueldoBeneficiario.GotFocus   += new EventHandler(AdquiereFoco);

            txtLegajoBeneficiario.Leave   += new EventHandler(PierdeFoco);
            txtTipoBeneficiario.Leave     += new EventHandler(PierdeFoco);
            txtNombreBeneficiario.Leave   += new EventHandler(PierdeFoco);
            txtApellidoBeneficiario.Leave += new EventHandler(PierdeFoco);
            txtSueldoBeneficiario.Leave   += new EventHandler(PierdeFoco);

            txtFechaOtorgamientoAdelanto.GotFocus += new EventHandler(AdquiereFoco);
            txtFechaCancelacionAdelanto.GotFocus  += new EventHandler(AdquiereFoco);
            txtImporteOtorgadoAdelanto.GotFocus   += new EventHandler(AdquiereFoco);
            txtImportePagadoAdelanto.GotFocus     += new EventHandler(AdquiereFoco);
            txtBeneficioAdelanto.GotFocus         += new EventHandler(AdquiereFoco);
            txtSaldoAdeudadoAdelanto.GotFocus     += new EventHandler(AdquiereFoco);

            txtFechaOtorgamientoAdelanto.Leave += new EventHandler(PierdeFoco);
            txtFechaCancelacionAdelanto.Leave  += new EventHandler(PierdeFoco);
            txtImporteOtorgadoAdelanto.Leave   += new EventHandler(PierdeFoco);
            txtImportePagadoAdelanto.Leave     += new EventHandler(PierdeFoco);
            txtBeneficioAdelanto.Leave         += new EventHandler(PierdeFoco);
            txtSaldoAdeudadoAdelanto.Leave     += new EventHandler(PierdeFoco);
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

        #region INTERNALS
        private void ActualizarGrillaAdelantos()
        {
            dgvAdelantos.DataSource = null;
            dgvAdelantos.DataSource = adelantos;
            this.dgvAdelantos.Columns["Bloqueado"].Visible = false;
        }
        private void ActualizarGrillaEmpleados()
        {
            dgvBeneficiarios.DataSource = null;
            dgvBeneficiarios.DataSource = empleados;
            this.dgvBeneficiarios.Columns["Acumulador"].Visible = false;
            this.dgvBeneficiarios.Columns["Contador"].Visible = false;
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
                ActualizarGrillaEmpleados();
                txtLegajoBeneficiario.Text = Convert.ToString(txtLegajoBeneficiario.Tag);
            }
            catch (Exception excepcion) { CapturadorErrores(excepcion); }
        }
        private void btnBajaBeneficiario_Click(object sender, EventArgs e)
        {
            try
            {
                CEmpleado empleado = empleados.Find(x => x.Legajo == Convert.ToUInt16(txtLegajoBeneficiario.Text));
                empleados.Remove(empleado);
                ActualizarGrillaEmpleados();
            }
            catch (Exception excepcion) { CapturadorErrores(excepcion); }
        }
        private void btnModificacionBeneficiario_Click(object sender, EventArgs e)
        {
            try
            {
                CEmpleado empleado = empleados.Find(x => x.Legajo == Convert.ToUInt16(txtLegajoBeneficiario.Text));
                empleado.Tipo      = txtTipoBeneficiario.Text;
                empleado.Nombre    = txtNombreBeneficiario.Text;
                empleado.Apellido  = txtApellidoBeneficiario.Text;
                empleado.Sueldo    = Convert.ToDecimal(txtSueldoBeneficiario.Text);
                ActualizarGrillaEmpleados();
            }
            catch (Exception excepcion) { CapturadorErrores(excepcion); }
        }
        private void btnAltaAdelanto_Click(object sender, EventArgs e)
        {
            try
            {
                CAdelanto adelanto = new CAdelanto
                                (
                                txtCodigoAdelanto.Text,
                                Convert.ToDateTime(txtFechaOtorgamientoAdelanto.Text),
                                Convert.ToDecimal(txtImporteOtorgadoAdelanto.Text)
                                );
                adelantos.Add(adelanto);
                ActualizarGrillaAdelantos();
            }
            catch (Exception excepcion) { CapturadorErrores(excepcion); }
        }
        private void btnBajaAdelanto_Click(object sender, EventArgs e)
        {
            try
            {
                CAdelanto adelanto = adelantos.Find(x => x.CodigoAlfanumerico == txtCodigoAdelanto.Text);
                adelantos.Remove(adelanto);
                ActualizarGrillaAdelantos();
            }
            catch (Exception excepcion) { CapturadorErrores(excepcion); }
        }
        private void btnModificacionAdelanto_Click(object sender, EventArgs e)
        {
            try
            {
                CAdelanto adelanto         = adelantos.Find(x => x.CodigoAlfanumerico == txtCodigoAdelanto.Text);
                adelanto.FechaOtorgamiento = Convert.ToDateTime(txtFechaOtorgamientoAdelanto.Text);
                adelanto.FechaCancelacion  = Convert.ToDateTime(txtFechaCancelacionAdelanto.Text);
                adelanto.ImporteOtorgado   = Convert.ToDecimal(txtImporteOtorgadoAdelanto.Text);
                adelanto.ImportePagado     = Convert.ToDecimal(txtImportePagadoAdelanto.Text);
                adelanto.Beneficio         = Convert.ToDecimal(txtBeneficioAdelanto.Text);
                adelanto.SaldoAdeudado     = Convert.ToDecimal(txtSaldoAdeudadoAdelanto.Text);
                ActualizarGrillaAdelantos();
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
        #endregion

        #region EVENTOS
        private void dgvBeneficiarios_RowEnter(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void dgvAdelantosPorBeneficiario_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

        }
        private void AdquiereFoco(object sender, EventArgs e)
        {
            TextBox origen = (sender as TextBox);
            origen.Text = String.Empty;
        }
        private void PierdeFoco(object sender, EventArgs e)
        {
            TextBox origen = (sender as TextBox);
            if (origen.Text == String.Empty)
            {
                origen.Text = Convert.ToString(origen.Tag);
            }
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
