using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp14
{
    public class Piano : Instrumento, ITocable
    {
        
        public string Nombre {

            get { return nombre; }
            set { nombre = value; }
        }
        public string Tocar()
        {
            return "Claro de luna";
        }

    
    }
}