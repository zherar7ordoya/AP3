using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsultasMVC.Models.DAO;
using ConsultasMVC.Models.DTO;
using ConsultasMVC.Views;

namespace ConsultasMVC.Controllers
{
    internal class ClienteController
    {
        ClienteView Vista;

        // *-----------------------------------------------------=> Constructor
        public ClienteController(ClienteView view)
        {
            Vista = view;

            // Inicializar eventos
            Vista.Load += new EventHandler(ClientList);
            Vista.btnBuscar.Click += new EventHandler(ClientList);
            Vista.txtBuscar.TextChanged += new EventHandler(ClientList);
        }
        // *---------------------------------------------------------------=> *

        private void ClientList(object sender, EventArgs e)
        {
            ClienteDAO db = new ClienteDAO();
            Vista.dgvClientes.DataSource = db.VerRegistros(Vista.txtBuscar.Text);
        }
    }
}
