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

namespace Formularios2
{
    public partial class CFormulario : Form
    {
        public CFormulario()
        {
            InitializeComponent();
        }

        //List<Cliente> clientes = new List<Cliente>();
        SortedSet<CCliente> clientes = new SortedSet<CCliente>();
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

            clientes.Add(new CCliente() { Legajo = 5, Nombre = "Gamma" });
            clientes.Add(new CCliente() { Legajo = 4, Nombre = "Beta" });
            clientes.Add(new CCliente() { Legajo = 3, Nombre = "Alpha" });
            clientes.Add(new CCliente() { Legajo = 2, Nombre = "Tordoya" });
            clientes.Add(new CCliente() { Legajo = 1, Nombre = "Gerardo" });

            List<CCliente> ordenado = clientes.OrderBy(x => x.Legajo).ToList();
            //List<Cliente> ordenado = clientes.OrderByDescending(x => x.Legajo).ToList();
            List<CCliente> listado = clientes.Select(x => x).ToList();

            //this.DgvListaClientes.DataSource = ordenado;
            this.DgvListaClientes.DataSource = listado;
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

    class CCliente : IComparable
    {
        public int Legajo { get; set; }
        public string Nombre { get; set; }

        public int CompareTo(object obj)
        {
            //Hacemos typecast con el objeto con el cual nos vamos a comparar
            CCliente tmp = (CCliente)obj;

            //Si somos mayores regresamos 1
            if (Legajo > tmp.Legajo) { return 1; }
            //Si somos menores regresamos -1
            if (Legajo < tmp.Legajo) { return -1; }
            //Si somos iguales regresamos 0
            return 0;
        }
    }
}
