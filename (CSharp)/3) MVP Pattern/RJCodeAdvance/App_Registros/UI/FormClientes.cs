﻿using System;
using System.Linq;
using System.Windows.Forms;
using App_Registros.DAO;

namespace App_Registros.UI
{
    public partial class FormClientes : Form
    {
        // *----------------------------------------------------------=> INICIA
        // PATRÓN SINGLETON DE DISEÑO
        // Evita abrir varios veces el mismo formulario.

        /** PROCEDIMIENTO
         *  -1er requisito: cambiar public FormClientes() a PRIVATE
         *  -Crear variable estática privada
         *  -Crear método estático público
         *  -Observar cómo se crea la instancia en FormPrincipal
         */

        private FormClientes()
        {
            InitializeComponent();
        }
        private static FormClientes Instancia = null;


        public static FormClientes ObtenerInstancia()
        {
            if (Instancia == null)
            {
                Instancia = new FormClientes();
            }
            return Instancia;
        }

        // *--------------------------------------------------------=> FINALIZA


        // Mostrar todo.
        private void FormClientes_Load(object sender, EventArgs e)
        {
            VerRegistros("");

            /** 
             * What it's doing:
             * Totals up the widths of all columns (using LINQ)
             * Sees if the "row header" is visible and adds that width too, if it is
             * Adds 20 more because without that the horizontal scrollbar kept showing up
             * (possibly because of margin/padding around the grid, I'm not sure)
             */
            dataGridView1.Width = dataGridView1
                .Columns
                .Cast<DataGridViewColumn>()
                .Sum(x => x.Width)
                +
                (dataGridView1.RowHeadersVisible ? dataGridView1.RowHeadersWidth : 0)
                +
                20;
        }
        private void VerRegistros(string condicion)
        {
            ClienteDAO DAO = new ClienteDAO();
            dataGridView1.DataSource = DAO.VerRegistros(condicion);
        }

        // Buscar
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            VerRegistros(txtBuscar.Text);
        }

        // Filtrar
        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            VerRegistros(txtBuscar.Text);
        }
    }
}
