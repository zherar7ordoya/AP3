using System;
using System.Windows.Forms;
using App.Core;

namespace Calculadora
{
    public partial class CForm : Form, ICalculatorView
    {
        private readonly Presenter _Presenter;
        public CForm()
        {
            InitializeComponent();
            _Presenter = new Presenter(this);
        }
        public string ScreenDisplay
        {
            get => CalculatorScreen.Text;
            set => CalculatorScreen.Text = value;
        }
        private void NumberButton_Click(object sender, EventArgs e)
        { _Presenter.NumberButtonPressed((sender as Button).Text); }
        private void OperationButton_Click(object sender, EventArgs e)
        { _Presenter.OperatorButtonClicked((sender as Button).Text); }
    }
}
