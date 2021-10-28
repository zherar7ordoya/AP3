using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp13
{
    public class MonumentoTributoAutoridad : Monumento
    {

        private Autoridad autoridad;
        public Autoridad Autoridad
        {
            get { return autoridad; }
            set
            {
                autoridad = value;
            }
        }
    }
}