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


/* Calculate difference between two dates (number of days)?
 * Assuming StartDate and EndDate are of type DateTime:
 * (EndDate - StartDate).TotalDays
 * 
 * 
 */



namespace Formularios2
{
    public partial class CFormulario : Form
    {
        public CFormulario()
        {
            InitializeComponent();
        }

        List<CCliente> clientes = new List<CCliente>();
        //SortedSet<CCliente> clientes = new SortedSet<CCliente>();

        string usuario = string.Empty;

        private void Form1_Load(object sender, EventArgs e)
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

            clientes.Add(new CCliente(3, "Tres") );
            clientes.Add(new CCliente(5, "Cinco"));
            clientes.Add(new CCliente(1, "Uno"));

            List<CCliente> ordenado = clientes.OrderBy(x => x.Legajo).ToList();
            //List<Cliente> ordenado = clientes.OrderByDescending(x => x.Legajo).ToList();
            //List<CCliente> listado = clientes.Select(x => x).ToList();

            //this.DgvListaClientes.DataSource = ordenado;
            this.DgvListaClientes.DataSource = ordenado;

            DateTime inicio = new DateTime(2021, 11, 4);
            DateTime final = DateTime.Today;

            CCobro objeto = new CCobroNormal(1, "Uno", new DateTime(2021, 11, 4), 1000, 1);

            double cuantos = objeto.CalcularRetrasoEnDias(inicio, final);

            //double dias = (final - inicio).TotalDays;
            MessageBox.Show(cuantos.ToString());
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            TextboxLegajoCliente.Text = DgvListaClientes.Rows[e.RowIndex].Cells[0].Value.ToString();
            TextboxNombreCliente.Text = DgvListaClientes.Rows[e.RowIndex].Cells[1].Value.ToString();

            BotonAltaCliente.Enabled = false;
            BotonModificaCliente.Enabled = true;
            BotonBajaCliente.Enabled = true;
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            TextboxLegajoCliente.Text = String.Empty;
            TextboxNombreCliente.Text = String.Empty;

            BotonAltaCliente.Enabled = true;
            BotonModificaCliente.Enabled = false;
            BotonBajaCliente.Enabled = false;
        }



        #region CLOSURE                                                               <
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
            $"{usuario}, ¿deseas cerrar esta aplicación?",
            "Salir de la aplicación",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
            ) == DialogResult.No)
            {
                e.Cancel = true;
            }
        }
#endregion
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
            DateTime pHasta)
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
        {
            return pImporte * (decimal)0.01 * (decimal)pDias;
        }
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
        {
            return (pImporte * (decimal)0.02 * (decimal)pDias) + 1000;
        }
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
            this.total = pTotal;
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

        // Constructores
        public CCliente(int pLegajo, string pNombreCliente)
        {
            this.legajo = pLegajo;
            this.nombreCliente = pNombreCliente;
        }

        // Métodos
        public List<CCobro> VerPendientes() { return this.CobrosPendientes; }
        public List<CPago> VerCancelados() { return this.CobrosCancelados; }
        public void AltaPendiente(CCobro pCobro) { this.CobrosPendientes.Add(pCobro); }
        public void BajaPendiente(CCobro pCobro) { this.CobrosPendientes.Remove(pCobro); }
        public void AltaCancelado(CPago pPago) { this.CobrosCancelados.Add(pPago); }
    }
}
