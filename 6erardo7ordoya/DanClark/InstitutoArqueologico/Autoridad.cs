using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp13
{
    public class Autoridad : Persona
    {
        private enumTipo tipo;

        public enumTipo Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }

    }
}