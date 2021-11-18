using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SAS
{
    public partial class CFormulario : Form
    {
        #region // *----------------------------------------------=> Formulario
        public CFormulario() { InitializeComponent(); }

        string Usuario = String.Empty;
        private void InformaExcepcion(Control pControl, string pMensaje)
        {
            try
            {
                ErrorProvider.SetError
                    (
                    pControl,
                    pMensaje
                    );
                MessageBox.Show
                    (
                    pMensaje,
                    "Algo ha fallado...",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                    );
            }
            catch (Exception error)
            { InformaExcepcion(LabelInformacion, error.Message); }
        }
        private void IniciaFormulario()
        {
            try
            {
                Usuario = Interaction.InputBox
                    (
                    "Ingrese su nombre:",
                    "Usuario",
                    "Gerardo Tordoya"
                    );
                this.CenterToScreen();
                this.FormBorderStyle = FormBorderStyle.FixedSingle;
                this.Text += $" ({Usuario})";
                this.MaximizeBox = false;
                this.MinimizeBox = false;
            }
            catch (Exception error)
            { InformaExcepcion(LabelInformacion, error.Message); }
        }
        private void CFormulario_Load(object sender, EventArgs e)
        {
            try
            { 
                
                
                IniciaFormulario();


                foreach (Control gbox in this.Controls)
                {
                    if (gbox is GroupBox)
                    {
                        foreach (Control tbox in gbox.Controls)
                        {
                            if (tbox is TextBox)
                            {
                                //tbox.TextChanged += new EventHandler(TextBox_OnTextChanged);
                                tbox.GotFocus += new EventHandler(TboxGanaFoco);
                                tbox.LostFocus += new EventHandler(TboxPierdeFoco);
                            }
                        }
                    }
                }

                //foreach (Control gbox in this.Controls)
                //{
                //    if (gbox is GroupBox)
                //    {
                //        foreach (TextBox tbox in Controls.OfType<TextBox>())
                //        {
                //            //tbox.TextChanged += new EventHandler(TextBox_OnTextChanged);
                //            tbox.GotFocus += new EventHandler(TboxGanaFoco);
                //            tbox.LostFocus += new EventHandler(TboxPierdeFoco);
                //        }
                //    }
                //}


                //foreach (Control x in this.Controls)
                //{
                //    if (x is TextBox)
                //    {
                //        ((TextBox)x).Text = String.Empty;
                //    }
                //}





            }
            catch (Exception error)
            { InformaExcepcion(LabelInformacion, error.Message); }



        

        }
        //void TextBox_OnTextChanged(object sender, EventArgs e)
        //{
        //    TextBox tbox = (TextBox)sender;
        //    tbox.Tag = "CHANGED"; // or whatever
        //}
        public void TboxGanaFoco(object sender, EventArgs e)
        {
            TextBox tbox = (TextBox)sender;
            if (tbox.Text == tbox.Tag.ToString())
            { tbox.Text = String.Empty; }
        }
        public void TboxPierdeFoco(object sender, EventArgs e)
        {
            TextBox tbox = (TextBox)sender;
            if (String.IsNullOrWhiteSpace(tbox.Text))
            { tbox.Text = tbox.Tag.ToString(); }
        }



        private void CFormulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show
                (
                "¿Desea salir de la aplicación?",
                $"{Usuario}",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
                ) == DialogResult.No)
            { e.Cancel = true; }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
        private void TimerReloj_Tick(object sender, EventArgs e)
        { this.LabelSesion.Text = DateTime.Now.ToString(); }
        private void DtpFechaCancelacion_MouseHover(object sender, EventArgs e)
        { LabelInformacion.Text = "Fecha de Cancelación"; }
        private void DtpFechaOtorgamiento_MouseHover(object sender, EventArgs e)
        { LabelInformacion.Text = "Fecha de Otorgamiento"; }
        #endregion

        private void button9_Click(object sender, EventArgs e)
        {
            this.Controls.OfType<TextBox>().ToList().ForEach(t => t.Text = string.Empty);
        }
    }
}
