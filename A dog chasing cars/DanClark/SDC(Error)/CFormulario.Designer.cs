
namespace SistemaDeCobranzas
{
    partial class CFormulario
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
            this.components = new System.ComponentModel.Container();
            this.GrpGrilla1 = new System.Windows.Forms.GroupBox();
            this.CmdModificaCliente = new System.Windows.Forms.Button();
            this.CmdBajaCliente = new System.Windows.Forms.Button();
            this.CmdAltaCliente = new System.Windows.Forms.Button();
            this.TboxNombreCliente = new System.Windows.Forms.TextBox();
            this.TboxLegajoCliente = new System.Windows.Forms.TextBox();
            this.DgvListaClientes = new System.Windows.Forms.DataGridView();
            this.GrpGrilla2 = new System.Windows.Forms.GroupBox();
            this.CheckTipoCobro = new System.Windows.Forms.CheckBox();
            this.CmdPagaCobro = new System.Windows.Forms.Button();
            this.CmdAltaCobro = new System.Windows.Forms.Button();
            this.TboxImporteCobro = new System.Windows.Forms.TextBox();
            this.DtpFechaVencimientoCobro = new System.Windows.Forms.DateTimePicker();
            this.TboxNombreCobro = new System.Windows.Forms.TextBox();
            this.TboxCodigoCobro = new System.Windows.Forms.TextBox();
            this.DgvListaPendientes = new System.Windows.Forms.DataGridView();
            this.LabelInformacion = new System.Windows.Forms.Label();
            this.GrpGrilla3 = new System.Windows.Forms.GroupBox();
            this.DgvListaCanceladosG3 = new System.Windows.Forms.DataGridView();
            this.GrpGrilla4 = new System.Windows.Forms.GroupBox();
            this.RadioDescendente = new System.Windows.Forms.RadioButton();
            this.RadioAscendente = new System.Windows.Forms.RadioButton();
            this.DgvListaCanceladosG4 = new System.Windows.Forms.DataGridView();
            this.GrpGrilla5 = new System.Windows.Forms.GroupBox();
            this.DgvListaCanceladosG5 = new System.Windows.Forms.DataGridView();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.LabelSesion = new System.Windows.Forms.Label();
            this.TimerReloj = new System.Windows.Forms.Timer(this.components);
            this.GrpGrilla1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaClientes)).BeginInit();
            this.GrpGrilla2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaPendientes)).BeginInit();
            this.GrpGrilla3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCanceladosG3)).BeginInit();
            this.GrpGrilla4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCanceladosG4)).BeginInit();
            this.GrpGrilla5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCanceladosG5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // GrpGrilla1
            // 
            this.GrpGrilla1.Controls.Add(this.CmdModificaCliente);
            this.GrpGrilla1.Controls.Add(this.CmdBajaCliente);
            this.GrpGrilla1.Controls.Add(this.CmdAltaCliente);
            this.GrpGrilla1.Controls.Add(this.TboxNombreCliente);
            this.GrpGrilla1.Controls.Add(this.TboxLegajoCliente);
            this.GrpGrilla1.Controls.Add(this.DgvListaClientes);
            this.GrpGrilla1.Location = new System.Drawing.Point(12, 12);
            this.GrpGrilla1.Name = "GrpGrilla1";
            this.GrpGrilla1.Size = new System.Drawing.Size(361, 378);
            this.GrpGrilla1.TabIndex = 0;
            this.GrpGrilla1.TabStop = false;
            this.GrpGrilla1.Text = "Grilla 1: Listado de clientes";
            // 
            // CmdModificaCliente
            // 
            this.CmdModificaCliente.Enabled = false;
            this.CmdModificaCliente.Location = new System.Drawing.Point(255, 19);
            this.CmdModificaCliente.Name = "CmdModificaCliente";
            this.CmdModificaCliente.Size = new System.Drawing.Size(75, 21);
            this.CmdModificaCliente.TabIndex = 4;
            this.CmdModificaCliente.Text = "Modificación";
            this.CmdModificaCliente.UseVisualStyleBackColor = true;
            this.CmdModificaCliente.Click += new System.EventHandler(this.CmdModificaCliente_Click);
            // 
            // CmdBajaCliente
            // 
            this.CmdBajaCliente.Enabled = false;
            this.CmdBajaCliente.Location = new System.Drawing.Point(255, 48);
            this.CmdBajaCliente.Name = "CmdBajaCliente";
            this.CmdBajaCliente.Size = new System.Drawing.Size(75, 21);
            this.CmdBajaCliente.TabIndex = 5;
            this.CmdBajaCliente.Text = "Baja";
            this.CmdBajaCliente.UseVisualStyleBackColor = true;
            this.CmdBajaCliente.Click += new System.EventHandler(this.CmdBajaCliente_Click);
            // 
            // CmdAltaCliente
            // 
            this.CmdAltaCliente.Location = new System.Drawing.Point(255, 324);
            this.CmdAltaCliente.Name = "CmdAltaCliente";
            this.CmdAltaCliente.Size = new System.Drawing.Size(75, 21);
            this.CmdAltaCliente.TabIndex = 3;
            this.CmdAltaCliente.Text = "Alta";
            this.CmdAltaCliente.UseVisualStyleBackColor = true;
            this.CmdAltaCliente.Click += new System.EventHandler(this.CmdAltaCliente_Click);
            // 
            // TboxNombreCliente
            // 
            this.TboxNombreCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TboxNombreCliente.Location = new System.Drawing.Point(149, 325);
            this.TboxNombreCliente.Name = "TboxNombreCliente";
            this.TboxNombreCliente.Size = new System.Drawing.Size(100, 20);
            this.TboxNombreCliente.TabIndex = 2;
            this.TboxNombreCliente.Tag = "Nombre del Cliente";
            this.TboxNombreCliente.Text = "Nombre del Cliente";
            // 
            // TboxLegajoCliente
            // 
            this.TboxLegajoCliente.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TboxLegajoCliente.Location = new System.Drawing.Point(43, 325);
            this.TboxLegajoCliente.Name = "TboxLegajoCliente";
            this.TboxLegajoCliente.Size = new System.Drawing.Size(100, 20);
            this.TboxLegajoCliente.TabIndex = 1;
            this.TboxLegajoCliente.Tag = "Legajo";
            this.TboxLegajoCliente.Text = "Legajo";
            // 
            // DgvListaClientes
            // 
            this.DgvListaClientes.AllowUserToAddRows = false;
            this.DgvListaClientes.AllowUserToDeleteRows = false;
            this.DgvListaClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaClientes.Location = new System.Drawing.Point(6, 19);
            this.DgvListaClientes.MultiSelect = false;
            this.DgvListaClientes.Name = "DgvListaClientes";
            this.DgvListaClientes.ReadOnly = true;
            this.DgvListaClientes.Size = new System.Drawing.Size(243, 300);
            this.DgvListaClientes.TabIndex = 0;
            this.DgvListaClientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaClientes_CellClick);
            this.DgvListaClientes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvListaClientes_RowHeaderMouseClick);
            // 
            // GrpGrilla2
            // 
            this.GrpGrilla2.Controls.Add(this.CheckTipoCobro);
            this.GrpGrilla2.Controls.Add(this.CmdPagaCobro);
            this.GrpGrilla2.Controls.Add(this.CmdAltaCobro);
            this.GrpGrilla2.Controls.Add(this.TboxImporteCobro);
            this.GrpGrilla2.Controls.Add(this.DtpFechaVencimientoCobro);
            this.GrpGrilla2.Controls.Add(this.TboxNombreCobro);
            this.GrpGrilla2.Controls.Add(this.TboxCodigoCobro);
            this.GrpGrilla2.Controls.Add(this.DgvListaPendientes);
            this.GrpGrilla2.Location = new System.Drawing.Point(579, 12);
            this.GrpGrilla2.Name = "GrpGrilla2";
            this.GrpGrilla2.Size = new System.Drawing.Size(761, 154);
            this.GrpGrilla2.TabIndex = 1;
            this.GrpGrilla2.TabStop = false;
            this.GrpGrilla2.Text = "Grilla 2: Cobros pendientes del cliente";
            // 
            // CheckTipoCobro
            // 
            this.CheckTipoCobro.AutoSize = true;
            this.CheckTipoCobro.Enabled = false;
            this.CheckTipoCobro.Location = new System.Drawing.Point(136, 102);
            this.CheckTipoCobro.Name = "CheckTipoCobro";
            this.CheckTipoCobro.Size = new System.Drawing.Size(89, 17);
            this.CheckTipoCobro.TabIndex = 7;
            this.CheckTipoCobro.Text = "Tipo especial";
            this.CheckTipoCobro.UseVisualStyleBackColor = true;
            // 
            // CmdPagaCobro
            // 
            this.CmdPagaCobro.Enabled = false;
            this.CmdPagaCobro.Location = new System.Drawing.Point(655, 19);
            this.CmdPagaCobro.Name = "CmdPagaCobro";
            this.CmdPagaCobro.Size = new System.Drawing.Size(75, 21);
            this.CmdPagaCobro.TabIndex = 13;
            this.CmdPagaCobro.Text = "Pagar";
            this.CmdPagaCobro.UseVisualStyleBackColor = true;
            this.CmdPagaCobro.Click += new System.EventHandler(this.CmdPagar_Click);
            // 
            // CmdAltaCobro
            // 
            this.CmdAltaCobro.Enabled = false;
            this.CmdAltaCobro.Location = new System.Drawing.Point(655, 100);
            this.CmdAltaCobro.Name = "CmdAltaCobro";
            this.CmdAltaCobro.Size = new System.Drawing.Size(75, 21);
            this.CmdAltaCobro.TabIndex = 12;
            this.CmdAltaCobro.Text = "Alta";
            this.CmdAltaCobro.UseVisualStyleBackColor = true;
            this.CmdAltaCobro.Click += new System.EventHandler(this.CmdAltaCobro_Click);
            // 
            // TboxImporteCobro
            // 
            this.TboxImporteCobro.Enabled = false;
            this.TboxImporteCobro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TboxImporteCobro.Location = new System.Drawing.Point(549, 100);
            this.TboxImporteCobro.Name = "TboxImporteCobro";
            this.TboxImporteCobro.Size = new System.Drawing.Size(100, 20);
            this.TboxImporteCobro.TabIndex = 11;
            this.TboxImporteCobro.Tag = "Importe";
            this.TboxImporteCobro.Text = "Importe";
            // 
            // DtpFechaVencimientoCobro
            // 
            this.DtpFechaVencimientoCobro.Enabled = false;
            this.DtpFechaVencimientoCobro.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaVencimientoCobro.Location = new System.Drawing.Point(443, 100);
            this.DtpFechaVencimientoCobro.Name = "DtpFechaVencimientoCobro";
            this.DtpFechaVencimientoCobro.Size = new System.Drawing.Size(100, 20);
            this.DtpFechaVencimientoCobro.TabIndex = 10;
            // 
            // TboxNombreCobro
            // 
            this.TboxNombreCobro.Enabled = false;
            this.TboxNombreCobro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TboxNombreCobro.Location = new System.Drawing.Point(337, 100);
            this.TboxNombreCobro.Name = "TboxNombreCobro";
            this.TboxNombreCobro.Size = new System.Drawing.Size(100, 20);
            this.TboxNombreCobro.TabIndex = 9;
            this.TboxNombreCobro.Tag = "Nombre del Cobro";
            this.TboxNombreCobro.Text = "Nombre del Cobro";
            // 
            // TboxCodigoCobro
            // 
            this.TboxCodigoCobro.Enabled = false;
            this.TboxCodigoCobro.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TboxCodigoCobro.Location = new System.Drawing.Point(231, 100);
            this.TboxCodigoCobro.Name = "TboxCodigoCobro";
            this.TboxCodigoCobro.Size = new System.Drawing.Size(100, 20);
            this.TboxCodigoCobro.TabIndex = 8;
            this.TboxCodigoCobro.Tag = "Código de Cobro";
            this.TboxCodigoCobro.Text = "Código de Cobro";
            // 
            // DgvListaPendientes
            // 
            this.DgvListaPendientes.AllowUserToAddRows = false;
            this.DgvListaPendientes.AllowUserToDeleteRows = false;
            this.DgvListaPendientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaPendientes.Location = new System.Drawing.Point(6, 19);
            this.DgvListaPendientes.MultiSelect = false;
            this.DgvListaPendientes.Name = "DgvListaPendientes";
            this.DgvListaPendientes.ReadOnly = true;
            this.DgvListaPendientes.Size = new System.Drawing.Size(643, 75);
            this.DgvListaPendientes.TabIndex = 6;
            this.DgvListaPendientes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvListaPendientes_CellClick);
            this.DgvListaPendientes.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvListaPendientes_RowHeaderMouseClick);
            // 
            // LabelInformacion
            // 
            this.LabelInformacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelInformacion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInformacion.ForeColor = System.Drawing.Color.Red;
            this.LabelInformacion.Location = new System.Drawing.Point(379, 12);
            this.LabelInformacion.Name = "LabelInformacion";
            this.LabelInformacion.Size = new System.Drawing.Size(194, 154);
            this.LabelInformacion.TabIndex = 14;
            this.LabelInformacion.Text = "Bienvenido";
            this.LabelInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GrpGrilla3
            // 
            this.GrpGrilla3.Controls.Add(this.DgvListaCanceladosG3);
            this.GrpGrilla3.Location = new System.Drawing.Point(379, 396);
            this.GrpGrilla3.Name = "GrpGrilla3";
            this.GrpGrilla3.Size = new System.Drawing.Size(961, 203);
            this.GrpGrilla3.TabIndex = 2;
            this.GrpGrilla3.TabStop = false;
            this.GrpGrilla3.Text = "Grilla 3: Cobros cancelados del cliente";
            // 
            // DgvListaCanceladosG3
            // 
            this.DgvListaCanceladosG3.AllowUserToAddRows = false;
            this.DgvListaCanceladosG3.AllowUserToDeleteRows = false;
            this.DgvListaCanceladosG3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaCanceladosG3.Location = new System.Drawing.Point(6, 19);
            this.DgvListaCanceladosG3.MultiSelect = false;
            this.DgvListaCanceladosG3.Name = "DgvListaCanceladosG3";
            this.DgvListaCanceladosG3.ReadOnly = true;
            this.DgvListaCanceladosG3.Size = new System.Drawing.Size(843, 150);
            this.DgvListaCanceladosG3.TabIndex = 14;
            // 
            // GrpGrilla4
            // 
            this.GrpGrilla4.Controls.Add(this.RadioDescendente);
            this.GrpGrilla4.Controls.Add(this.RadioAscendente);
            this.GrpGrilla4.Controls.Add(this.DgvListaCanceladosG4);
            this.GrpGrilla4.Location = new System.Drawing.Point(379, 187);
            this.GrpGrilla4.Name = "GrpGrilla4";
            this.GrpGrilla4.Size = new System.Drawing.Size(961, 203);
            this.GrpGrilla4.TabIndex = 3;
            this.GrpGrilla4.TabStop = false;
            this.GrpGrilla4.Text = "Grilla 4: Cobros cancelados del cliente (ordenados por Total)";
            // 
            // RadioDescendente
            // 
            this.RadioDescendente.AutoSize = true;
            this.RadioDescendente.Enabled = false;
            this.RadioDescendente.Location = new System.Drawing.Point(855, 42);
            this.RadioDescendente.Name = "RadioDescendente";
            this.RadioDescendente.Size = new System.Drawing.Size(89, 17);
            this.RadioDescendente.TabIndex = 17;
            this.RadioDescendente.Text = "Descendente";
            this.RadioDescendente.UseVisualStyleBackColor = true;
            this.RadioDescendente.CheckedChanged += new System.EventHandler(this.RadioDescendente_CheckedChanged);
            // 
            // RadioAscendente
            // 
            this.RadioAscendente.AutoSize = true;
            this.RadioAscendente.Enabled = false;
            this.RadioAscendente.Location = new System.Drawing.Point(855, 19);
            this.RadioAscendente.Name = "RadioAscendente";
            this.RadioAscendente.Size = new System.Drawing.Size(82, 17);
            this.RadioAscendente.TabIndex = 16;
            this.RadioAscendente.Text = "Ascendente";
            this.RadioAscendente.UseVisualStyleBackColor = true;
            this.RadioAscendente.CheckedChanged += new System.EventHandler(this.RadioAscendente_CheckedChanged);
            // 
            // DgvListaCanceladosG4
            // 
            this.DgvListaCanceladosG4.AllowUserToAddRows = false;
            this.DgvListaCanceladosG4.AllowUserToDeleteRows = false;
            this.DgvListaCanceladosG4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaCanceladosG4.Location = new System.Drawing.Point(6, 19);
            this.DgvListaCanceladosG4.MultiSelect = false;
            this.DgvListaCanceladosG4.Name = "DgvListaCanceladosG4";
            this.DgvListaCanceladosG4.ReadOnly = true;
            this.DgvListaCanceladosG4.Size = new System.Drawing.Size(843, 150);
            this.DgvListaCanceladosG4.TabIndex = 15;
            // 
            // GrpGrilla5
            // 
            this.GrpGrilla5.Controls.Add(this.DgvListaCanceladosG5);
            this.GrpGrilla5.Location = new System.Drawing.Point(12, 396);
            this.GrpGrilla5.Name = "GrpGrilla5";
            this.GrpGrilla5.Size = new System.Drawing.Size(361, 203);
            this.GrpGrilla5.TabIndex = 4;
            this.GrpGrilla5.TabStop = false;
            this.GrpGrilla5.Text = "Grilla 5: Cobros cancelados del cliente (reducidos)";
            // 
            // DgvListaCanceladosG5
            // 
            this.DgvListaCanceladosG5.AllowUserToAddRows = false;
            this.DgvListaCanceladosG5.AllowUserToDeleteRows = false;
            this.DgvListaCanceladosG5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvListaCanceladosG5.Location = new System.Drawing.Point(12, 19);
            this.DgvListaCanceladosG5.MultiSelect = false;
            this.DgvListaCanceladosG5.Name = "DgvListaCanceladosG5";
            this.DgvListaCanceladosG5.ReadOnly = true;
            this.DgvListaCanceladosG5.Size = new System.Drawing.Size(243, 150);
            this.DgvListaCanceladosG5.TabIndex = 18;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // LabelSesion
            // 
            this.LabelSesion.ForeColor = System.Drawing.Color.Blue;
            this.LabelSesion.Location = new System.Drawing.Point(379, 602);
            this.LabelSesion.Name = "LabelSesion";
            this.LabelSesion.Size = new System.Drawing.Size(961, 13);
            this.LabelSesion.TabIndex = 15;
            this.LabelSesion.Text = "Sesión";
            this.LabelSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TimerReloj
            // 
            this.TimerReloj.Enabled = true;
            this.TimerReloj.Interval = 1000;
            //this.TimerReloj.Tick += new System.EventHandler(this.TimerReloj_Tick);
            // 
            // CFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1354, 621);
            this.Controls.Add(this.LabelSesion);
            this.Controls.Add(this.GrpGrilla5);
            this.Controls.Add(this.GrpGrilla3);
            this.Controls.Add(this.LabelInformacion);
            this.Controls.Add(this.GrpGrilla4);
            this.Controls.Add(this.GrpGrilla2);
            this.Controls.Add(this.GrpGrilla1);
            this.Name = "CFormulario";
            this.Text = "Sistema de Cobranzas";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CFormulario_FormClosing);
            this.Load += new System.EventHandler(this.CFormulario_Load);
            this.GrpGrilla1.ResumeLayout(false);
            this.GrpGrilla1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaClientes)).EndInit();
            this.GrpGrilla2.ResumeLayout(false);
            this.GrpGrilla2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaPendientes)).EndInit();
            this.GrpGrilla3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCanceladosG3)).EndInit();
            this.GrpGrilla4.ResumeLayout(false);
            this.GrpGrilla4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCanceladosG4)).EndInit();
            this.GrpGrilla5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DgvListaCanceladosG5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GrpGrilla1;
        private System.Windows.Forms.DataGridView DgvListaClientes;
        private System.Windows.Forms.GroupBox GrpGrilla2;
        private System.Windows.Forms.GroupBox GrpGrilla3;
        private System.Windows.Forms.GroupBox GrpGrilla4;
        private System.Windows.Forms.GroupBox GrpGrilla5;
        private System.Windows.Forms.Button CmdModificaCliente;
        private System.Windows.Forms.Button CmdBajaCliente;
        private System.Windows.Forms.Button CmdAltaCliente;
        private System.Windows.Forms.TextBox TboxNombreCliente;
        private System.Windows.Forms.TextBox TboxLegajoCliente;
        private System.Windows.Forms.DataGridView DgvListaPendientes;
        private System.Windows.Forms.Label LabelInformacion;
        private System.Windows.Forms.Button CmdPagaCobro;
        private System.Windows.Forms.Button CmdAltaCobro;
        private System.Windows.Forms.TextBox TboxImporteCobro;
        private System.Windows.Forms.DateTimePicker DtpFechaVencimientoCobro;
        private System.Windows.Forms.TextBox TboxNombreCobro;
        private System.Windows.Forms.TextBox TboxCodigoCobro;
        private System.Windows.Forms.DataGridView DgvListaCanceladosG3;
        private System.Windows.Forms.RadioButton RadioDescendente;
        private System.Windows.Forms.RadioButton RadioAscendente;
        private System.Windows.Forms.DataGridView DgvListaCanceladosG4;
        private System.Windows.Forms.DataGridView DgvListaCanceladosG5;
        private System.Windows.Forms.CheckBox CheckTipoCobro;
        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.Label LabelSesion;
        private System.Windows.Forms.Timer TimerReloj;
    }
}

