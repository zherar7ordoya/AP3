using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SistemaDeCobranzas
{
    public partial class CFormulario : Form
    {
        string          usuario   = String.Empty;

        List<CCliente>  clientes  = new List<CCliente>();
        List<CPago>     ordenable = new List<CPago>();
        List<CReducida> reducida  = new List<CReducida>();

        CCliente        cliente   = null;
        CCobro          cobro     = null;
        CPago           pago      = null;

        #region // *----------------------------------------------=> Formulario
        public CFormulario() { InitializeComponent(); }

        // *-----------------------------------------------------------=> CARGA
        private void DefineUsuario()
        {
            while (true)
            {
                if (!String.IsNullOrWhiteSpace(usuario)) { break; }
                usuario = Interaction.InputBox
                    (
                    "Ingrese su nombre:",
                    "Usuario",
                    "Gerardo Tordoya"
                    );
                if (String.IsNullOrWhiteSpace(usuario)) { this.Close(); }
            }
        }
        private void PersonalizaFormulario()
        {
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text += $" ({usuario})";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        private void IniciaFormulario()
        {
            DefineUsuario();
            PersonalizaFormulario();
        }
        public void TboxAdquiereFoco(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
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
        private void SimulaPlaceholder()
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
        private void CFormulario_Load(object sender, EventArgs e)
        {
            IniciaFormulario();
            SimulaPlaceholder();
            LabelInformacion.Text  = "Para empezar, necesita crear clientes. Luego\n";
            LabelInformacion.Text += "podrá crear los cobros que se\n";
            LabelInformacion.Text += "les imputarán.";
            ErrorProvider.SetError(this.TboxLegajoCliente, "Empiece aquí");
        }

        // *------------------------------------------------=> BACKGROUND WORLD
        //private void TimerReloj_Tick(object sender, EventArgs e)
        //{ this.LabelSesion.Text = $"Sesión de {usuario} || {DateTime.Now}"; }
        private void InformaExcepcion(Control pControl, string pMensaje)
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
        private bool ConfirmaOperacion(string pMensaje)
        {
            if (MessageBox.Show
                    (
                    pMensaje,
                    $"{usuario}",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    ) == DialogResult.Yes)
            {
                return true;
            }
            return false;
        }


        private void SeleccionaFila()
        {
            // Caso 1: G1 sí, G2 no
            if (
                DgvListaClientes.SelectedRows.Count > 0 &&
                DgvListaPendientes.SelectedRows.Count == 0
                )
            {
                MessageBox.Show("Caso 1: G1 sí, G2 no");
                SeleccionaCliente();
                // En G1
                TboxLegajoCliente.Enabled = false;
                TboxNombreCliente.Enabled = true;
                CmdAltaCliente.Enabled = false;
                CmdModificaCliente.Enabled = true;
                CmdBajaCliente.Enabled = true;

                // En G2
                CheckTipoCobro.Enabled = true;
                TboxCodigoCobro.Enabled = true;
                TboxNombreCobro.Enabled = true;
                DtpFechaVencimientoCobro.Enabled = true;
                TboxImporteCobro.Enabled = true;
                CmdAltaCobro.Enabled = true;
                CmdPagaCobro.Enabled = false;
            }
            // Caso 1: G1 sí, G2 sí
            else
            {
                MessageBox.Show("Caso 2: G1 sí, G2 sí");
            }
        }

        private void SeleccionaCliente()
        {
            try
            {
                cliente = (CCliente)
                    (this.DgvListaClientes.SelectedRows[0].DataBoundItem);
                ordenable = cliente.VerCancelados();
                reducida = cliente.VerCancelados().Select(x => new CReducida()
                {
                    Nombre = x.Cliente,
                    Total = x.Total
                }).ToList();

                // En G1
                //DgvListaClientes.DataSource = null;
                //DgvListaClientes.DataSource = clientes;

                // En G2
                DgvListaPendientes.DataSource = null;
                DgvListaPendientes.DataSource = cliente.VerPendientes();

                // En G3
                DgvListaCanceladosG3.DataSource = null;
                DgvListaCanceladosG3.DataSource = cliente.VerCancelados();

                // En G4
                DgvListaCanceladosG4.DataSource = null;
                DgvListaCanceladosG4.DataSource = ordenable;
                RadioAscendente.Checked = false;
                RadioDescendente.Checked = false;
                RadioAscendente.Enabled = true;
                RadioDescendente.Enabled = true;

                // En G5
                DgvListaCanceladosG5.DataSource = null;
                DgvListaCanceladosG5.DataSource = reducida;
            }
            catch (Exception error)
            { InformaExcepcion(LabelInformacion, error.Message); }
        }


        private void Pago_OnTotalChanged(object sender, decimal e)
        {
            var x = (CPago)sender;
            if (x.Total > 10000)
            {
                MessageBox.Show
                    (
                    "El cobro a cancelar supera los $10.000",
                    $"{usuario}",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                    );
            }
        }

        // *--------------------------------------------------------=> DESCARGA
        private void CFormulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show
                (
                "¿Desea salir de la aplicación?",
                $"{usuario}",
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

        #region // *---------------------------------------=> GRUPO 1 (Eventos)
        private void DgvListaClientes_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            try
            {
                //if (DgvListaClientes.SelectedRows.Count > 0)
                //{
                //    cliente = (CCliente)DgvListaClientes.SelectedRows[0].DataBoundItem; 
                //    if (cliente.VerPendientes().Count > 0)
                //    { this.DgvListaPendientes.DataSource = cliente.VerPendientes(); }
                //}

                // En G1
                this.TboxLegajoCliente.Text          = this.TboxLegajoCliente.Tag.ToString();
                this.TboxNombreCliente.Text          = this.TboxNombreCliente.Tag.ToString();
                this.TboxLegajoCliente.Enabled       = true;
                this.CmdAltaCliente.Enabled          = true;
                this.CmdModificaCliente.Enabled      = false;
                this.CmdBajaCliente.Enabled          = false;

                // En G2
                this.DgvListaPendientes.DataSource   = null;
                //this.CmdAltaCobro.Enabled            = false;
                //this.CmdPagaCobro.Enabled            = false;

                // En G3
                this.DgvListaCanceladosG3.DataSource = null;

                // En G4
                this.DgvListaCanceladosG4.DataSource = null;

                // En G5
                this.DgvListaCanceladosG5.DataSource = null;
            }
            catch (Exception error)
            { InformaExcepcion(LabelInformacion, error.Message); }

        }
        private void DgvListaClientes_RowHeaderMouseClick(
            object sender,
            DataGridViewCellMouseEventArgs e)
        {
            SeleccionaFila();
            //try
            //{
            //    cliente = (CCliente)
            //        (this.DgvListaClientes.SelectedRows[0].DataBoundItem);

            //    TboxLegajoCliente.Text = DgvListaClientes
            //        .Rows[e.RowIndex]
            //        .Cells[0]
            //        .Value
            //        .ToString();
            //    TboxNombreCliente.Text = DgvListaClientes
            //        .Rows[e.RowIndex]
            //        .Cells[1]
            //        .Value
            //        .ToString();

            //    // En G1
            //    TboxLegajoCliente.Enabled = false;
            //    CmdAltaCliente.Enabled = false;
            //    CmdModificaCliente.Enabled = true;
            //    CmdBajaCliente.Enabled = true;

            //    // En G2
            //    CmdAltaCobro.Enabled = true;
            //    CmdPagaCobro.Enabled = false;

            //    DgvListaPendientes.DataSource = null;

            //    if (cliente.VerPendientes() != null && cliente.VerPendientes().Count > 0)
            //    { DgvListaPendientes.DataSource = cliente.VerPendientes(); }

            //    // En G3
            //    // En G4
            //    // En G5
            //}
            //catch (Exception error)
            //{ InformaExcepcion(LabelInformacion, error.Message); }
        }
        #endregion
        
        #region // *-----------------------------------=> GRUPO 1 (Operaciones)
        private void CmdAltaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificaciones
                ErrorProvider.Clear();

                if (
                    TboxLegajoCliente.Text == string.Empty ||
                    TboxNombreCliente.Text == string.Empty
                    )
                { throw new Exception("No pueden haber campos vacíos"); }

                else if (!Regex.Match(
                    TboxNombreCliente.Text,
                    "^[A-Z][A-zÀ-ú ]*$").Success)
                { throw new Exception("Use un nombre propio que empiece con mayúscula (Ej.: Fulano)"); }

                else if(clientes.Any(
                    x => x.Legajo == Int32.Parse(TboxLegajoCliente.Text)
                    ))
                { throw new Exception("Los legajos deben ser diferentes."); }

                // Operaciones
                if (ConfirmaOperacion("¿Confirma Alta del Cliente?"))
                {
                    clientes.Add(new CCliente
                        (
                        Int32.Parse(TboxLegajoCliente.Text),
                        TboxNombreCliente.Text
                        ));
                    DgvListaClientes.DataSource = null;
                    DgvListaClientes.DataSource = clientes;
                }
                // Adendas
                this.LabelInformacion.Text  = "Alta exitosa.\n";
                this.LabelInformacion.Text += "Si lo desea, puede proceder a un alta de cobro.\n";
                this.LabelInformacion.Text += "Para ello, debe seleccionar al cliente ";
                this.LabelInformacion.Text += "haciendo click en la cabecera de fila.";
                DgvListaClientes_CellClick(this, null);
                this.TboxLegajoCliente.Focus();
            }
            catch (Exception error)
            { InformaExcepcion(LabelInformacion, error.Message); }
        }
        private void CmdBajaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificaciones
                /* --- NADA AÚN --- */

                // Operaciones
                if (ConfirmaOperacion("¿Confirma Baja del Cliente?"))
                {
                    this.clientes.Remove(cliente);
                    DgvListaClientes.DataSource = null;
                    DgvListaClientes.DataSource = clientes;
                }

                // Adendas
                DgvListaClientes_CellClick(this, null);
                this.TboxLegajoCliente.Focus();
            }
            catch (Exception error)
            { InformaExcepcion(LabelInformacion, error.Message); }
        }
        private void CmdModificaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificaciones
                /* --- NADA AÚN --- */

                // Operaciones
                if (ConfirmaOperacion("¿Confirma Modificación del Cliente"))
                {
                    cliente.NombreCliente = TboxNombreCliente.Text;
                    DgvListaClientes.DataSource = null;
                    DgvListaClientes.DataSource = clientes;
                }

                // Adendas
                /* --- NADA AÚN --- */
            }
            catch (Exception error)
            { InformaExcepcion(LabelInformacion, error.Message); }
        }
        #endregion

        #region // *---------------------------------------=> GRUPO 2 (Eventos)
        private void DgvListaPendientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.CheckTipoCobro.Checked   = false;
                TboxCodigoCobro.Text          = String.Empty;
                TboxNombreCobro.Text          = String.Empty;
                DtpFechaVencimientoCobro.Value = DateTime.Today.AddDays(-1);
                TboxImporteCobro.Text              = String.Empty;

                CmdAltaCobro.Enabled = true;
                CmdPagaCobro.Enabled     = false;

                /*
                 * COORDINACIÓN ENTRE GRUPOS
                 */
                // *-----------------=> Para G1
                // *-----------------=> Para G2
                this.LabelInformacion.Text = String.Empty;

                // *-----------------=> Para G4

            }
            catch (Exception error)
            { InformaExcepcion(LabelInformacion, error.Message); }
        }

        private void DgvListaPendientes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            SeleccionaFila();
            //try
            //{
            //    cliente = (CCliente)
            //        (this.DgvListaClientes.SelectedRows[0].DataBoundItem);
            //    cobro = (CCobro)
            //        (this.DgvListaPendientes.SelectedRows[0].DataBoundItem);

            //    if (cobro.Tipo == "Especial") { this.CheckTipoCobro.Checked = true; }

            //    TboxCodigoCobro.Text          = cobro.Codigo.ToString();
            //    TboxNombreCobro.Text          = cobro.NombreCobro;
            //    DtpFechaVencimientoCobro.Value = cobro.FechaVencimiento;
            //    TboxImporteCobro.Text              = cobro.Importe.ToString();

            //    CmdAltaCobro.Enabled = false;
            //    CmdPagaCobro.Enabled     = true;

            //    /*
            //     * COORDINACIÓN ENTRE GRUPOS
            //     */
            //    // *-----------------=> Para G1
            //    // *-----------------=> Para G2
            //    this.LabelInformacion.Text = String.Empty;

            //    // *-----------------=> Para G4

            //}
            //catch (Exception error)
            //{ InformaExcepcion(LabelInformacion, error.Message); }
        }
        #endregion

        #region // *-----------------------------------=> GRUPO 2 (Operaciones)
        // CMD
        private void CmdAltaCobro_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificaciones
                ErrorProvider.Clear();
                if (DgvListaClientes.SelectedRows.Count == 0)
                { throw new Exception("Debe seleccionar un cliente.\n" +
                    "Puede hacerlo con un click en su cabecera de fila."); }
                else if (
                    TboxCodigoCobro.Text == string.Empty ||
                    TboxNombreCobro.Text == string.Empty ||
                    TboxImporteCobro.Text == string.Empty
                    ) { throw new Exception("No pueden haber campos vacíos"); }

                cliente = (CCliente)DgvListaClientes.SelectedRows[0].DataBoundItem;

                if (cliente.EsDuplicado(Int32.Parse(TboxCodigoCobro.Text)))
                { throw new Exception("Los códigos de cobro no deben repetirse"); }
                else if(cliente.VerPendientes().Count > 1)
                { throw new Exception("El cliente no puede tener más de dos pendientes"); }

                // Operaciones
                if (ConfirmaOperacion("¿Confirma Alta del Cobro?"))
                {
                    if (CheckTipoCobro.Checked)
                    {
                        cobro = new CCobroEspecial
                            (
                            "Especial",
                            Int32.Parse(TboxCodigoCobro.Text),
                            TboxNombreCobro.Text,
                            DtpFechaVencimientoCobro.Value,
                            decimal.Parse(TboxImporteCobro.Text),
                            TboxNombreCliente.Text
                            );
                        cliente.AltaPendiente(cobro);
                    }
                    else
                    {
                        cobro = new CCobroNormal
                            (
                            "Normal",
                            Int32.Parse(TboxCodigoCobro.Text),
                            TboxNombreCobro.Text,
                            DtpFechaVencimientoCobro.Value,
                            decimal.Parse(TboxImporteCobro.Text),
                            TboxNombreCliente.Text
                            );
                        cliente.AltaPendiente(cobro);
                    }
                    this.DgvListaPendientes.DataSource = null;
                    if (cliente.VerPendientes() != null && cliente.VerPendientes().Count > 0)
                    { this.DgvListaPendientes.DataSource = cliente.VerPendientes(); }
                }

                // Adendas
                CheckTipoCobro.Checked        = false;
                TboxCodigoCobro.Text          = String.Empty;
                TboxNombreCobro.Text          = String.Empty;
                DtpFechaVencimientoCobro.Value = DateTime.Now;
                TboxImporteCobro.Text              = String.Empty;
            }
            catch (Exception error)
            { InformaExcepcion(LabelInformacion, error.Message); }
        }

        private void CmdPagar_Click(object sender, EventArgs e)
        {
            try
            {
                ErrorProvider.Clear();
                // Verificaciones
                cliente = (CCliente)
                    (this.DgvListaClientes.SelectedRows[0].DataBoundItem);

                // Operaciones
                if (ConfirmaOperacion("¿Confirma Pago del Cobro?"))
                {
                    DateTime desde = (DateTime)DtpFechaVencimientoCobro.Value;
                    DateTime hasta = DateTime.Now.AddDays(-1);
                    int retraso = cobro.CalcularRetrasoEnDias(desde, hasta);
                    decimal recargo = cobro.CalcularRecargo(cobro.Importe, retraso);

                    pago = new CPago
                        (
                        cobro.Tipo,
                        cobro.Codigo,
                        cobro.NombreCobro,
                        cobro.FechaVencimiento,
                        cobro.Importe,
                        cobro.Cliente,
                        recargo,
                        0
                        );

                    pago.OnTotalChanged += Pago_OnTotalChanged;
                    pago.Total = cobro.Importe + recargo;

                    SeleccionaCliente();

                    //cliente.AltaCancelado(pago);
                    //cliente.BajaPendiente(cobro);

                    //ordenable = cliente.VerCancelados();
                    //reducida = cliente.VerCancelados().Select(x => new CReducida()
                    //{
                    //    Nombre = x.Cliente,
                    //    Total  = x.Total
                    //}).ToList();

                    //DgvListaPendientes.DataSource   = null;
                    //DgvListaCanceladosG3.DataSource = null;
                    //DgvListaCanceladosG4.DataSource = null;
                    //DgvListaCanceladosG5.DataSource = null;

                    //DgvListaPendientes.DataSource   = cliente.VerPendientes();
                    //DgvListaCanceladosG3.DataSource = cliente.VerCancelados();
                    //DgvListaCanceladosG4.DataSource = ordenable;
                    //DgvListaCanceladosG5.DataSource = reducida;
                }

                // Adendas
                //RadioAscendente.Enabled        = true;
                //RadioDescendente.Enabled       = true;

                //RadioAscendente.Checked        = false;
                //RadioDescendente.Checked       = false;

                //CmdPagaCobro.Enabled           = false;
                //CmdAltaCobro.Enabled           = true;

                //CheckTipoCobro.Checked         = false;
                //TboxCodigoCobro.Text           = String.Empty;
                //TboxNombreCobro.Text           = String.Empty;
                //DtpFechaVencimientoCobro.Value = DateTime.Now;
                //TboxImporteCobro.Text          = String.Empty;
            }
            catch (Exception error)
            { InformaExcepcion(LabelInformacion, error.Message); }
        }
        #endregion

        #region // *---------------------------------------=> GRUPO 4 (Eventos)
        private void RadioAscendente_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if(cliente.VerCancelados() != null && cliente.VerCancelados().Count > 0)
                {
                    List<CPago> ascendente = cliente.VerCancelados().OrderBy(x => x.Total).ToList();
                    DgvListaCanceladosG4.DataSource = null;
                    DgvListaCanceladosG4.DataSource = ascendente;
                }

                /*
                 * COORDINACIÓN ENTRE GRUPOS
                 */
                // *-----------------=> Para G1
                // *-----------------=> Para G2
                this.LabelInformacion.Text = String.Empty;

                // *-----------------=> Para G4
            }
            catch (Exception error)
            { InformaExcepcion(LabelInformacion, error.Message); }
        }
        private void RadioDescendente_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                if (cliente.VerCancelados() != null && cliente.VerCancelados().Count > 0)
                {
                    List<CPago> descendente = cliente.VerCancelados().OrderByDescending(x => x.Total).ToList();
                    DgvListaCanceladosG4.DataSource = null;
                    DgvListaCanceladosG4.DataSource = descendente;
                }

                /*
                 * COORDINACIÓN ENTRE GRUPOS
                 */
                // *-----------------=> Para G1
                // *-----------------=> Para G2
                this.LabelInformacion.Text = String.Empty;

                // *-----------------=> Para G4
            }
            catch (Exception error)
            { InformaExcepcion(LabelInformacion, error.Message); }
        }
        #endregion
    }



    public class CReducida
    {
        public string Nombre { get; set; }
        public decimal Total { get; set; }
    }



    public interface ICobro
    {
        decimal CalcularRecargo(decimal pImporte, double pDias);
    }



    public abstract class CCobro
    {
        // Atributos
        private string tipo;
        private int codigo;
        private string nombreCobro;
        private DateTime fechaVencimiento;
        private decimal importe;
        private string cliente;

        // Propiedades
        public string Tipo { get => tipo; }
        public int Codigo { get => codigo; }
        public string NombreCobro { get => nombreCobro; }
        public DateTime FechaVencimiento { get => fechaVencimiento; }
        public decimal Importe { get => importe; }
        public string Cliente { get => cliente; }

        // Constructores
        public CCobro
            (
            string   pTipo,
            int      pCodigo,
            string   pNombreCobro,
            DateTime pFechaVencimiento,
            decimal  pImporte,
            string   pCliente
            )
        {
            this.tipo             = pTipo;
            this.codigo           = pCodigo;
            this.nombreCobro      = pNombreCobro;
            this.fechaVencimiento = pFechaVencimiento;
            this.importe          = pImporte;
            this.cliente          = pCliente;
        }

        // Métodos
        public int CalcularRetrasoEnDias
            (DateTime pDesde,
            DateTime  pHasta)
        { return (int) Math.Ceiling((pHasta - pDesde).TotalDays); }

        public abstract decimal CalcularRecargo(decimal pImporte, double pDias);
    }



    public class CCobroNormal : CCobro 
    {
        // Atributos
        // Propiedades
        // Constructores
        public CCobroNormal
            (
            string   pTipo,
            int      pCodigo,
            string   pNombreCobro,
            DateTime pFechaVencimiento,
            decimal  pImporte,
            string   pCliente
            )
            : base
                  (
                     pTipo,
                     pCodigo,
                     pNombreCobro,
                     pFechaVencimiento,
                     pImporte,
                     pCliente
                  )
        { }
        
        // Métodos
        public override decimal CalcularRecargo(decimal pImporte, double pDias)
        { 
            if(pDias > 0) { return pImporte * (decimal)0.01 * (decimal)pDias; }
            return 0;
        }
    }



    public class CCobroEspecial : CCobro
    {
        // Atributos
        // Propiedades
        // Constructores
        public CCobroEspecial
            (
            string   pTipo,
            int      pCodigo,
            string   pNombreCobro,
            DateTime pFechaVencimiento,
            decimal  pImporte,
            string   pCliente
            )
            : base
                  (
                     pTipo,
                     pCodigo,
                     pNombreCobro,
                     pFechaVencimiento,
                     pImporte,
                     pCliente
                  )
        { }

        // Métodos
        public override decimal CalcularRecargo(decimal pImporte, double pDias)
        { 
            if (pDias > 0) { return (pImporte * (decimal)0.02 * (decimal)pDias) + 1000; }
            return 0;
        }
    }



    public class CPago : CCobro, IComparable
    {
        // Atributos
        private decimal recargo;
        private decimal total;

        // Propiedades
        public decimal Recargo { get => recargo; }
        public decimal Total
        { 
            get => total;
            set
            {
                this.total = value;
                this.OnTotalChanged?.Invoke(this, this.total);
            }
        }
        public event EventHandler<decimal> OnTotalChanged;

        // Constructores
        public CPago
            (
            string   pTipo,
            int      pCodigo,
            string   pNombreCobro,
            DateTime pFechaVencimiento,
            decimal  pImporte,
            string   pCliente,
            decimal  pRecargo,
            decimal  pTotal
            )
            : base
                  (
                     pTipo,
                     pCodigo,
                     pNombreCobro,
                     pFechaVencimiento,
                     pImporte,
                     pCliente
                  )
        {
            this.recargo = pRecargo;
            this.total   = pTotal;
        }
        
        // Métodos
        public int CompareTo(object obj)
        {
            CPago x = (CPago)obj;
            if(Total > x.Total) { return 1; }
            if(Total < x.Total) { return -1; }
            return 0;
        }
        public override decimal CalcularRecargo(decimal pImporte, double pDias)
        {
            throw new NotImplementedException();
        }
    }



    public class CCliente
    {
        // Atributos
        private int legajo;
        private string nombreCliente;
        private List<CCobro> CobrosPendientes = new List<CCobro>();
        private List<CPago> CobrosCancelados = new List<CPago>();

        // Propiedades
        public int Legajo
        {
            get => this.legajo;
            set => this.legajo = value;
        }
        public string NombreCliente
        {
            get => this.nombreCliente;
            set => this.nombreCliente = value;
        }
        public List<CCobro> VerPendientes() { return this.CobrosPendientes; }
        public List<CPago> VerCancelados() { return this.CobrosCancelados; }

        // Constructores
        public CCliente(int pLegajo, string pNombreCliente)
        {
            this.legajo = pLegajo;
            this.nombreCliente = pNombreCliente;
        }

        // Métodos
        public bool EsDuplicado(int pCodigo)
        {
            if (CobrosPendientes.Count > 0)
            { return CobrosPendientes[0].Codigo == pCodigo; }
            return false;
        }
        public void AltaPendiente(CCobro pCobro)
        { this.CobrosPendientes.Add(pCobro); }

        public void BajaPendiente(CCobro pCobro)
        { this.CobrosPendientes.Remove(pCobro); }

        public void AltaCancelado(CPago pPago)
        { this.CobrosCancelados.Add(pPago); }
    }
}
