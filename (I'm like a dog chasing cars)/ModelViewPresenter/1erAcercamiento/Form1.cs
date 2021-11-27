using ModelViewPresenter.Presenters;
using ModelViewPresenter.Views;
using System;
using System.Windows.Forms;

namespace ModelViewPresenter
{
    public partial class Form1 : Form, IRectangulo
    {
        public Form1() { InitializeComponent(); }

        public string TextoLargo
        {
            get { return TboxLargo.Text; }
            set { TboxLargo.Text = value; }
        }
        public string TextoAncho
        {
            get { return TboxAncho.Text; }
            set { TboxAncho.Text = value; }
        }
        public string TextoArea
        {
            get { return TboxArea.Text; }
            set { TboxArea.Text = value; }
        }

        private void CmdCalcula_Click(object sender, EventArgs e)
        {
            CRectanguloPresenter presentador = new CRectanguloPresenter(this);
            presentador.CalculaArea();
        }
    }
}