
namespace Formularios1
{
    partial class CFormularioPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTipos = new System.Windows.Forms.DataGridView();
            this.dgvAcciones = new System.Windows.Forms.DataGridView();
            this.dgvAccionistas = new System.Windows.Forms.DataGridView();
            this.dgvFiltrados = new System.Windows.Forms.DataGridView();
            this.btnAltaAcciones = new System.Windows.Forms.Button();
            this.btnAltaAccionistas = new System.Windows.Forms.Button();
            this.btnBajaAccionistas = new System.Windows.Forms.Button();
            this.btnComprarAcciones = new System.Windows.Forms.Button();
            this.btnVenderAcciones = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcciones)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccionistas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltrados)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTipos
            // 
            this.dgvTipos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipos.Location = new System.Drawing.Point(13, 13);
            this.dgvTipos.Name = "dgvTipos";
            this.dgvTipos.Size = new System.Drawing.Size(240, 150);
            this.dgvTipos.TabIndex = 0;
            // 
            // dgvAcciones
            // 
            this.dgvAcciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAcciones.Location = new System.Drawing.Point(259, 12);
            this.dgvAcciones.Name = "dgvAcciones";
            this.dgvAcciones.Size = new System.Drawing.Size(240, 150);
            this.dgvAcciones.TabIndex = 1;
            // 
            // dgvAccionistas
            // 
            this.dgvAccionistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccionistas.Location = new System.Drawing.Point(505, 13);
            this.dgvAccionistas.Name = "dgvAccionistas";
            this.dgvAccionistas.Size = new System.Drawing.Size(240, 150);
            this.dgvAccionistas.TabIndex = 2;
            // 
            // dgvFiltrados
            // 
            this.dgvFiltrados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltrados.Location = new System.Drawing.Point(751, 13);
            this.dgvFiltrados.Name = "dgvFiltrados";
            this.dgvFiltrados.Size = new System.Drawing.Size(240, 150);
            this.dgvFiltrados.TabIndex = 3;
            // 
            // btnAltaAcciones
            // 
            this.btnAltaAcciones.Location = new System.Drawing.Point(13, 198);
            this.btnAltaAcciones.Name = "btnAltaAcciones";
            this.btnAltaAcciones.Size = new System.Drawing.Size(115, 23);
            this.btnAltaAcciones.TabIndex = 4;
            this.btnAltaAcciones.Text = "Alta Acciones";
            this.btnAltaAcciones.UseVisualStyleBackColor = true;
            // 
            // btnAltaAccionistas
            // 
            this.btnAltaAccionistas.Location = new System.Drawing.Point(13, 227);
            this.btnAltaAccionistas.Name = "btnAltaAccionistas";
            this.btnAltaAccionistas.Size = new System.Drawing.Size(115, 23);
            this.btnAltaAccionistas.TabIndex = 5;
            this.btnAltaAccionistas.Text = "Alta Accionistas";
            this.btnAltaAccionistas.UseVisualStyleBackColor = true;
            // 
            // btnBajaAccionistas
            // 
            this.btnBajaAccionistas.Location = new System.Drawing.Point(13, 256);
            this.btnBajaAccionistas.Name = "btnBajaAccionistas";
            this.btnBajaAccionistas.Size = new System.Drawing.Size(115, 23);
            this.btnBajaAccionistas.TabIndex = 6;
            this.btnBajaAccionistas.Text = "Baja Accionistas";
            this.btnBajaAccionistas.UseVisualStyleBackColor = true;
            // 
            // btnComprarAcciones
            // 
            this.btnComprarAcciones.Location = new System.Drawing.Point(12, 285);
            this.btnComprarAcciones.Name = "btnComprarAcciones";
            this.btnComprarAcciones.Size = new System.Drawing.Size(116, 23);
            this.btnComprarAcciones.TabIndex = 7;
            this.btnComprarAcciones.Text = "Comprar Acciones";
            this.btnComprarAcciones.UseVisualStyleBackColor = true;
            // 
            // btnVenderAcciones
            // 
            this.btnVenderAcciones.Location = new System.Drawing.Point(12, 314);
            this.btnVenderAcciones.Name = "btnVenderAcciones";
            this.btnVenderAcciones.Size = new System.Drawing.Size(116, 23);
            this.btnVenderAcciones.TabIndex = 8;
            this.btnVenderAcciones.Text = "Vender Acciones";
            this.btnVenderAcciones.UseVisualStyleBackColor = true;
            // 
            // CFormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1003, 450);
            this.Controls.Add(this.btnVenderAcciones);
            this.Controls.Add(this.btnComprarAcciones);
            this.Controls.Add(this.btnBajaAccionistas);
            this.Controls.Add(this.btnAltaAccionistas);
            this.Controls.Add(this.btnAltaAcciones);
            this.Controls.Add(this.dgvFiltrados);
            this.Controls.Add(this.dgvAccionistas);
            this.Controls.Add(this.dgvAcciones);
            this.Controls.Add(this.dgvTipos);
            this.Name = "CFormularioPrincipal";
            this.Text = "Formulario Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CFormularioPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.CFormularioPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAcciones)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccionistas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltrados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTipos;
        private System.Windows.Forms.DataGridView dgvAcciones;
        private System.Windows.Forms.DataGridView dgvAccionistas;
        private System.Windows.Forms.DataGridView dgvFiltrados;
        private System.Windows.Forms.Button btnAltaAcciones;
        private System.Windows.Forms.Button btnAltaAccionistas;
        private System.Windows.Forms.Button btnBajaAccionistas;
        private System.Windows.Forms.Button btnComprarAcciones;
        private System.Windows.Forms.Button btnVenderAcciones;
    }
}

