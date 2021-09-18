
namespace Integrador_1
{
    partial class UI
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
            this.dgvPersonas = new System.Windows.Forms.DataGridView();
            this.btnAgregarPersona = new System.Windows.Forms.Button();
            this.btnBorrarPersona = new System.Windows.Forms.Button();
            this.btnModificarPersona = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvPersonas
            // 
            this.dgvPersonas.AllowUserToAddRows = false;
            this.dgvPersonas.AllowUserToDeleteRows = false;
            this.dgvPersonas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPersonas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPersonas.Location = new System.Drawing.Point(12, 12);
            this.dgvPersonas.Name = "dgvPersonas";
            this.dgvPersonas.ReadOnly = true;
            this.dgvPersonas.Size = new System.Drawing.Size(237, 150);
            this.dgvPersonas.TabIndex = 0;
            // 
            // btnAgregarPersona
            // 
            this.btnAgregarPersona.Location = new System.Drawing.Point(12, 168);
            this.btnAgregarPersona.Name = "btnAgregarPersona";
            this.btnAgregarPersona.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPersona.TabIndex = 1;
            this.btnAgregarPersona.Text = "Agregar";
            this.btnAgregarPersona.UseVisualStyleBackColor = true;
            this.btnAgregarPersona.Click += new System.EventHandler(this.btnAgregarPersona_Click);
            // 
            // btnBorrarPersona
            // 
            this.btnBorrarPersona.Location = new System.Drawing.Point(93, 168);
            this.btnBorrarPersona.Name = "btnBorrarPersona";
            this.btnBorrarPersona.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarPersona.TabIndex = 2;
            this.btnBorrarPersona.Text = "Borrar";
            this.btnBorrarPersona.UseVisualStyleBackColor = true;
            this.btnBorrarPersona.Click += new System.EventHandler(this.btnBorrarPersona_Click);
            // 
            // btnModificarPersona
            // 
            this.btnModificarPersona.Location = new System.Drawing.Point(174, 168);
            this.btnModificarPersona.Name = "btnModificarPersona";
            this.btnModificarPersona.Size = new System.Drawing.Size(75, 23);
            this.btnModificarPersona.TabIndex = 3;
            this.btnModificarPersona.Text = "Modificar";
            this.btnModificarPersona.UseVisualStyleBackColor = true;
            this.btnModificarPersona.Click += new System.EventHandler(this.btnModificarPersona_Click);
            // 
            // UI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(466, 291);
            this.Controls.Add(this.btnModificarPersona);
            this.Controls.Add(this.btnBorrarPersona);
            this.Controls.Add(this.btnAgregarPersona);
            this.Controls.Add(this.dgvPersonas);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "UI";
            this.Text = "User Interface";
            this.Load += new System.EventHandler(this.UI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPersonas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPersonas;
        private System.Windows.Forms.Button btnAgregarPersona;
        private System.Windows.Forms.Button btnBorrarPersona;
        private System.Windows.Forms.Button btnModificarPersona;
    }
}

