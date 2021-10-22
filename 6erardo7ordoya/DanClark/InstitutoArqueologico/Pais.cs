using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp13
{
    public class Pais
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        private List<Ciudad> ciudades;

        public List<Ciudad> Ciudades
        {
            get { return ciudades; }
            set { ciudades = value; }
        }

    }
}