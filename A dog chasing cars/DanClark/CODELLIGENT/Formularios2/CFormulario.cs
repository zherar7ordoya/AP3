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

        List<Cliente> clientes = new List<Cliente>();
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

            clientes.Add(new Cliente() { Legajo = "2", Nombre = "Rodolfo" });
            clientes.Add(new Cliente() { Legajo = "3", Nombre = "Tordoya" });
            clientes.Add(new Cliente() { Legajo = "1", Nombre = "Gerardo" });

            List<Cliente> ordenado = clientes.OrderBy(x => x.Legajo).ToList();
            //List<Cliente> ordenado = clientes.OrderByDescending(x => x.Legajo).ToList();
        
            this.dataGridView1.DataSource = ordenado;
            
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            textBox2.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
        }




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
    }

    class Cliente
    {
        public string Legajo { get; set; }
        public string Nombre { get; set; }
    }
}
