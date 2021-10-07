
namespace PARCIAL_1
{
    partial class AdministradorDeAdelantos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdministradorDeAdelantos));
            this.dgvBeneficiarios = new System.Windows.Forms.DataGridView();
            this.Legajo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sueldo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAdelantos = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaOtorgamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaCancelacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImporteOtorgado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ImportePagado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Beneficio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SaldoAdeudado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvAdelantosPorBeneficiario = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBeneficiarios = new System.Windows.Forms.Label();
            this.lblAdelantos = new System.Windows.Forms.Label();
            this.lblAdelantosPorBeneficiario = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiarios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantosPorBeneficiario)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvBeneficiarios
            // 
            this.dgvBeneficiarios.AllowUserToAddRows = false;
            this.dgvBeneficiarios.AllowUserToDeleteRows = false;
            this.dgvBeneficiarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBeneficiarios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Legajo,
            this.Nombre,
            this.Apellido,
            this.Sueldo});
            this.dgvBeneficiarios.Location = new System.Drawing.Point(12, 38);
            this.dgvBeneficiarios.Name = "dgvBeneficiarios";
            this.dgvBeneficiarios.ReadOnly = true;
            this.dgvBeneficiarios.Size = new System.Drawing.Size(445, 125);
            this.dgvBeneficiarios.TabIndex = 0;
            // 
            // Legajo
            // 
            this.Legajo.HeaderText = "Legajo";
            this.Legajo.Name = "Legajo";
            this.Legajo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Sueldo
            // 
            this.Sueldo.HeaderText = "Sueldo";
            this.Sueldo.Name = "Sueldo";
            this.Sueldo.ReadOnly = true;
            // 
            // dgvAdelantos
            // 
            this.dgvAdelantos.AllowUserToAddRows = false;
            this.dgvAdelantos.AllowUserToDeleteRows = false;
            this.dgvAdelantos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdelantos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.FechaOtorgamiento,
            this.FechaCancelacion,
            this.ImporteOtorgado,
            this.ImportePagado,
            this.Beneficio,
            this.SaldoAdeudado});
            this.dgvAdelantos.Location = new System.Drawing.Point(12, 195);
            this.dgvAdelantos.Name = "dgvAdelantos";
            this.dgvAdelantos.ReadOnly = true;
            this.dgvAdelantos.Size = new System.Drawing.Size(745, 125);
            this.dgvAdelantos.TabIndex = 1;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // FechaOtorgamiento
            // 
            this.FechaOtorgamiento.HeaderText = "Fecha Otorgamiento";
            this.FechaOtorgamiento.Name = "FechaOtorgamiento";
            this.FechaOtorgamiento.ReadOnly = true;
            // 
            // FechaCancelacion
            // 
            this.FechaCancelacion.HeaderText = "Fecha Cancelación";
            this.FechaCancelacion.Name = "FechaCancelacion";
            this.FechaCancelacion.ReadOnly = true;
            // 
            // ImporteOtorgado
            // 
            this.ImporteOtorgado.HeaderText = "Importe Otorgado";
            this.ImporteOtorgado.Name = "ImporteOtorgado";
            this.ImporteOtorgado.ReadOnly = true;
            // 
            // ImportePagado
            // 
            this.ImportePagado.HeaderText = "Importe Pagado";
            this.ImportePagado.Name = "ImportePagado";
            this.ImportePagado.ReadOnly = true;
            // 
            // Beneficio
            // 
            this.Beneficio.HeaderText = "Beneficio";
            this.Beneficio.Name = "Beneficio";
            this.Beneficio.ReadOnly = true;
            // 
            // SaldoAdeudado
            // 
            this.SaldoAdeudado.HeaderText = "Saldo Adeudado";
            this.SaldoAdeudado.Name = "SaldoAdeudado";
            this.SaldoAdeudado.ReadOnly = true;
            // 
            // dgvAdelantosPorBeneficiario
            // 
            this.dgvAdelantosPorBeneficiario.AllowUserToAddRows = false;
            this.dgvAdelantosPorBeneficiario.AllowUserToDeleteRows = false;
            this.dgvAdelantosPorBeneficiario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdelantosPorBeneficiario.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dgvAdelantosPorBeneficiario.Location = new System.Drawing.Point(12, 352);
            this.dgvAdelantosPorBeneficiario.Name = "dgvAdelantosPorBeneficiario";
            this.dgvAdelantosPorBeneficiario.ReadOnly = true;
            this.dgvAdelantosPorBeneficiario.Size = new System.Drawing.Size(745, 125);
            this.dgvAdelantosPorBeneficiario.TabIndex = 2;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Fecha Otorgamiento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Fecha Cancelación";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Importe Otorgado";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Importe Pagado";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Beneficio";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Saldo Adeudado";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // lblBeneficiarios
            // 
            this.lblBeneficiarios.AutoSize = true;
            this.lblBeneficiarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBeneficiarios.Location = new System.Drawing.Point(7, 9);
            this.lblBeneficiarios.Name = "lblBeneficiarios";
            this.lblBeneficiarios.Size = new System.Drawing.Size(236, 26);
            this.lblBeneficiarios.TabIndex = 3;
            this.lblBeneficiarios.Text = "Todos los Beneficiarios";
            // 
            // lblAdelantos
            // 
            this.lblAdelantos.AutoSize = true;
            this.lblAdelantos.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdelantos.Location = new System.Drawing.Point(7, 166);
            this.lblAdelantos.Name = "lblAdelantos";
            this.lblAdelantos.Size = new System.Drawing.Size(208, 26);
            this.lblAdelantos.TabIndex = 4;
            this.lblAdelantos.Text = "Todos los Adelantos";
            // 
            // lblAdelantosPorBeneficiario
            // 
            this.lblAdelantosPorBeneficiario.AutoSize = true;
            this.lblAdelantosPorBeneficiario.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdelantosPorBeneficiario.Location = new System.Drawing.Point(7, 323);
            this.lblAdelantosPorBeneficiario.Name = "lblAdelantosPorBeneficiario";
            this.lblAdelantosPorBeneficiario.Size = new System.Drawing.Size(266, 26);
            this.lblAdelantosPorBeneficiario.TabIndex = 5;
            this.lblAdelantosPorBeneficiario.Text = "Adelantos por Beneficiario";
            // 
            // AdministradorDeAdelantos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 489);
            this.Controls.Add(this.lblAdelantosPorBeneficiario);
            this.Controls.Add(this.lblAdelantos);
            this.Controls.Add(this.lblBeneficiarios);
            this.Controls.Add(this.dgvAdelantosPorBeneficiario);
            this.Controls.Add(this.dgvAdelantos);
            this.Controls.Add(this.dgvBeneficiarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AdministradorDeAdelantos";
            this.Text = "Administrador de Adelantos";
            this.Load += new System.EventHandler(this.AdministradorDeAdelantos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBeneficiarios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdelantosPorBeneficiario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvBeneficiarios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Legajo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sueldo;
        private System.Windows.Forms.DataGridView dgvAdelantos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaOtorgamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaCancelacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImporteOtorgado;
        private System.Windows.Forms.DataGridViewTextBoxColumn ImportePagado;
        private System.Windows.Forms.DataGridViewTextBoxColumn Beneficio;
        private System.Windows.Forms.DataGridViewTextBoxColumn SaldoAdeudado;
        private System.Windows.Forms.DataGridView dgvAdelantosPorBeneficiario;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label lblBeneficiarios;
        private System.Windows.Forms.Label lblAdelantos;
        private System.Windows.Forms.Label lblAdelantosPorBeneficiario;
    }
}

