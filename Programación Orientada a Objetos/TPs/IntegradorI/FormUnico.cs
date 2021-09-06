using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IntegradorI
{
    public partial class FormUnico : Form
    {
        public FormUnico()
        {
            InitializeComponent();
        }

        private void FormUnico_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;

            // TEMPORAL
            dgvPersonas.SelectionChanged -= new EventHandler(this.dgvPersonas_SelectionChanged);
            dgvPersonas.Rows.Add("Gerardo");
            dgvPersonas.Rows.Add("Rodolfo");
            dgvPersonas.Rows.Add("Tordoya");
            dgvPersonas.ClearSelection();
            dgvPersonas.SelectionChanged += new EventHandler(this.dgvPersonas_SelectionChanged);
            dgvAutos.Rows.Add("UNO");
            dgvAutos.Rows.Add("DOS");
            dgvAutos.Rows.Add("TRES");
        }
        #region PERSONAS
        private void btnAltaPersona_Click(object sender, EventArgs e)
        {

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
