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
        List<CEmpleado> TodosLosEmpleados = new List<CEmpleado>();
        List<CAdelanto> TodosLosAdelantos = new List<CAdelanto>();

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
            }
            catch (Exception error)
            { InformaExcepcion(LabelInformacion, error.Message); }
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
            CmdG1Agregar.Enabled = true;
            CmdG1Eliminar.Enabled = false;
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

        #region // *------------------------------------------------=> Comandos
        private void CmdG1Agregar_Click(object sender, EventArgs e)
        {
            // Verificaciones
            // Operaciones
            try
            {

            }
            catch (Exception error)
            { InformaExcepcion(LabelInformacion, error.Message); }
            // Adendas
        }

        private void CmdG1Eliminar_Click(object sender, EventArgs e)
        {
            // Verificaciones
            // Operaciones
            try
            {

            }
            catch (Exception error)
            { InformaExcepcion(LabelInformacion, error.Message); }
            // Adendas
        }

        private void CmdG1Modificar_Click(object sender, EventArgs e)
        {
            // Verificaciones
            // Operaciones
            try
            {

            }
            catch (Exception error)
            { InformaExcepcion(LabelInformacion, error.Message); }
            // Adendas
        }

        private void CmdG2Agregar_Click(object sender, EventArgs e)
        {
            // Verificaciones
            // Operaciones
            try
            {

            }
            catch (Exception error)
            { InformaExcepcion(LabelInformacion, error.Message); }
            // Adendas
        }

        private void CmdG2Eliminar_Click(object sender, EventArgs e)
        {
            // Verificaciones
            // Operaciones
            try
            {

            }
            catch (Exception error)
            { InformaExcepcion(LabelInformacion, error.Message); }
            // Adendas
        }

        private void CmdG2Modificar_Click(object sender, EventArgs e)
        {
            // Verificaciones
            // Operaciones
            try
            {

            }
            catch (Exception error)
            { InformaExcepcion(LabelInformacion, error.Message); }
            // Adendas
        }

        private void CmdG2Asignar_Click(object sender, EventArgs e)
        {
            // Verificaciones
            // Operaciones
            try
            {

            }
            catch (Exception error)
            { InformaExcepcion(LabelInformacion, error.Message); }
            // Adendas
        }

        private void CmdG2Pagar_Click(object sender, EventArgs e)
        {
            // Verificaciones
            // Operaciones
            try
            {

            }
            catch (Exception error)
            { InformaExcepcion(LabelInformacion, error.Message); }
            // Adendas
        }
        #endregion
    }

    #region CLASES
    public abstract class CEmpleado
    {
        // Atributos
        private int legajo;
        private string nombre;
        private string apellido;
        private decimal sueldo;
        private List<CAdelanto> Adelantos = new List<CAdelanto>();
        // Propiedades
        // Constructores
        public CEmpleado
            (
            int     pLegajo,
            string  pNombre,
            string  pApellido,
            decimal pSueldo
            )
        {
            this.legajo   = pLegajo;
            this.nombre   = pNombre;
            this.apellido = pApellido;
            this.sueldo   = pSueldo;
        }

        // Métodos
        public abstract decimal AplicaBeneficio(decimal pImporteOtorgado);
        public void TomaBeneficio(CAdelanto pAdelanto) { Adelantos.Add(pAdelanto); }
        public List<CAdelanto> MuestraOtorgados() { return Adelantos; }
        //public List<CAdelanto> VerAdeudados()
        //{
        //    var filtrada = new List<CAdelanto>(Adelantos);
        //    filtrada.Where(x => x.FechaCancelacion != null).ToList();
        //    return filtrada;
        //}
    }

    public class COperario : CEmpleado
    {
        // Atributos
        // Propiedades
        // Constructores
        public COperario
            (
            int     pLegajo,
            string  pNombre,
            string  pApellido,
            decimal pSueldo
            ) : base
                (
                pLegajo,
                pNombre,
                pApellido,
                pSueldo
                )
        { }

        // Métodos
        public override decimal AplicaBeneficio(decimal pImporteOtorgado)
        { return pImporteOtorgado * (decimal)0.1; }
    }

    public class CAdministrativo : CEmpleado
    {
        // Atributos
        // Propiedades
        // Constructores
        public CAdministrativo
            (
            int     pLegajo,
            string  pNombre,
            string  pApellido,
            decimal pSueldo
            ) : base
                (
                pLegajo,
                pNombre,
                pApellido,
                pSueldo
                )
        { }

        // Métodos
        public override decimal AplicaBeneficio(decimal pImporteOtorgado)
        { return pImporteOtorgado * (decimal)0.05; }
    }

    public class CDirectivo : CEmpleado
    {
        // Atributos
        // Propiedades
        // Constructores
        public CDirectivo
            (
            int     pLegajo,
            string  pNombre,
            string  pApellido,
            decimal pSueldo
            ) : base
                (
                pLegajo,
                pNombre,
                pApellido,
                pSueldo
                )
        { }


        // Métodos
        public override decimal AplicaBeneficio(decimal pImporteOtorgado)
        { return pImporteOtorgado * (decimal)0.01; }
    }

    public class CAdelanto
    {
        // Atributos
        private string codigo;
        private DateTime fechaOtorgamiento;
        private decimal importeOtorgado;
        private decimal beneficio;
        private decimal saldoAdeudado;
        private DateTime fechaCancelacion;
        private decimal importePagado;

        // Propiedades
        public DateTime FechaCancelacion { get => fechaCancelacion; set => fechaCancelacion = value; }

        // Constructores
        public CAdelanto
            (
            string   pCodigo,
            DateTime pFechaOtorgamiento,
            decimal  pImporteOtorgado
            )
        {
            this.codigo = pCodigo;

        }
        // Métodos
    }
    #endregion
}
