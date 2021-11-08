using Microsoft.VisualBasic;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System;

namespace Formularios1
{
    public partial class CFormularioPrincipal : Form
    {
        #region // *--------------------------------------------------------=> APERTURA
        string usuario = string.Empty;
        public CFormularioPrincipal() { InitializeComponent(); }
        private void CFormularioPrincipal_Load(object sender, EventArgs e)
        {
            while (true)
            {
                ///if (usuario != string.Empty) { break; }
                if (Regex.Match(usuario, "[A-Z][a-z]+(?: [A-Z][a-z]+)?").Success) { break; }
                usuario = Interaction.InputBox
                    (
                    "Ingrese su nombre. \n\nEjemplos: \n    Gerardo Tordoya \n    Rodolfo",
                    "Usuario",
                    "Gerardo Tordoya"
                    );
            }

            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.CenterToScreen();
            this.Text += $" (Usuario: {usuario})";
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            this.dgvAccionesDisponibles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccionistas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            this.dgvAccionesPorAccionista.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
        }
        #endregion

        List<Accionista> ListaAccionistas = new List<Accionista>();
        List<Accion> LAccionesDisponibles = new List<Accion>();

        #region *------------------------------------------------------------=> BOTONES
        private void btnAltaAcciones_Click(object sender, EventArgs e)
        {
            try
            {
                RadioButton radioBtn = 
                    this
                    .grpTipo
                    .Controls
                    .OfType<RadioButton>()
                    .Where(x => x.Checked)
                    .FirstOrDefault();
                int cantidad = int.Parse(Interaction.InputBox("Cantidad: "));
                decimal cotizacion = decimal.Parse(Interaction.InputBox("Cotización: "));
                
                if (radioBtn != null)
                {
                    switch (radioBtn.Name)
                    {
                        case "rbnTipoA":
                            this.LAccionesDisponibles.Add(new AccionEmpresaA
                                (
                                cantidad,
                                "AEA",
                                "Acción Empresa A",
                                cotizacion
                                ));
                            break;
                        case "rbnTipoB":
                            this.LAccionesDisponibles.Add(new AccionEmpresaB
                                (
                                cantidad,
                                "AEB",
                                "Acción Empresa B",
                                cotizacion
                                ));
                            break;
                        default:
                            MessageBox.Show
                                (
                                "Opción no disponible",
                                "Revise los datos ingresados",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error
                                );
                            break;
                    }
                }
                this.dgvAccionesDisponibles.DataSource = null;
                this.dgvAccionesDisponibles.DataSource = this.LAccionesDisponibles;
            }
            catch (Exception ex)
            {
                MessageBox.Show
                    (
                    ex.Message,
                    "Revise los datos ingresados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
        }

        private void btnAltaAccionistas_Click(object sender, EventArgs e)
        {
            string accionista = Interaction.InputBox("Nombre: ");
            if (!Regex.Match(accionista, "[A-Z][a-z]+(?: [A-Z][a-z]+)?").Success)
            {
                MessageBox.Show
                    (
                    "Nombre no válido",
                    "Revise los datos ingresados",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            else
            {
                this.ListaAccionistas.Add(new Accionista(accionista));
                this.dgvAccionistas.DataSource = null;
                this.dgvAccionistas.DataSource = this.ListaAccionistas;
            }
        }

        private void btnBajaAccionistas_Click(object sender, EventArgs e)
        {
            Accionista accionista = (Accionista)(this.dgvAccionistas.SelectedRows[0].DataBoundItem);

            // *----------=> Si posee acciones, éstas pasan a estar disponibles
            if (accionista.VerAcciones().Count > 0)
            {
                this.LAccionesDisponibles.AddRange(accionista.VerAcciones());
            }
            
            this.ListaAccionistas.Remove(accionista); // * Accionista eliminado

            // *-----------------------=> Actualizar DGV acciones (disponibles)
            this.dgvAccionesDisponibles.DataSource = null;
            this.dgvAccionesDisponibles.DataSource = this.LAccionesDisponibles;

            // *----------------------------------=> Actualizar DGV accionistas
            this.dgvAccionistas.DataSource = null;
            this.dgvAccionistas.DataSource = this.ListaAccionistas;

            // *----=> Actualizar DGV de acciones del accionista (seleccionado)
            this.dgvAccionesPorAccionista.DataSource = null;
            this.dgvAccionesPorAccionista.DataSource = 
                ((Accionista)this
                .dgvAccionistas
                .SelectedRows[0]
                .DataBoundItem)
                .VerAcciones();
        }

        private void btnComprarAcciones_Click(object sender, EventArgs e)
        {
            // *---------------------------------=> Agregar acción a accionista
            ((Accionista)this
                .dgvAccionistas
                .SelectedRows[0]
                .DataBoundItem)
                .AltaAccion(
                (Accion)(this.dgvAccionesDisponibles.SelectedRows[0].DataBoundItem)
                );

            // *---------------------=> Eliminar acción de acciones disponibles
            this
                .LAccionesDisponibles
                .Remove(
                (Accion)(this.dgvAccionesDisponibles.SelectedRows[0].DataBoundItem)
                );

            // *-----------------------------=> Actualizar acciones disponibles
            this.dgvAccionesDisponibles.DataSource = null;
            this.dgvAccionesDisponibles.DataSource = this.LAccionesDisponibles;

            // *--------------=> Actualizar acciones de accionista seleccionado
            this.dgvAccionesPorAccionista.DataSource = null;
            this.dgvAccionesPorAccionista.DataSource =
                ((Accionista)this
                .dgvAccionistas
                .SelectedRows[0]
                .DataBoundItem)
                .VerAcciones();
        }

        private void btnVenderAcciones_Click(object sender, EventArgs e)
        {
            // *---------------------------------=> Seleccionar acción a vender
            Accion accion = 
                (Accion)(this.dgvAccionesPorAccionista.SelectedRows[0].DataBoundItem);

            // *---------=> Eliminar acción de lista de acciones del accionista
            ((Accionista)(this.dgvAccionistas.SelectedRows[0].DataBoundItem))
                .BajaAccion(accion);

            // *--------------=> Agregar acción a lista de acciones disponibles
            this.LAccionesDisponibles.Add(accion);

            // *------------------=> Actualizar listado de acciones disponibles
            this.dgvAccionesDisponibles.DataSource = null;
            this.dgvAccionesDisponibles.DataSource = this.LAccionesDisponibles;

            // *----=> Actualizar listado de acciones (accionista seleccionado)
            this.dgvAccionesPorAccionista.DataSource = null;
            this.dgvAccionesPorAccionista.DataSource = 
                ((Accionista)this.dgvAccionistas.SelectedRows[0].DataBoundItem)
                .VerAcciones();
        }
        #endregion

        #region *------------------------------------------------------------=> EVENTOS
        /// <summary>
        /// Actualizar listado de acciones de accionista seleccionado
        /// </summary>
        /// <param name="sender">Objeto</param>
        /// <param name="e">Evento</param>
        private void dgvAccionistas_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            this.dgvAccionesPorAccionista.DataSource = null;
            this.dgvAccionesPorAccionista.DataSource =
                ((Accionista)this.dgvAccionistas.SelectedRows[0].DataBoundItem)
                .VerAcciones();
        }
        #endregion

        #region // *----------------------------------------------------------=> CIERRE
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
            set => this.nombre = value;
        }

        public Accionista(string pNombre) { this.nombre = pNombre; }
        private List<Accion> ListaAcciones = new List<Accion>();

        public void AltaAccion(Accion pAccion) { this.ListaAcciones.Add(pAccion); }
        public void BajaAccion(Accion pAccion) { this.ListaAcciones.Remove(pAccion); }
        public List<Accion> VerAcciones() { return this.ListaAcciones; }
    }

    abstract public class Accion
    {
        private int     cantidad;
        private string  identificador;
        private string  descripcion;
        private decimal cotizacion;

        public int Cantidad
        {
            get => this.cantidad;
            set => this.cantidad = value; 
        }
        public string Identificador
        { 
            get => this.identificador; 
            set => this.identificador = value; 
        }
        public string Descripcion
        { 
            get => this.descripcion; 
            set => this.descripcion = value; 
        }
        public decimal Cotizacion
        { 
            get => this.cotizacion;
            set => this.cotizacion = value;
        }

        public Accion
            (
            int     pCantidad,
            string  pIdentificador,
            string  pDescripcion,
            decimal pCotizacion
            )
        {
            this.cantidad      = pCantidad;
            this.identificador = pIdentificador;
            this.descripcion   = pDescripcion;
            this.cotizacion    = pCotizacion;
        }
    }

    public class AccionEmpresaA : Accion
    {
        public AccionEmpresaA
            (
            int     pCantidad,
            string  pIdentificador,
            string  pDescripcion,
            decimal pCotizacion
            )
            : base
            (
            pCantidad,
            pIdentificador,
            pDescripcion,
            pCotizacion
            )
        { }
    }

    public class AccionEmpresaB : Accion
    {
        public AccionEmpresaB
            (
            int     pCantidad,
            string  pIdentificador,
            string  pDescripcion,
            decimal pCotizacion
            )
            : base
            (
            pCantidad,
            pIdentificador,
            pDescripcion,
            pCotizacion
            )
        { }
    }
}
