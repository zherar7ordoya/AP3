using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp14
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ITocable instrumento;
            if (radioButton1.Checked)
            {
                instrumento = new Piano();
                instrumento.Nombre = "Piano";

            }
            else if (radioButton2.Checked)
            {
                instrumento = new Guitarra();
                instrumento.Nombre = "Guitarra"; 
            }
            else
            {
                instrumento = new Rallador();
                instrumento.Nombre = "Rallador";
            }

            listBox1.Items.Add(instrumento);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem!=null)
            {
                ITocable instrumento = (ITocable)listBox1.SelectedItem;
                label1.Text = instrumento.Tocar();

                if (instrumento is Instrumento)
                {
                    label2.Text = instrumento.Nombre + " Es un instrumento musical";
                }
                else
                {
                    label2.Text = instrumento.Nombre + " No es un instrumento musical";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //El elemento seleccionado no sea null
            if (listBox1.SelectedItem!=null)
            {
                //El elemento seleccionado sea Iafinable
                if (listBox1.SelectedItem is IAfinable)
                {
                    //Si es true busca que el metodo Afinar
                    label3.Text = ((IAfinable)listBox1.SelectedItem).Afinar();
                }
                else
                {
                    //si es false informa que no puede afinar el instrumento
                    label3.Text = "El instrumento no se puede afinar";
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
