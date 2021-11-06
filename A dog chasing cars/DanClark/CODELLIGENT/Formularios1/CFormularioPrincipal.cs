using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Console;
using System.Runtime.InteropServices;
using Microsoft.VisualBasic;
using System.Text.RegularExpressions;


namespace Formularios1
{
    public partial class CFormularioPrincipal : Form
    {
        #region Operaciones de apertura.
        string usuario = string.Empty;
        public CFormularioPrincipal() { InitializeComponent(); }
        private void CFormularioPrincipal_Load(object sender, EventArgs e)
        {
            while (true)
            {
                if (usuario != string.Empty) { break; }
                usuario = Interaction.InputBox
                    (
                    "Ingrese su nombre:",
                    "Usuario",
                    "Gerardo Tordoya"
                    );
            }
            this.CenterToScreen();
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
        }
        
        



        
        #endregion



        #region Operaciones de cierre.
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void CFormularioPrincipal_FormClosing(object sender, FormClosingEventArgs e)
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




    public class Accionista
    {
        private string nombre;
        public string Nombre
        {
            get => this.nombre;
            set 
            {
                if (!Regex.Match(value, "^[A-Z][a-z]*$").Success)
                {
                    MessageBox.Show
                        (
                        "Nombre no válido",
                        "Revise los datos ingresados",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                        );
                } else { nombre = value; }
            }
        }
        public Accionista(string pNombre) { this.Nombre = pNombre; }
        
        private List<Accion> ListaDeAcciones = new List<Accion>();
        public void AgregarAccion(Accion pAccion) { this.ListaDeAcciones.Add(pAccion); }
        public void BorrarAccion(Accion pAccion) { this.ListaDeAcciones.Remove(pAccion); }
        public List<Accion> VerAcciones() { return this.ListaDeAcciones; }
    }
    abstract public class Accion
    {
        public Accion(int pCantidad, string pIdentificador, string pDescripcion, decimal pCotizacion)
        {
            this.Cantidad = pCantidad; this.Identificador = pIdentificador;
            this.Descripcion = pDescripcion; this.Cotizacion = pCotizacion;
        }
        public int Cantidad { get; set; }
        public string Identificador { get; set; }
        public string Descripcion { get; set; }
        public decimal Cotizacion { get; set; }
    }
    public class AccionEmpresaA : Accion
    {
        public AccionEmpresaA(int pCantidad, string pIdentificador, string pDescripcion, decimal pCotizacion)
              : base(pCantidad, pIdentificador, pDescripcion, pCotizacion) { }
    }
    public class AccionEmpresaB : Accion
    {
        public AccionEmpresaB(int pCantidad, string pIdentificador, string pDescripcion, decimal pCotizacion)
             : base(pCantidad, pIdentificador, pDescripcion, pCotizacion) { }
    }




}
