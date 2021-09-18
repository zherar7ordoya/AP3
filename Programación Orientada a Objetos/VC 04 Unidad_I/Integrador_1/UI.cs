using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Integrador_1
{
    public partial class UI : Form
    {
        Concesionario _c;
        public UI()
        {
            InitializeComponent();
            _c = new Concesionario();
        }
    }
}
