using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Reflection;


namespace Formularios2
{
    public partial class CFormulario : Form
    {
        public CFormulario() { InitializeComponent(); }
        List<CCliente> clientes = new List<CCliente>();
        string usuario = string.Empty;
        CCliente cliente = null;
        CCobro cobro = null;
        CPago pago = null;

        List<CPago> ordenable = new List<CPago>();
        List<CReducida> reducida = new List<CReducida>();


        #region APERTURA DEL FORMULARIO
        private void CFormulario_Load(object sender, EventArgs e)
        {
            IniciaFormulario();
            this.TextboxLegajoCliente.Focus();

            //clientes.Add(new CCliente(3, "Tres"));
            //clientes.Add(new CCliente(5, "Cinco"));
            //clientes.Add(new CCliente(1, "Uno"));
            //clientes.Add(new CCliente(2, "Dos"));
            //clientes.Add(new CCliente(4, "Cuatro"));

            //List<CCliente> ascendente = clientes.OrderBy(x => x.Legajo).ToList();
            //List<CCliente> descendente = clientes.OrderByDescending(x => x.Legajo).ToList();
            //List<CCliente> desordenado = clientes.Select(x => x).ToList();

            //this.DgvListaClientes.DataSource = desordenado;
            //this.DgvListaPendientes.DataSource = ascendente;
            //this.DgvListaCanceladorG3.DataSource = descendente;
            //this.DgvListaCanceladorG4.DataSource = ascendente;
            //this.DgvListaCanceladorG5.DataSource = desordenado;

            //DateTime inicio = new DateTime(2021, 11, 4);
            //DateTime final = DateTime.Today;
            //CCobro objeto = new CCobroNormal(1, "Uno", new DateTime(2021, 11, 4), 1000, 1);
            //double cuantos = objeto.CalcularRetrasoEnDias(inicio, final);
            //double dias = (final - inicio).TotalDays;
            //MessageBox.Show(cuantos.ToString());

        }

        private void IniciaFormulario()
        {
            usuario = Interaction.InputBox
                (
                "Ingrese su nombre:",
                "Usuario",
                "Gerardo Tordoya"
                );
            this.CenterToScreen();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.Text += $" ({usuario})";
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
        #endregion

        #region CIERRE DEL FORMULARIO
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void CFormulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show
            (
            "¿Desea salir de la aplicación?",
            $"{usuario}",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            ) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
        #endregion

        #region EVENTOS GRUPO CLIENTE (GRILLA 1)
        private void DgvListaClientes_CellClick(
            object sender,
            DataGridViewCellEventArgs e)
        {
            if (DgvListaClientes.SelectedRows.Count > 0)
            {
                cliente = (CCliente)DgvListaClientes.SelectedRows[0].DataBoundItem;
                if (cliente.VerPendientes().Count > 0)
                {
                    this.DgvListaPendientes.DataSource = cliente.VerPendientes();
                }
            }
            this.DgvListaPendientes.DataSource = null;

            TextboxLegajoCliente.Text = String.Empty;
            TextboxNombreCliente.Text = String.Empty;

            // Controles propios
            TextboxLegajoCliente.Enabled = true;
            CmdAltaCliente.Enabled       = true;
            CmdModificaCliente.Enabled   = false;
            CmdBajaCliente.Enabled       = false;

            // Controles ajenos
            CmdAltaCobro.Enabled         = true;
            CmdPagar.Enabled             = false;
        }

        private void DgvListaClientes_RowHeaderMouseClick(
            object sender,
            DataGridViewCellMouseEventArgs e)
        {
            cliente = (CCliente)
                (this.DgvListaClientes.SelectedRows[0].DataBoundItem);

            TextboxLegajoCliente.Text = DgvListaClientes
                .Rows[e.RowIndex].Cells[0].Value.ToString();
            TextboxNombreCliente.Text = DgvListaClientes
                .Rows[e.RowIndex].Cells[1].Value.ToString();

            // Controles propios
            TextboxLegajoCliente.Enabled = false;
            CmdAltaCliente.Enabled       = false;
            CmdModificaCliente.Enabled   = true;
            CmdBajaCliente.Enabled       = true;

            // Controles ajenos
            CmdAltaCobro.Enabled         = true;
            CmdPagar.Enabled             = false;

            DgvListaPendientes.DataSource = null;
            DgvListaPendientes.DataSource = cliente.VerPendientes();
        }
        #endregion

        #region BOTONES GRUPO CLIENTE (GRILLA 1)
        private void CmdAltaCliente_Click(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
            try
            {
                // Verificaciones
                if (
                    TextboxLegajoCliente.Text == string.Empty ||
                    TextboxNombreCliente.Text == string.Empty
                    ) { throw new Exception("No pueden haber campos vacíos"); }
                else if (
                    !Regex.Match(TextboxNombreCliente.Text,
                    "^[A-Z][a-zA-Z]*$").Success
                    ) { throw new Exception("Use un nombre propio (Ej.: Fulano)"); }
                else if(clientes.Any
                    (x => x.Legajo == Int32.Parse(TextboxLegajoCliente.Text)))
                { throw new Exception("Los legajos deben ser diferentes."); }

                // Operaciones
                clientes.Add(new CCliente(
                    Int32.Parse(TextboxLegajoCliente.Text),
                    TextboxNombreCliente.Text
                    ));
                DgvListaClientes.DataSource = null;
                DgvListaClientes.DataSource = clientes;

                // Adendas
                DgvListaClientes_CellClick(this, null);
                this.TextboxLegajoCliente.Focus();
            }
            catch (Exception error)
            { InformarExcepcion(EtiquetaClientes, error.Message); }
        }

        private void CmdBajaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificaciones
                /* --- NADA AÚN --- */

                // Operaciones
                if (MessageBox.Show
                    (
                    "¿Confirma baja?",
                    $"{usuario}",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    ) == DialogResult.Yes)
                {
                    this.clientes.Remove(cliente);
                    DgvListaClientes.DataSource = null;
                    DgvListaClientes.DataSource = clientes;
                }

                // Adendas
                DgvListaClientes_CellClick(this, null);
                this.TextboxLegajoCliente.Focus();
            }
            catch (Exception error)
            { InformarExcepcion(EtiquetaClientes, error.Message); }
        }

