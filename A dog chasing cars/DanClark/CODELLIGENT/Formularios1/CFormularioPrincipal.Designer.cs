
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
            this.dgvAccionesDisponibles = new System.Windows.Forms.DataGridView();
            this.dgvAccionistas = new System.Windows.Forms.DataGridView();
            this.dgvAccionesPorAccionista = new System.Windows.Forms.DataGridView();
            this.btnAltaAcciones = new System.Windows.Forms.Button();
            this.btnAltaAccionistas = new System.Windows.Forms.Button();
            this.btnBajaAccionistas = new System.Windows.Forms.Button();
            this.btnComprarAcciones = new System.Windows.Forms.Button();
            this.btnVenderAcciones = new System.Windows.Forms.Button();
            this.grpTipo = new System.Windows.Forms.GroupBox();
            this.rbnTipoG = new System.Windows.Forms.RadioButton();
            this.rbnTipoF = new System.Windows.Forms.RadioButton();
            this.rbnTipoE = new System.Windows.Forms.RadioButton();
            this.rbnTipoD = new System.Windows.Forms.RadioButton();
            this.rbnTipoC = new System.Windows.Forms.RadioButton();
            this.rbnTipoB = new System.Windows.Forms.RadioButton();
            this.rbnTipoA = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccionesDisponibles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccionistas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccionesPorAccionista)).BeginInit();
            this.grpTipo.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvAccionesDisponibles
            // 
            this.dgvAccionesDisponibles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccionesDisponibles.Location = new System.Drawing.Point(90, 12);
            this.dgvAccionesDisponibles.Name = "dgvAccionesDisponibles";
            this.dgvAccionesDisponibles.Size = new System.Drawing.Size(240, 188);
            this.dgvAccionesDisponibles.TabIndex = 1;
            // 
            // dgvAccionistas
            // 
            this.dgvAccionistas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccionistas.Location = new System.Drawing.Point(394, 12);
            this.dgvAccionistas.Name = "dgvAccionistas";
            this.dgvAccionistas.Size = new System.Drawing.Size(240, 188);
            this.dgvAccionistas.TabIndex = 2;
            this.dgvAccionistas.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAccionistas_CellEnter);
            // 
            // dgvAccionesPorAccionista
            // 
            this.dgvAccionesPorAccionista.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccionesPorAccionista.Location = new System.Drawing.Point(90, 264);
            this.dgvAccionesPorAccionista.Name = "dgvAccionesPorAccionista";
            this.dgvAccionesPorAccionista.Size = new System.Drawing.Size(544, 188);
            this.dgvAccionesPorAccionista.TabIndex = 3;
            // 
            // btnAltaAcciones
            // 
            this.btnAltaAcciones.Location = new System.Drawing.Point(90, 206);
            this.btnAltaAcciones.Name = "btnAltaAcciones";
            this.btnAltaAcciones.Size = new System.Drawing.Size(115, 23);
            this.btnAltaAcciones.TabIndex = 4;
            this.btnAltaAcciones.Text = "Alta de acción";
            this.btnAltaAcciones.UseVisualStyleBackColor = true;
            this.btnAltaAcciones.Click += new System.EventHandler(this.btnAltaAcciones_Click);
            // 
            // btnAltaAccionistas
            // 
            this.btnAltaAccionistas.Location = new System.Drawing.Point(394, 206);
            this.btnAltaAccionistas.Name = "btnAltaAccionistas";
            this.btnAltaAccionistas.Size = new System.Drawing.Size(115, 23);
            this.btnAltaAccionistas.TabIndex = 5;
            this.btnAltaAccionistas.Text = "Alta de accionista";
            this.btnAltaAccionistas.UseVisualStyleBackColor = true;
            this.btnAltaAccionistas.Click += new System.EventHandler(this.btnAltaAccionistas_Click);
            // 
            // btnBajaAccionistas
            // 
            this.btnBajaAccionistas.Location = new System.Drawing.Point(519, 206);
            this.btnBajaAccionistas.Name = "btnBajaAccionistas";
            this.btnBajaAccionistas.Size = new System.Drawing.Size(115, 23);
            this.btnBajaAccionistas.TabIndex = 6;
            this.btnBajaAccionistas.Text = "Baja de accionista";
            this.btnBajaAccionistas.UseVisualStyleBackColor = true;
            this.btnBajaAccionistas.Click += new System.EventHandler(this.btnBajaAccionistas_Click);
            // 
            // btnComprarAcciones
            // 
            this.btnComprarAcciones.Location = new System.Drawing.Point(214, 458);
            this.btnComprarAcciones.Name = "btnComprarAcciones";
            this.btnComprarAcciones.Size = new System.Drawing.Size(116, 23);
            this.btnComprarAcciones.TabIndex = 7;
            this.btnComprarAcciones.Text = "Comprar acción";
            this.btnComprarAcciones.UseVisualStyleBackColor = true;
            this.btnComprarAcciones.Click += new System.EventHandler(this.btnComprarAcciones_Click);
            // 
            // btnVenderAcciones
            // 
            this.btnVenderAcciones.Location = new System.Drawing.Point(394, 458);
            this.btnVenderAcciones.Name = "btnVenderAcciones";
            this.btnVenderAcciones.Size = new System.Drawing.Size(116, 23);
            this.btnVenderAcciones.TabIndex = 8;
            this.btnVenderAcciones.Text = "Vender acción";
            this.btnVenderAcciones.UseVisualStyleBackColor = true;
            this.btnVenderAcciones.Click += new System.EventHandler(this.btnVenderAcciones_Click);
            // 
            // grpTipo
            // 
            this.grpTipo.Controls.Add(this.rbnTipoG);
            this.grpTipo.Controls.Add(this.rbnTipoF);
            this.grpTipo.Controls.Add(this.rbnTipoE);
            this.grpTipo.Controls.Add(this.rbnTipoD);
            this.grpTipo.Controls.Add(this.rbnTipoC);
            this.grpTipo.Controls.Add(this.rbnTipoB);
            this.grpTipo.Controls.Add(this.rbnTipoA);
            this.grpTipo.Location = new System.Drawing.Point(12, 12);
            this.grpTipo.Name = "grpTipo";
            this.grpTipo.Size = new System.Drawing.Size(72, 188);
            this.grpTipo.TabIndex = 9;
            this.grpTipo.TabStop = false;
            this.grpTipo.Text = "Tipo";
            // 
            // rbnTipoG
            // 
            this.rbnTipoG.AutoSize = true;
            this.rbnTipoG.Location = new System.Drawing.Point(6, 157);
            this.rbnTipoG.Name = "rbnTipoG";
            this.rbnTipoG.Size = new System.Drawing.Size(57, 17);
            this.rbnTipoG.TabIndex = 6;
            this.rbnTipoG.Text = "Tipo G";
            this.rbnTipoG.UseVisualStyleBackColor = true;
            // 
            // rbnTipoF
            // 
            this.rbnTipoF.AutoSize = true;
            this.rbnTipoF.Location = new System.Drawing.Point(6, 134);
            this.rbnTipoF.Name = "rbnTipoF";
            this.rbnTipoF.Size = new System.Drawing.Size(55, 17);
            this.rbnTipoF.TabIndex = 5;
            this.rbnTipoF.Text = "Tipo F";
            this.rbnTipoF.UseVisualStyleBackColor = true;
            // 
            // rbnTipoE
            // 
            this.rbnTipoE.AutoSize = true;
            this.rbnTipoE.Location = new System.Drawing.Point(6, 111);
            this.rbnTipoE.Name = "rbnTipoE";
            this.rbnTipoE.Size = new System.Drawing.Size(56, 17);
            this.rbnTipoE.TabIndex = 4;
            this.rbnTipoE.Text = "Tipo E";
            this.rbnTipoE.UseVisualStyleBackColor = true;
            // 
            // rbnTipoD
            // 
            this.rbnTipoD.AutoSize = true;
            this.rbnTipoD.Location = new System.Drawing.Point(6, 88);
            this.rbnTipoD.Name = "rbnTipoD";
            this.rbnTipoD.Size = new System.Drawing.Size(57, 17);
            this.rbnTipoD.TabIndex = 3;
            this.rbnTipoD.Text = "Tipo D";
            this.rbnTipoD.UseVisualStyleBackColor = true;
            // 
            // rbnTipoC
            // 
            this.rbnTipoC.AutoSize = true;
            this.rbnTipoC.Location = new System.Drawing.Point(6, 65);
            this.rbnTipoC.Name = "rbnTipoC";
            this.rbnTipoC.Size = new System.Drawing.Size(56, 17);
            this.rbnTipoC.TabIndex = 2;
            this.rbnTipoC.Text = "Tipo C";
            this.rbnTipoC.UseVisualStyleBackColor = true;
            // 
            // rbnTipoB
            // 
            this.rbnTipoB.AutoSize = true;
            this.rbnTipoB.Location = new System.Drawing.Point(6, 42);
            this.rbnTipoB.Name = "rbnTipoB";
            this.rbnTipoB.Size = new System.Drawing.Size(56, 17);
            this.rbnTipoB.TabIndex = 1;
            this.rbnTipoB.Text = "Tipo B";
            this.rbnTipoB.UseVisualStyleBackColor = true;
            // 
            // rbnTipoA
            // 
            this.rbnTipoA.AutoSize = true;
            this.rbnTipoA.Checked = true;
            this.rbnTipoA.Location = new System.Drawing.Point(6, 19);
            this.rbnTipoA.Name = "rbnTipoA";
            this.rbnTipoA.Size = new System.Drawing.Size(56, 17);
            this.rbnTipoA.TabIndex = 0;
            this.rbnTipoA.TabStop = true;
            this.rbnTipoA.Text = "Tipo A";
            this.rbnTipoA.UseVisualStyleBackColor = true;
            // 
            // CFormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 518);
            this.Controls.Add(this.grpTipo);
            this.Controls.Add(this.btnVenderAcciones);
            this.Controls.Add(this.btnComprarAcciones);
            this.Controls.Add(this.btnBajaAccionistas);
            this.Controls.Add(this.btnAltaAccionistas);
            this.Controls.Add(this.btnAltaAcciones);
            this.Controls.Add(this.dgvAccionesPorAccionista);
            this.Controls.Add(this.dgvAccionistas);
            this.Controls.Add(this.dgvAccionesDisponibles);
            this.Name = "CFormularioPrincipal";
            this.Text = "Formulario Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CFormularioPrincipal_FormClosing);
            this.Load += new System.EventHandler(this.CFormularioPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccionesDisponibles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccionistas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccionesPorAccionista)).EndInit();
            this.grpTipo.ResumeLayout(false);
            this.grpTipo.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvAccionesDisponibles;
        private System.Windows.Forms.DataGridView dgvAccionistas;
        private System.Windows.Forms.DataGridView dgvAccionesPorAccionista;
        private System.Windows.Forms.Button btnAltaAcciones;
        private System.Windows.Forms.Button btnAltaAccionistas;
        private System.Windows.Forms.Button btnBajaAccionistas;
        private System.Windows.Forms.Button btnComprarAcciones;
        private System.Windows.Forms.Button btnVenderAcciones;
        private System.Windows.Forms.GroupBox grpTipo;
        private System.Windows.Forms.RadioButton rbnTipoG;
        private System.Windows.Forms.RadioButton rbnTipoF;
        private System.Windows.Forms.RadioButton rbnTipoE;
        private System.Windows.Forms.RadioButton rbnTipoD;
        private System.Windows.Forms.RadioButton rbnTipoC;
        private System.Windows.Forms.RadioButton rbnTipoB;
        private System.Windows.Forms.RadioButton rbnTipoA;
    }
}

