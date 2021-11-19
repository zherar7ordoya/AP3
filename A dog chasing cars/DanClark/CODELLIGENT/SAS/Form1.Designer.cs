
namespace SAS
{
    partial class CFormulario
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
            this.components = new System.ComponentModel.Container();
            this.ErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.DgvTodosLosEmpleados = new System.Windows.Forms.DataGridView();
            this.GrpG1 = new System.Windows.Forms.GroupBox();
            this.RadioOperario = new System.Windows.Forms.RadioButton();
            this.RadioDirectivo = new System.Windows.Forms.RadioButton();
            this.RadioAdministrativo = new System.Windows.Forms.RadioButton();
            this.TboxG1Sueldo = new System.Windows.Forms.TextBox();
            this.TboxG1Apellido = new System.Windows.Forms.TextBox();
            this.TboxG1Nombre = new System.Windows.Forms.TextBox();
            this.MTboxLegajo = new System.Windows.Forms.MaskedTextBox();
            this.CmdG1Agregar = new System.Windows.Forms.Button();
            this.CmdG1Eliminar = new System.Windows.Forms.Button();
            this.CmdG1Modificar = new System.Windows.Forms.Button();
            this.CmdG2Pagar = new System.Windows.Forms.Button();
            this.CmdG2Asignar = new System.Windows.Forms.Button();
            this.GrpG3 = new System.Windows.Forms.GroupBox();
            this.LabelImportesAdeudados = new System.Windows.Forms.Label();
            this.LabelImportesOtorgados = new System.Windows.Forms.Label();
            this.TboxImportesAdeudados = new System.Windows.Forms.TextBox();
            this.TboxImportesOtorgados = new System.Windows.Forms.TextBox();
            this.DgvAdelantosPorEmpleado = new System.Windows.Forms.DataGridView();
            this.GrpG2 = new System.Windows.Forms.GroupBox();
            this.LabelInformacion = new System.Windows.Forms.Label();
            this.TboxG2ImportePagado = new System.Windows.Forms.TextBox();
            this.TboxG2SaldoAdeudado = new System.Windows.Forms.TextBox();
            this.TboxG2ImporteOtorgado = new System.Windows.Forms.TextBox();
            this.DtpFechaOtorgamiento = new System.Windows.Forms.DateTimePicker();
            this.TboxG2Beneficio = new System.Windows.Forms.TextBox();
            this.MTboxCodigo = new System.Windows.Forms.MaskedTextBox();
            this.CalFechaCancelacion = new System.Windows.Forms.MonthCalendar();
            this.CmdG2Agregar = new System.Windows.Forms.Button();
            this.CmdG2Eliminar = new System.Windows.Forms.Button();
            this.CmdG2Modificar = new System.Windows.Forms.Button();
            this.DgvTodosLosAdelantos = new System.Windows.Forms.DataGridView();
            this.TimerReloj = new System.Windows.Forms.Timer(this.components);
            this.LabelSesion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTodosLosEmpleados)).BeginInit();
            this.GrpG1.SuspendLayout();
            this.GrpG3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAdelantosPorEmpleado)).BeginInit();
            this.GrpG2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTodosLosAdelantos)).BeginInit();
            this.SuspendLayout();
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.ContainerControl = this;
            // 
            // DgvTodosLosEmpleados
            // 
            this.DgvTodosLosEmpleados.AllowUserToAddRows = false;
            this.DgvTodosLosEmpleados.AllowUserToDeleteRows = false;
            this.DgvTodosLosEmpleados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTodosLosEmpleados.Location = new System.Drawing.Point(6, 19);
            this.DgvTodosLosEmpleados.MultiSelect = false;
            this.DgvTodosLosEmpleados.Name = "DgvTodosLosEmpleados";
            this.DgvTodosLosEmpleados.ReadOnly = true;
            this.DgvTodosLosEmpleados.Size = new System.Drawing.Size(445, 150);
            this.DgvTodosLosEmpleados.TabIndex = 0;
            this.DgvTodosLosEmpleados.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTodosLosEmpleados_CellClick);
            this.DgvTodosLosEmpleados.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvTodosLosEmpleados_RowHeaderMouseClick);
            // 
            // GrpG1
            // 
            this.GrpG1.Controls.Add(this.RadioOperario);
            this.GrpG1.Controls.Add(this.RadioDirectivo);
            this.GrpG1.Controls.Add(this.RadioAdministrativo);
            this.GrpG1.Controls.Add(this.TboxG1Sueldo);
            this.GrpG1.Controls.Add(this.TboxG1Apellido);
            this.GrpG1.Controls.Add(this.TboxG1Nombre);
            this.GrpG1.Controls.Add(this.MTboxLegajo);
            this.GrpG1.Controls.Add(this.CmdG1Agregar);
            this.GrpG1.Controls.Add(this.CmdG1Eliminar);
            this.GrpG1.Controls.Add(this.CmdG1Modificar);
            this.GrpG1.Controls.Add(this.DgvTodosLosEmpleados);
            this.GrpG1.Location = new System.Drawing.Point(12, 12);
            this.GrpG1.Name = "GrpG1";
            this.GrpG1.Size = new System.Drawing.Size(539, 236);
            this.GrpG1.TabIndex = 2;
            this.GrpG1.TabStop = false;
            this.GrpG1.Text = "G1 Todos los Empleados";
            // 
            // RadioOperario
            // 
            this.RadioOperario.AutoSize = true;
            this.RadioOperario.Location = new System.Drawing.Point(351, 204);
            this.RadioOperario.Name = "RadioOperario";
            this.RadioOperario.Size = new System.Drawing.Size(65, 17);
            this.RadioOperario.TabIndex = 10;
            this.RadioOperario.Text = "Operario";
            this.RadioOperario.UseVisualStyleBackColor = true;
            // 
            // RadioDirectivo
            // 
            this.RadioDirectivo.AutoSize = true;
            this.RadioDirectivo.Location = new System.Drawing.Point(245, 204);
            this.RadioDirectivo.Name = "RadioDirectivo";
            this.RadioDirectivo.Size = new System.Drawing.Size(67, 17);
            this.RadioDirectivo.TabIndex = 9;
            this.RadioDirectivo.Text = "Directivo";
            this.RadioDirectivo.UseVisualStyleBackColor = true;
            // 
            // RadioAdministrativo
            // 
            this.RadioAdministrativo.AutoSize = true;
            this.RadioAdministrativo.Checked = true;
            this.RadioAdministrativo.Location = new System.Drawing.Point(139, 204);
            this.RadioAdministrativo.Name = "RadioAdministrativo";
            this.RadioAdministrativo.Size = new System.Drawing.Size(90, 17);
            this.RadioAdministrativo.TabIndex = 8;
            this.RadioAdministrativo.TabStop = true;
            this.RadioAdministrativo.Text = "Administrativo";
            this.RadioAdministrativo.UseVisualStyleBackColor = true;
            // 
            // TboxG1Sueldo
            // 
            this.TboxG1Sueldo.Location = new System.Drawing.Point(351, 178);
            this.TboxG1Sueldo.Name = "TboxG1Sueldo";
            this.TboxG1Sueldo.Size = new System.Drawing.Size(100, 20);
            this.TboxG1Sueldo.TabIndex = 4;
            this.TboxG1Sueldo.Tag = "Sueldo";
            this.TboxG1Sueldo.Text = "Sueldo";
            // 
            // TboxG1Apellido
            // 
            this.TboxG1Apellido.Location = new System.Drawing.Point(245, 178);
            this.TboxG1Apellido.Name = "TboxG1Apellido";
            this.TboxG1Apellido.Size = new System.Drawing.Size(100, 20);
            this.TboxG1Apellido.TabIndex = 3;
            this.TboxG1Apellido.Tag = "Apellido";
            this.TboxG1Apellido.Text = "Apellido";
            // 
            // TboxG1Nombre
            // 
            this.TboxG1Nombre.Location = new System.Drawing.Point(139, 178);
            this.TboxG1Nombre.Name = "TboxG1Nombre";
            this.TboxG1Nombre.Size = new System.Drawing.Size(100, 20);
            this.TboxG1Nombre.TabIndex = 2;
            this.TboxG1Nombre.Tag = "Nombre";
            this.TboxG1Nombre.Text = "Nombre";
            // 
            // MTboxLegajo
            // 
            this.MTboxLegajo.Location = new System.Drawing.Point(33, 178);
            this.MTboxLegajo.Mask = "0000";
            this.MTboxLegajo.Name = "MTboxLegajo";
            this.MTboxLegajo.Size = new System.Drawing.Size(100, 20);
            this.MTboxLegajo.TabIndex = 1;
            this.MTboxLegajo.Tag = "Legajo";
            this.MTboxLegajo.Enter += new System.EventHandler(this.MTboxLegajo_Enter);
            this.MTboxLegajo.MouseHover += new System.EventHandler(this.MTboxLegajo_MouseHover);
            // 
            // CmdG1Agregar
            // 
            this.CmdG1Agregar.Location = new System.Drawing.Point(457, 178);
            this.CmdG1Agregar.Name = "CmdG1Agregar";
            this.CmdG1Agregar.Size = new System.Drawing.Size(75, 23);
            this.CmdG1Agregar.TabIndex = 7;
            this.CmdG1Agregar.Text = "Agregar";
            this.CmdG1Agregar.UseVisualStyleBackColor = true;
            this.CmdG1Agregar.Click += new System.EventHandler(this.CmdG1Agregar_Click);
            // 
            // CmdG1Eliminar
            // 
            this.CmdG1Eliminar.Enabled = false;
            this.CmdG1Eliminar.Location = new System.Drawing.Point(457, 48);
            this.CmdG1Eliminar.Name = "CmdG1Eliminar";
            this.CmdG1Eliminar.Size = new System.Drawing.Size(75, 23);
            this.CmdG1Eliminar.TabIndex = 6;
            this.CmdG1Eliminar.Text = "Eliminar";
            this.CmdG1Eliminar.UseVisualStyleBackColor = true;
            this.CmdG1Eliminar.Click += new System.EventHandler(this.CmdG1Eliminar_Click);
            // 
            // CmdG1Modificar
            // 
            this.CmdG1Modificar.Enabled = false;
            this.CmdG1Modificar.Location = new System.Drawing.Point(457, 19);
            this.CmdG1Modificar.Name = "CmdG1Modificar";
            this.CmdG1Modificar.Size = new System.Drawing.Size(75, 23);
            this.CmdG1Modificar.TabIndex = 5;
            this.CmdG1Modificar.Text = "Modificar";
            this.CmdG1Modificar.UseVisualStyleBackColor = true;
            this.CmdG1Modificar.Click += new System.EventHandler(this.CmdG1Modificar_Click);
            // 
            // CmdG2Pagar
            // 
            this.CmdG2Pagar.Enabled = false;
            this.CmdG2Pagar.Location = new System.Drawing.Point(260, 189);
            this.CmdG2Pagar.Name = "CmdG2Pagar";
            this.CmdG2Pagar.Size = new System.Drawing.Size(75, 23);
            this.CmdG2Pagar.TabIndex = 20;
            this.CmdG2Pagar.Text = "Pagar";
            this.CmdG2Pagar.UseVisualStyleBackColor = true;
            this.CmdG2Pagar.Click += new System.EventHandler(this.CmdG2Pagar_Click);
            // 
            // CmdG2Asignar
            // 
            this.CmdG2Asignar.Enabled = false;
            this.CmdG2Asignar.Location = new System.Drawing.Point(376, 189);
            this.CmdG2Asignar.Name = "CmdG2Asignar";
            this.CmdG2Asignar.Size = new System.Drawing.Size(75, 23);
            this.CmdG2Asignar.TabIndex = 17;
            this.CmdG2Asignar.Text = "Asignar";
            this.CmdG2Asignar.UseVisualStyleBackColor = true;
            this.CmdG2Asignar.Click += new System.EventHandler(this.CmdG2Asignar_Click);
            // 
            // GrpG3
            // 
            this.GrpG3.Controls.Add(this.LabelImportesAdeudados);
            this.GrpG3.Controls.Add(this.LabelImportesOtorgados);
            this.GrpG3.Controls.Add(this.TboxImportesAdeudados);
            this.GrpG3.Controls.Add(this.TboxImportesOtorgados);
            this.GrpG3.Controls.Add(this.DgvAdelantosPorEmpleado);
            this.GrpG3.Location = new System.Drawing.Point(557, 12);
            this.GrpG3.Name = "GrpG3";
            this.GrpG3.Size = new System.Drawing.Size(758, 236);
            this.GrpG3.TabIndex = 7;
            this.GrpG3.TabStop = false;
            this.GrpG3.Text = "G3 Adelantos por Empleado";
            // 
            // LabelImportesAdeudados
            // 
            this.LabelImportesAdeudados.Location = new System.Drawing.Point(544, 204);
            this.LabelImportesAdeudados.Name = "LabelImportesAdeudados";
            this.LabelImportesAdeudados.Size = new System.Drawing.Size(100, 20);
            this.LabelImportesAdeudados.TabIndex = 25;
            this.LabelImportesAdeudados.Text = "Total Adeudado";
            this.LabelImportesAdeudados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // LabelImportesOtorgados
            // 
            this.LabelImportesOtorgados.Location = new System.Drawing.Point(544, 178);
            this.LabelImportesOtorgados.Name = "LabelImportesOtorgados";
            this.LabelImportesOtorgados.Size = new System.Drawing.Size(100, 20);
            this.LabelImportesOtorgados.TabIndex = 24;
            this.LabelImportesOtorgados.Text = "Total Otorgado";
            this.LabelImportesOtorgados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // TboxImportesAdeudados
            // 
            this.TboxImportesAdeudados.Enabled = false;
            this.TboxImportesAdeudados.Location = new System.Drawing.Point(650, 204);
            this.TboxImportesAdeudados.Name = "TboxImportesAdeudados";
            this.TboxImportesAdeudados.Size = new System.Drawing.Size(100, 20);
            this.TboxImportesAdeudados.TabIndex = 23;
            this.TboxImportesAdeudados.Tag = "Importes Adeudados";
            this.TboxImportesAdeudados.Text = "Importes Adeudados";
            // 
            // TboxImportesOtorgados
            // 
            this.TboxImportesOtorgados.Enabled = false;
            this.TboxImportesOtorgados.Location = new System.Drawing.Point(650, 178);
            this.TboxImportesOtorgados.Name = "TboxImportesOtorgados";
            this.TboxImportesOtorgados.Size = new System.Drawing.Size(100, 20);
            this.TboxImportesOtorgados.TabIndex = 22;
            this.TboxImportesOtorgados.Tag = "Importes Otorgados";
            this.TboxImportesOtorgados.Text = "Importes Otorgados";
            // 
            // DgvAdelantosPorEmpleado
            // 
            this.DgvAdelantosPorEmpleado.AllowUserToAddRows = false;
            this.DgvAdelantosPorEmpleado.AllowUserToDeleteRows = false;
            this.DgvAdelantosPorEmpleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvAdelantosPorEmpleado.Location = new System.Drawing.Point(6, 19);
            this.DgvAdelantosPorEmpleado.MultiSelect = false;
            this.DgvAdelantosPorEmpleado.Name = "DgvAdelantosPorEmpleado";
            this.DgvAdelantosPorEmpleado.ReadOnly = true;
            this.DgvAdelantosPorEmpleado.Size = new System.Drawing.Size(744, 150);
            this.DgvAdelantosPorEmpleado.TabIndex = 21;
            // 
            // GrpG2
            // 
            this.GrpG2.Controls.Add(this.LabelInformacion);
            this.GrpG2.Controls.Add(this.TboxG2ImportePagado);
            this.GrpG2.Controls.Add(this.TboxG2SaldoAdeudado);
            this.GrpG2.Controls.Add(this.TboxG2ImporteOtorgado);
            this.GrpG2.Controls.Add(this.DtpFechaOtorgamiento);
            this.GrpG2.Controls.Add(this.TboxG2Beneficio);
            this.GrpG2.Controls.Add(this.MTboxCodigo);
            this.GrpG2.Controls.Add(this.CalFechaCancelacion);
            this.GrpG2.Controls.Add(this.CmdG2Agregar);
            this.GrpG2.Controls.Add(this.CmdG2Eliminar);
            this.GrpG2.Controls.Add(this.CmdG2Modificar);
            this.GrpG2.Controls.Add(this.CmdG2Asignar);
            this.GrpG2.Controls.Add(this.CmdG2Pagar);
            this.GrpG2.Controls.Add(this.DgvTodosLosAdelantos);
            this.GrpG2.Location = new System.Drawing.Point(12, 283);
            this.GrpG2.Name = "GrpG2";
            this.GrpG2.Size = new System.Drawing.Size(1303, 236);
            this.GrpG2.TabIndex = 8;
            this.GrpG2.TabStop = false;
            this.GrpG2.Text = "G2 Todos los Adelantos";
            // 
            // LabelInformacion
            // 
            this.LabelInformacion.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.LabelInformacion.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LabelInformacion.ForeColor = System.Drawing.Color.Red;
            this.LabelInformacion.Location = new System.Drawing.Point(260, 19);
            this.LabelInformacion.Name = "LabelInformacion";
            this.LabelInformacion.Size = new System.Drawing.Size(191, 162);
            this.LabelInformacion.TabIndex = 0;
            this.LabelInformacion.Text = "Información";
            this.LabelInformacion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TboxG2ImportePagado
            // 
            this.TboxG2ImportePagado.Enabled = false;
            this.TboxG2ImportePagado.Location = new System.Drawing.Point(154, 189);
            this.TboxG2ImportePagado.Name = "TboxG2ImportePagado";
            this.TboxG2ImportePagado.Size = new System.Drawing.Size(100, 20);
            this.TboxG2ImportePagado.TabIndex = 19;
            this.TboxG2ImportePagado.Tag = "Importe Pagado";
            this.TboxG2ImportePagado.Text = "Importe Pagado";
            // 
            // TboxG2SaldoAdeudado
            // 
            this.TboxG2SaldoAdeudado.Enabled = false;
            this.TboxG2SaldoAdeudado.Location = new System.Drawing.Point(975, 189);
            this.TboxG2SaldoAdeudado.Name = "TboxG2SaldoAdeudado";
            this.TboxG2SaldoAdeudado.Size = new System.Drawing.Size(100, 20);
            this.TboxG2SaldoAdeudado.TabIndex = 13;
            this.TboxG2SaldoAdeudado.Tag = "Saldo Adeudado";
            this.TboxG2SaldoAdeudado.Text = "Saldo Adeudado";
            // 
            // TboxG2ImporteOtorgado
            // 
            this.TboxG2ImporteOtorgado.Location = new System.Drawing.Point(763, 189);
            this.TboxG2ImporteOtorgado.Name = "TboxG2ImporteOtorgado";
            this.TboxG2ImporteOtorgado.Size = new System.Drawing.Size(100, 20);
            this.TboxG2ImporteOtorgado.TabIndex = 11;
            this.TboxG2ImporteOtorgado.Tag = "Importe Otorgado";
            this.TboxG2ImporteOtorgado.Text = "Importe Otorgado";
            // 
            // DtpFechaOtorgamiento
            // 
            this.DtpFechaOtorgamiento.AccessibleName = "";
            this.DtpFechaOtorgamiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DtpFechaOtorgamiento.Location = new System.Drawing.Point(657, 189);
            this.DtpFechaOtorgamiento.Name = "DtpFechaOtorgamiento";
            this.DtpFechaOtorgamiento.Size = new System.Drawing.Size(100, 20);
            this.DtpFechaOtorgamiento.TabIndex = 10;
            this.DtpFechaOtorgamiento.Enter += new System.EventHandler(this.DtpFechaOtorgamiento_Enter);
            this.DtpFechaOtorgamiento.MouseHover += new System.EventHandler(this.DtpFechaOtorgamiento_MouseHover);
            // 
            // TboxG2Beneficio
            // 
            this.TboxG2Beneficio.Enabled = false;
            this.TboxG2Beneficio.Location = new System.Drawing.Point(869, 189);
            this.TboxG2Beneficio.Name = "TboxG2Beneficio";
            this.TboxG2Beneficio.Size = new System.Drawing.Size(100, 20);
            this.TboxG2Beneficio.TabIndex = 12;
            this.TboxG2Beneficio.Tag = "Beneficio";
            this.TboxG2Beneficio.Text = "Beneficio";
            // 
            // MTboxCodigo
            // 
            this.MTboxCodigo.Location = new System.Drawing.Point(551, 189);
            this.MTboxCodigo.Mask = "0000LLLL";
            this.MTboxCodigo.Name = "MTboxCodigo";
            this.MTboxCodigo.Size = new System.Drawing.Size(100, 20);
            this.MTboxCodigo.TabIndex = 9;
            this.MTboxCodigo.Tag = "Código";
            this.MTboxCodigo.Enter += new System.EventHandler(this.MTboxCodigo_Enter);
            this.MTboxCodigo.MouseHover += new System.EventHandler(this.MTboxCodigo_MouseHover);
            // 
            // CalFechaCancelacion
            // 
            this.CalFechaCancelacion.Enabled = false;
            this.CalFechaCancelacion.Location = new System.Drawing.Point(6, 19);
            this.CalFechaCancelacion.Name = "CalFechaCancelacion";
            this.CalFechaCancelacion.TabIndex = 18;
            this.CalFechaCancelacion.Enter += new System.EventHandler(this.CalFechaCancelacion_Enter);
            this.CalFechaCancelacion.MouseHover += new System.EventHandler(this.CalFechaCancelacion_MouseHover);
            // 
            // CmdG2Agregar
            // 
            this.CmdG2Agregar.Location = new System.Drawing.Point(457, 189);
            this.CmdG2Agregar.Name = "CmdG2Agregar";
            this.CmdG2Agregar.Size = new System.Drawing.Size(75, 23);
            this.CmdG2Agregar.TabIndex = 16;
            this.CmdG2Agregar.Text = "Agregar";
            this.CmdG2Agregar.UseVisualStyleBackColor = true;
            this.CmdG2Agregar.Click += new System.EventHandler(this.CmdG2Agregar_Click);
            // 
            // CmdG2Eliminar
            // 
            this.CmdG2Eliminar.Enabled = false;
            this.CmdG2Eliminar.Location = new System.Drawing.Point(457, 48);
            this.CmdG2Eliminar.Name = "CmdG2Eliminar";
            this.CmdG2Eliminar.Size = new System.Drawing.Size(75, 23);
            this.CmdG2Eliminar.TabIndex = 15;
            this.CmdG2Eliminar.Text = "Eliminar";
            this.CmdG2Eliminar.UseVisualStyleBackColor = true;
            this.CmdG2Eliminar.Click += new System.EventHandler(this.CmdG2Eliminar_Click);
            // 
            // CmdG2Modificar
            // 
            this.CmdG2Modificar.Enabled = false;
            this.CmdG2Modificar.Location = new System.Drawing.Point(457, 19);
            this.CmdG2Modificar.Name = "CmdG2Modificar";
            this.CmdG2Modificar.Size = new System.Drawing.Size(75, 23);
            this.CmdG2Modificar.TabIndex = 14;
            this.CmdG2Modificar.Text = "Modificar";
            this.CmdG2Modificar.UseVisualStyleBackColor = true;
            this.CmdG2Modificar.Click += new System.EventHandler(this.CmdG2Modificar_Click);
            // 
            // DgvTodosLosAdelantos
            // 
            this.DgvTodosLosAdelantos.AllowUserToAddRows = false;
            this.DgvTodosLosAdelantos.AllowUserToDeleteRows = false;
            this.DgvTodosLosAdelantos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvTodosLosAdelantos.Location = new System.Drawing.Point(551, 19);
            this.DgvTodosLosAdelantos.MultiSelect = false;
            this.DgvTodosLosAdelantos.Name = "DgvTodosLosAdelantos";
            this.DgvTodosLosAdelantos.ReadOnly = true;
            this.DgvTodosLosAdelantos.Size = new System.Drawing.Size(744, 162);
            this.DgvTodosLosAdelantos.TabIndex = 8;
            this.DgvTodosLosAdelantos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvTodosLosAdelantos_CellClick);
            this.DgvTodosLosAdelantos.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvTodosLosAdelantos_RowHeaderMouseClick);
            // 
            // TimerReloj
            // 
            this.TimerReloj.Enabled = true;
            this.TimerReloj.Interval = 1000;
            this.TimerReloj.Tick += new System.EventHandler(this.TimerReloj_Tick);
            // 
            // LabelSesion
            // 
            this.LabelSesion.Enabled = false;
            this.LabelSesion.Location = new System.Drawing.Point(1086, 522);
            this.LabelSesion.Name = "LabelSesion";
            this.LabelSesion.Size = new System.Drawing.Size(229, 20);
            this.LabelSesion.TabIndex = 9;
            this.LabelSesion.Text = "Información de Sesión";
            this.LabelSesion.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // CFormulario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1325, 554);
            this.Controls.Add(this.LabelSesion);
            this.Controls.Add(this.GrpG2);
            this.Controls.Add(this.GrpG3);
            this.Controls.Add(this.GrpG1);
            this.Name = "CFormulario";
            this.Text = "Sistema de Adelantos de Sueldo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CFormulario_FormClosing);
            this.Load += new System.EventHandler(this.CFormulario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTodosLosEmpleados)).EndInit();
            this.GrpG1.ResumeLayout(false);
            this.GrpG1.PerformLayout();
            this.GrpG3.ResumeLayout(false);
            this.GrpG3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvAdelantosPorEmpleado)).EndInit();
            this.GrpG2.ResumeLayout(false);
            this.GrpG2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgvTodosLosAdelantos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider ErrorProvider;
        private System.Windows.Forms.DataGridView DgvTodosLosEmpleados;
        private System.Windows.Forms.Button CmdG2Asignar;
        private System.Windows.Forms.GroupBox GrpG1;
        private System.Windows.Forms.TextBox TboxG1Sueldo;
        private System.Windows.Forms.TextBox TboxG1Apellido;
        private System.Windows.Forms.TextBox TboxG1Nombre;
        private System.Windows.Forms.MaskedTextBox MTboxLegajo;
        private System.Windows.Forms.Button CmdG1Agregar;
        private System.Windows.Forms.Button CmdG1Eliminar;
        private System.Windows.Forms.Button CmdG1Modificar;
        private System.Windows.Forms.Button CmdG2Pagar;
        private System.Windows.Forms.GroupBox GrpG2;
        private System.Windows.Forms.GroupBox GrpG3;
        private System.Windows.Forms.DataGridView DgvAdelantosPorEmpleado;
        private System.Windows.Forms.DataGridView DgvTodosLosAdelantos;
        private System.Windows.Forms.Button CmdG2Agregar;
        private System.Windows.Forms.Button CmdG2Eliminar;
        private System.Windows.Forms.Button CmdG2Modificar;
        private System.Windows.Forms.MaskedTextBox MTboxCodigo;
        private System.Windows.Forms.DateTimePicker DtpFechaOtorgamiento;
        private System.Windows.Forms.TextBox TboxG2Beneficio;
        private System.Windows.Forms.TextBox TboxG2ImporteOtorgado;
        private System.Windows.Forms.TextBox TboxG2ImportePagado;
        private System.Windows.Forms.TextBox TboxG2SaldoAdeudado;
        private System.Windows.Forms.Label LabelInformacion;
        private System.Windows.Forms.MonthCalendar CalFechaCancelacion;
        private System.Windows.Forms.Timer TimerReloj;
        private System.Windows.Forms.Label LabelSesion;
        private System.Windows.Forms.Label LabelImportesAdeudados;
        private System.Windows.Forms.Label LabelImportesOtorgados;
        private System.Windows.Forms.TextBox TboxImportesAdeudados;
        private System.Windows.Forms.TextBox TboxImportesOtorgados;
        private System.Windows.Forms.RadioButton RadioOperario;
        private System.Windows.Forms.RadioButton RadioDirectivo;
        private System.Windows.Forms.RadioButton RadioAdministrativo;
    }
}

