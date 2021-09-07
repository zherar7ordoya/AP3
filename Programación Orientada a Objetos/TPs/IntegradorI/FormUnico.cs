using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace IntegradorI
{
    public partial class FormUnico : Form
    {
        public FormUnico()
        {
            InitializeComponent();
        }
        List<Persona> listadoPersonas = new List<Persona>();
        List<Auto> listadoAutos       = new List<Auto>();

        private void FormUnico_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            /*
            dgvPersonas.SelectionChanged -= new EventHandler(this.dgvPersonas_SelectionChanged);
            dgvPersonas.Rows.Add("Gerardo");
            dgvPersonas.Rows.Add("Rodolfo");
            dgvPersonas.Rows.Add("Tordoya");
            dgvPersonas.ClearSelection();
            dgvPersonas.SelectionChanged += new EventHandler(this.dgvPersonas_SelectionChanged);
            */
            Auto car = new Auto("MTR123", "Ford", "Sedán", "1984", 75000);
            car = null;
            GC.Collect();
        }
        #region PERSONAS
        private void btnAltaPersona_Click(object sender, EventArgs e)
        {
            string dni      = Interaction.InputBox("Ingrese DNI",      "Alta de Persona");
            string nombre   = Interaction.InputBox("Ingrese Nombre",   "Alta de Persona");
            string apellido = Interaction.InputBox("Ingrese Apellido", "Alta de Persona");
            if(dni      != String.Empty && 
               nombre   != String.Empty && 
               apellido != String.Empty)
            {
                listadoPersonas.Add(new Persona(dni, nombre, apellido));
            }
            else { 
                MessageBox.Show("Datos Incorrectos",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }
        private void btnBajaPersona_Click(object sender, EventArgs e)
        {

        }
        private void btnModificacionPersona_Click(object sender, EventArgs e)
        {

        }
        private void dgvPersonas_SelectionChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Soy SelectionChanged de PERSONAS");
        }
        #endregion

        #region AUTOS
        private void btnAltaAuto_Click(object sender, EventArgs e)
        {
            string  patente = Interaction.InputBox("Ingrese Patente", "Alta de Auto");
            string  marca   = Interaction.InputBox("Ingrese Marca",   "Alta de Auto");
            string  modelo  = Interaction.InputBox("Ingrese Modelo",  "Alta de Auto");
            string  anio    = Interaction.InputBox("Ingrese Año",     "Alta de Auto");
            string precio   = Interaction.InputBox("Ingrese Precio",  "Alta de Auto");
            try
            {
                if (patente != String.Empty &&
                    marca   != String.Empty &&
                    modelo  != String.Empty &&
                    anio    != String.Empty &&
                    precio  != String.Empty)
                {
                    listadoAutos.Add(new Auto(patente, marca, modelo, anio, Convert.ToDecimal(precio)));
                }
                else
                {
                    MessageBox.Show("Datos Incorrectos",
                                    "Error",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Error);
                }
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }
            
        }
        private void btnBajaAuto_Click(object sender, EventArgs e)
        {

        }
        private void btnModificacionAuto_Click(object sender, EventArgs e)
        {

        }
        private void dgvAutos_SelectionChanged(object sender, EventArgs e)
        {
            MessageBox.Show("Soy SelectionChanged de AUTOS");
        }
        #endregion

        #region COMUNES
        private void btnAsignar_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
