using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp14
{
    public class Guitarra : Instrumento, IAfinable
    {
        

        public string Nombre {

            get  { return nombre; }
            set { nombre = value; }
        }

        public string Afinar()
        {
            return "Estoy Afinando";
        }

        public string Tocar()
        {
            return "Mujer Amante";
        }

       
    }
}