using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Icomparer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Persona p1;
        Persona p2;
        Persona p3;
        List<Persona> l;
        private void Form1_Load(object sender, EventArgs e)
        {
            p1 = new Persona("Juan", "Garcia", 22);
            p2 = new Persona("Ana", "Perez", 35);
            p3 = new Persona("Cecilia", "Alvarez", 29);
            l = new List<Persona>() { p1, p2, p3 };

            listBox1.Items.AddRange(l.ToArray());
            l.Sort(new Persona.NombreASC()); listBox2.Items.AddRange(l.ToArray());
            l.Sort(new Persona.NombreDESC()); listBox3.Items.AddRange(l.ToArray());
            l.Sort(new Persona.ApellidoASC()); listBox4.Items.AddRange(l.ToArray());
            l.Sort(new Persona.ApellidoDESC()); listBox5.Items.AddRange(l.ToArray());
            l.Sort(new Persona.EdadASC()); listBox6.Items.AddRange(l.ToArray());
            l.Sort(new Persona.EdadDESC()); listBox7.Items.AddRange(l.ToArray());

            Array.Sort()
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
    public class Persona
    {
      
        public Persona(string pNombre, string pApellido, int pEdad) { Nombre = pNombre; Apellido = pApellido; Edad = pEdad; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public override string ToString()
        {
            return $"{Nombre} {Apellido} {Edad}";
        }
        public class NombreASC : IComparer<Persona>
        {
            public int Compare(Persona x, Persona y)
            {
                return x.Nombre.CompareTo(y.Nombre);
            }
        }
        public class NombreDESC : IComparer<Persona>
        {
            public int Compare(Persona x, Persona y)
            {
                return (x.Nombre.CompareTo(y.Nombre))*-1;
            }
        }
        public class ApellidoASC : IComparer<Persona>
        {
            public int Compare(Persona x, Persona y)
            {
                return x.Apellido.CompareTo(y.Apellido);
            }
        }
        public class ApellidoDESC : IComparer<Persona>
        {
            public int Compare(Persona x, Persona y)
            {
                return (x.Apellido.CompareTo(y.Apellido)) * -1;
            }
        }
        public class EdadASC : IComparer<Persona>
        {
            public int Compare(Persona x, Persona y)
            {
                int rdo = 0;
                if (x.Edad < y.Edad) { rdo = -1; };
                if (x.Edad > y.Edad) { rdo = 1; };
                return rdo; 
            }
        }
        public class EdadDESC : IComparer<Persona>
        {
            public int Compare(Persona x, Persona y)
            {
                int rdo = 0;
                if (x.Edad < y.Edad) { rdo = -1; };
                if (x.Edad > y.Edad) { rdo = 1; };
                return rdo * -1;
            }
        }
    }
      

   
}
