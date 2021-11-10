using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

        private void Form1_Load(object sender, EventArgs e)
        {
            clientes.Add(new Cliente() { Legajo = "Uno", Nombre = "Gerardo" });
            clientes.Add(new Cliente() { Legajo = String.Empty, Nombre = String.Empty });
            this.dataGridView1.DataSource = clientes;
            
        }

        
        
    }

    class Cliente
    {
        public string Legajo { get; set; }
        public string Nombre { get; set; }
    }
}
