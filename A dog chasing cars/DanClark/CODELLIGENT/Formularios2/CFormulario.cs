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

            clientes.Add(new CCliente() { Legajo = 2, NombreCliente = "Dos" });
            clientes.Add(new CCliente() { Legajo = 5, NombreCliente = "Cinco" });
            clientes.Add(new CCliente() { Legajo = 4, NombreCliente = "Cuatro" });
            clientes.Add(new CCliente() { Legajo = 3, NombreCliente = "Tres" });
            clientes.Add(new CCliente() { Legajo = 1, NombreCliente = "Uno" });

            List<CCliente> ordenado = clientes.OrderBy(x => x.Legajo).ToList();
            //List<Cliente> ordenado = clientes.OrderByDescending(x => x.Legajo).ToList();
            //List<CCliente> listado = clientes.Select(x => x).ToList();

            //this.DgvListaClientes.DataSource = ordenado;
            this.DgvListaClientes.DataSource = ordenado;


            DateTime inicio = new DateTime(2021, 11, 4);
            DateTime final = DateTime.Today;

            CCobro objeto = new CCobroNormal();

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
        public double CalcularRetrasoEnDias
            (DateTime pDesde,
            DateTime pHasta)
        { return (pHasta - pDesde).TotalDays; }
    }
    public class CCobroNormal : CCobro, ICobro
    {
        public decimal CalcularRecargo(decimal pImporte, double pDias)
        {
            return pImporte * (decimal)0.01 * (decimal)pDias;
        }
    }
    public class CCobroEspecial : CCobro, ICobro
    {
        public decimal CalcularRecargo(decimal pImporte, double pDias)
        {
            return (pImporte * (decimal)0.02 * (decimal)pDias) + 1000;
        }
    }
    public class CCliente //IComparable
    {
        private int legajo;
        private string nombreCliente;
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


        /* IMPLEMENTAR
         * 
        public Accionista(string pNombre) { this.nombre = pNombre; }
        private List<Accion> ListaAcciones = new List<Accion>();
        public void AltaAccion(Accion pAccion) { this.ListaAcciones.Add(pAccion); }
        public void BajaAccion(Accion pAccion) { this.ListaAcciones.Remove(pAccion); }
        public List<Accion> VerAcciones() { return this.ListaAcciones; }
        */



        //public int CompareTo(object obj)
        //{
        //    //Hacemos typecast con el objeto con el cual nos vamos a comparar
        //    CCliente x = (CCliente)obj;
        //    //Si somos mayores regresamos 1
        //    if (Legajo > x.Legajo) { return 1; }
        //    //Si somos menores regresamos -1
        //    if (Legajo < x.Legajo) { return -1; }
        //    //Si somos iguales regresamos 0
        //    return 0;
        //}
    }
}
