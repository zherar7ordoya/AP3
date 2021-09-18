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

namespace Integrador_1
{
    public partial class UI : Form
    {
        Concesionario _c;
        public UI()
        {
            InitializeComponent();
            _c = new Concesionario();
        }
        private void UI_Load(object sender, EventArgs e)
        {
            dgvPersonas.MultiSelect = false;
            dgvPersonas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            RefrescarGrilla(
                dgvPersonas,
                _c.RetornarListaPersonas());
        }

        void RefrescarGrilla(
            DataGridView pDGV,
            object pObject)
        {
            pDGV.DataSource = null;
            pDGV.DataSource = pObject;
        }

        private void btnAgregarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                // TODO validar inputs
                _c.AgregarPersona(new Persona(
                    Interaction.InputBox("DNI:"),
                    Interaction.InputBox("Nombre:"),
                    Interaction.InputBox("Apellido:")));
                RefrescarGrilla(
                    dgvPersonas,
                    _c.RetornarListaPersonas());
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private void btnBorrarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonas.Rows.Count > 0)
                {
                    _c.BorrarPersona(dgvPersonas.SelectedRows[0].DataBoundItem as Persona);
                    RefrescarGrilla(
                        dgvPersonas,
                        _c.RetornarListaPersonas());
                }
                else
                {
                    throw new Exception("Sin registros");
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnModificarPersona_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvPersonas.Rows.Count > 0)
                {
                    Persona _auxPersona = dgvPersonas.SelectedRows[0].DataBoundItem as Persona;
                    if (_auxPersona != null)
                    {
                        _auxPersona.Nombre = Interaction.InputBox(
                            "Nombre:",
                            "Modificando Persona",
                            _auxPersona.Nombre);
                        _auxPersona.Apellido = Interaction.InputBox(
                            "Apellido:",
                            "Modificando Persona",
                            _auxPersona.Apellido);
                        _c.ModificarPersona(_auxPersona);
                        RefrescarGrilla(
                            dgvPersonas,
                            _c.RetornarListaPersonas());
                    }
                    else
                    {
                        throw new Exception("Registro NULL");
                    }
                }
                else
                {
                    throw new Exception("Sin personas");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        // TODO ABM autos

    }
}
