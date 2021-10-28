using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp14
{
    public class Rallador : ITocable
    {
        private string nombre;
        public string Nombre {

            get { return nombre; }

            set { nombre = value; }
        }

        public string Tocar()
        {
            return "la ventanita";
        }

        public override string ToString()
        {
            return nombre;
        }
    }
}