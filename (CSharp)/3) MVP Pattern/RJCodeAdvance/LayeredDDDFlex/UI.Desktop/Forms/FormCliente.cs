using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Desktop.ApplicationController;

namespace UI.Desktop.Forms
{
    public partial class FormCliente : Form
    {
        private ClientController client;

        public FormCliente()
        {
            InitializeComponent();
            client = new ClientController();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = client.GetClientsAll("");
        }

        private void txtFiltrar_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = client.GetClientsAll(txtFiltrar.Text);
        }
    }
}
