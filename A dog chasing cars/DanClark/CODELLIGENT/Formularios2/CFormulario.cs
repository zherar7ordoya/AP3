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

namespace Formularios2
{
    public partial class CFormulario : Form
    {
        public CFormulario() { InitializeComponent(); }
        List<CCliente> clientes = new List<CCliente>();
        string usuario = string.Empty;
        CCliente cliente = null;
        CCobro cobro = null;

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
            TextboxLegajoCliente.Text = String.Empty;
            TextboxNombreCliente.Text = String.Empty;

            TextboxLegajoCliente.Enabled = true;
            CmdAltaCliente.Enabled = true;
            CmdModificaCliente.Enabled = false;
            CmdBajaCliente.Enabled = false;
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

            TextboxLegajoCliente.Enabled = false;
            CmdAltaCliente.Enabled = false;
            CmdModificaCliente.Enabled = true;
            CmdBajaCliente.Enabled = true;
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
            {
                ErrorProvider.SetError(
                    EtiquetaClientes,
                    error.Message);

                MessageBox.Show
                    (
                    "En el ícono encontrará mayores detalles.",
                    "Algo ha fallado...",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void CmdBajaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificaciones
                // Operaciones
                if (MessageBox.Show
                    (
                    "¿Confirma baja?",
                    $"{usuario}",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                    ) == DialogResult.Yes)
                {
                    //CCliente cliente =
                    //    (CCliente)
                    //    (this.DgvListaClientes.SelectedRows[0].DataBoundItem);
                    this.clientes.Remove(cliente);
                    DgvListaClientes.DataSource = null;
                    DgvListaClientes.DataSource = clientes;
                }

                // Adendas
                DgvListaClientes_CellClick(this, null);
                this.TextboxLegajoCliente.Focus();
            }
            catch (Exception error)
            {
                ErrorProvider.SetError(
                    EtiquetaClientes,
                    error.Message);

                MessageBox.Show
                    (
                    "En el ícono encontrará mayores detalles.",
                    "Algo ha fallado...",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void CmdModificaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                // Verificaciones
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
            }
            catch (Exception error)
            {
                ErrorProvider.SetError(
                    EtiquetaClientes,
                    error.Message);

                MessageBox.Show
                    (
                    "En el ícono encontrará mayores detalles.",
                    "Algo ha fallado...",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }

        }
        #endregion

        private void DgvListaPendientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DgvListaPendientes_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            cliente = (CCliente)
                (this.DgvListaClientes.SelectedRows[0].DataBoundItem);
            cobro = (CCobro)
                (this.DgvListaPendientes.SelectedRows[0].DataBoundItem);
        }
    }





    public interface ICobro
    {
        decimal CalcularRecargo(decimal pImporte, double pDias);
    }


    public abstract class CCobro
    {
        // Atributos
        private int codigo;
        private string nombreCobro;
        private DateTime fechaVencimiento;
        private decimal importe;
        private int cliente;

        // Propiedades
        public int Codigo { get => codigo; }
        public string NombreCobro { get => nombreCobro; }
        public DateTime FechaVencimiento { get => fechaVencimiento; }
        public decimal Importe { get => importe; }
        public int Cliente { get => cliente; }

        // Constructores
        public CCobro
            (
            int      pCodigo,
            string   pNombreCobro,
            DateTime pFechaVencimiento,
            decimal  pImporte,
            int      pCliente
            )
        {
            this.codigo           = pCodigo;
            this.nombreCobro      = pNombreCobro;
            this.fechaVencimiento = pFechaVencimiento;
            this.importe          = pImporte;
            this.cliente          = pCliente;
        }

        // Métodos
        public double CalcularRetrasoEnDias
            (DateTime pDesde,
            DateTime  pHasta)
        { return (pHasta - pDesde).TotalDays; }
    }



    public class CCobroNormal : CCobro, ICobro
    {
        // Atributos
        // Propiedades
        // Constructores
        public CCobroNormal
            (
            int      pCodigo,
            string   pNombreCobro,
            DateTime pFechaVencimiento,
            decimal  pImporte,
            int      pCliente
            )
            : base
                  (
                     pCodigo,
                     pNombreCobro,
                     pFechaVencimiento,
                     pImporte,
                     pCliente
                  )
        { }
        
        // Métodos
        public decimal CalcularRecargo(decimal pImporte, double pDias)
        { return pImporte * (decimal)0.01 * (decimal)pDias; }
    }



    public class CCobroEspecial : CCobro, ICobro
    {
        // Atributos
        // Propiedades
        // Constructores
        public CCobroEspecial
            (
            int      pCodigo,
            string   pNombreCobro,
            DateTime pFechaVencimiento,
            decimal  pImporte,
            int      pCliente
            )
            : base
                  (
                     pCodigo,
                     pNombreCobro,
                     pFechaVencimiento,
                     pImporte,
                     pCliente
                  )
        { }

        // Métodos
        public decimal CalcularRecargo(decimal pImporte, double pDias)
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
            int      pCodigo,
            string   pNombreCobro,
            DateTime pFechaVencimiento,
            decimal  pImporte,
            int      pCliente,
            decimal  pRecargo,
            decimal  pTotal
            )
            : base
                  (
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
        public void AltaPendiente(CCobro pCobro)
        { this.CobrosPendientes.Add(pCobro); }

        public void BajaPendiente(CCobro pCobro)
        { this.CobrosPendientes.Remove(pCobro); }

        public void AltaCancelado(CPago pPago)
        { this.CobrosCancelados.Add(pPago); }
    }
}
