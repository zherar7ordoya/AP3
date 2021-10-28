using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp13
{
    public class Ciudad
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        private Pais pais;

        public Pais Pais
        {
            get { return pais; }
            set { pais = value; }
        }


    }
}