        private void CmdModificaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificaciones
                /* --- NADA AÚN --- */

                // Operaciones
                if (MessageBox.Show
                    (
                    "¿Confirma modificación?",
                    $"{usuario}",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    ) == DialogResult.Yes)
                {
                    this.clientes.Remove(cliente);
                    CmdAltaCliente_Click(this, null);
                }

                // Adendas
                /* --- NADA AÚN --- */
            }
            catch (Exception error)
            { InformarExcepcion(EtiquetaClientes, error.Message); }

        }
        #endregion

        #region EVENTOS GRUPO PENDIENTES (GRILLA 2)
        private void DgvListaPendientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.CheckTipoEspecial.Checked = false;
            TextboxCodigoCobro.Text = String.Empty;
            TextboxNombreCobro.Text = String.Empty;
            DatepickerFechaVencimiento.Value = DateTime.Today.AddDays(-1);
            TextboxImporte.Text = String.Empty;

            CmdAltaCobro.Enabled = true;
            CmdPagar.Enabled     = false;
        }

        private void DgvListaPendientes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cliente = (CCliente)
                (this.DgvListaClientes.SelectedRows[0].DataBoundItem);
            cobro = (CCobro)
                (this.DgvListaPendientes.SelectedRows[0].DataBoundItem);

            if (cobro.Tipo == "Especial") { this.CheckTipoEspecial.Checked = true; }
            TextboxCodigoCobro.Text          = cobro.Codigo.ToString();
            TextboxNombreCobro.Text          = cobro.NombreCobro;
            DatepickerFechaVencimiento.Value = cobro.FechaVencimiento;
            TextboxImporte.Text              = cobro.Importe.ToString();

            CmdAltaCobro.Enabled = false;
            CmdPagar.Enabled     = true;
        }
        #endregion

        #region BOTONES GRUPO PENDIENTES (GRILLA 2)
        private void CmdAltaCobro_Click(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
            try
            {
                // Verificaciones
                if (DgvListaClientes.SelectedRows.Count == 0)
                { throw new Exception("Debe seleccionar un cliente.\n" +
                    "Puede hacerlo con un click en su cabecera de fila."); }
                else if (
                    TextboxCodigoCobro.Text == string.Empty ||
                    TextboxNombreCobro.Text == string.Empty ||
                    TextboxImporte.Text == string.Empty
                    ) { throw new Exception("No pueden haber campos vacíos"); }

                cliente = (CCliente)DgvListaClientes.SelectedRows[0].DataBoundItem;

                if (cliente.EsDuplicado(Int32.Parse(TextboxCodigoCobro.Text)))
                { throw new Exception("Los códigos de cobro no deben repetirse"); }
                else if(cliente.VerPendientes().Count > 1)
                { throw new Exception("El cliente no puede tener más de dos pendientes"); }

                // Operaciones
                if (CheckTipoEspecial.Checked)
                {
                    cobro = new CCobroEspecial(
                        "Especial",
                        Int32.Parse(TextboxCodigoCobro.Text),
                        TextboxNombreCobro.Text,
                        DatepickerFechaVencimiento.Value,
                        decimal.Parse(TextboxImporte.Text),
                        TextboxNombreCliente.Text);
                    cliente.AltaPendiente(cobro);
                }
                else
                {
                    cobro = new CCobroNormal(
                        "Normal",
                        Int32.Parse(TextboxCodigoCobro.Text),
                        TextboxNombreCobro.Text,
                        DatepickerFechaVencimiento.Value,
                        decimal.Parse(TextboxImporte.Text),
                        TextboxNombreCliente.Text);
                    cliente.AltaPendiente(cobro);
                }
                this.DgvListaPendientes.DataSource = null;
                this.DgvListaPendientes.DataSource = cliente.VerPendientes();
                // Adendas
                /* --- NADA AÚN --- */
            }
            catch (Exception error)
            { InformarExcepcion(EtiquetaPendientes, error.Message); }
        }

        private void CmdPagar_Click(object sender, EventArgs e)
        {
            ErrorProvider.Clear();
            try
            {
                // Verificaciones
                /* --- NADA AÚN --- */

                // Operaciones
                DateTime desde = (DateTime)DatepickerFechaVencimiento.Value;
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
                    cobro.Importe + recargo
                    );

                cliente.AltaCancelado(pago);
                cliente.BajaPendiente(cobro);

                ordenable = cliente.VerCancelados();
                reducida = cliente.VerCancelados().Select(x => new CReducida()
                {
                    Nombre = x.Cliente,
                    Total = x.Total
                }).ToList();

                DgvListaPendientes.DataSource   = null;
                DgvListaCanceladosG3.DataSource = null;
                DgvListaCanceladosG4.DataSource = null;
                DgvListaCanceladosG5.DataSource = null;

                DgvListaPendientes.DataSource   = cliente.VerPendientes();
                DgvListaCanceladosG3.DataSource = cliente.VerCancelados();
                DgvListaCanceladosG4.DataSource = ordenable;
                DgvListaCanceladosG5.DataSource = reducida;

                // Adendas
                RadioAscendente.Checked = false;
                RadioDescendente.Checked = false;
            }
            catch (Exception error)
            { InformarExcepcion(EtiquetaPendientes, error.Message); }
        }
        #endregion

        private void InformarExcepcion(Control pControl, string pMensaje)
        {
            ErrorProvider.SetError(
                pControl,
                pMensaje);

            MessageBox.Show
                (
                pMensaje,
                "Algo ha fallado...",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );

        }

        private void RadioAscendente_CheckedChanged(object sender, EventArgs e)
        {
            // cliente = (CCliente)DgvListaClientes.SelectedRows[0].DataBoundItem;
            List<CPago> ascendente = cliente.VerCancelados().OrderBy(x => x.Total).ToList();
            DgvListaCanceladosG4.DataSource = null;
            DgvListaCanceladosG4.DataSource = ascendente;
        }

        private void RadioDescendente_CheckedChanged(object sender, EventArgs e)
        {

            List<CPago> descendente = cliente.VerCancelados().OrderByDescending(x => x.Total).ToList();
            DgvListaCanceladosG4.DataSource = null;
            DgvListaCanceladosG4.DataSource = descendente;
        }
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
        {
            /* return Math.Ceiling((pHasta - pDesde).Days);*/ return (int) Math.Ceiling((pHasta - pDesde).TotalDays); }

        public abstract decimal CalcularRecargo(decimal pImporte, double pDias);
    }



    public class CCobroNormal : CCobro //, ICobro
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
        { return pImporte * (decimal)0.01 * (decimal)pDias; }
    }



    public class CCobroEspecial : CCobro //, ICobro
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
        { return (pImporte * (decimal)0.02 * (decimal)pDias) + 1000; }
    }



    public class CPago : CCobro, IComparable
    {
        // Atributos
        private decimal recargo;
        private decimal total;

        // Propiedades
        public decimal Recargo { get => recargo; }
        public decimal Total { get => total; }

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
