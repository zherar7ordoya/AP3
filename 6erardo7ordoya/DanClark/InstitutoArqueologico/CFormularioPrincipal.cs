using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp13
{
    public partial class CFormularioPrincipal : Form
    {
        public CFormularioPrincipal()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Descubrimiento desc;

            if (radioButton1.Checked)
            {
                
               desc = new CiudadDescubierta();
                ((CiudadDescubierta)desc).Ciudad = new Ciudad();
                ((CiudadDescubierta)desc).Ciudad.Nombre = "Buenos Aires";


            }

            else if (radioButton2.Checked)
            {
                 desc = new Tumba();
                Tumba t = (Tumba)desc;
                t.CantidadMomias = 3000;
            }
            else if (radioButton3.Checked)
            {
                 desc = new Monumento();
                desc.Presupuesto = 400f;
                label1.Text = Convert.ToString( desc.CalcularExcavacion());
            }


          

        }
    }
}
