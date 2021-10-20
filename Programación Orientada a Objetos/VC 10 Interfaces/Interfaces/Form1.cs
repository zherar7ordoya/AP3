using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces
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

            p1.Orden += Orden_Ejecucion; p2.Orden += Orden_Ejecucion; p3.Orden += Orden_Ejecucion;


            l = new List<Persona>() { p1, p2, p3 };

            listBox1.Items.AddRange(l.ToArray());
            //var a = l.ToArray(); Array.Sort(a);
            //listBox2.Items.AddRange(a);

            l.Sort(); listBox2.Items.AddRange(l.ToArray());

        }

        private void Orden_Ejecucion(object sender, OrdenEventArgs e)
        {
            listBox3.Items.Add($"{e.ValorDevuelto.ToString()}   --   {e.EnEjecucion.ToString()}   --   {e.Obj.ToString()}");
        }

        public class Persona : IComparable
        {
            public event EventHandler<OrdenEventArgs> Orden;
            public Persona(string pNombre, string pApellido, int pEdad) { Nombre = pNombre; Apellido = pApellido; Edad = pEdad; }
            public string Nombre { get; set; }
            public string Apellido { get; set; }
            public int Edad { get; set; }

            public int CompareTo(object obj)
            {
                int rdo = this.Nombre.CompareTo((obj as Persona).Nombre);
                Orden?.Invoke(this, new OrdenEventArgs(this, obj as Persona,rdo));
                return rdo;
            }

            public override string ToString()
            {
                return $"{Nombre} {Apellido} {Edad}";
            }
        }

        public class OrdenEventArgs : EventArgs
        {
            public OrdenEventArgs(Persona pEnEjecucion, Persona pObj, int pValorDevuelto)
            { EnEjecucion = pEnEjecucion; Obj = pObj;ValorDevuelto = pValorDevuelto; }
            public Persona EnEjecucion { get; set; }
            public Persona Obj { get; set; }
            public int ValorDevuelto { get; set; }
        }

    }     
}
