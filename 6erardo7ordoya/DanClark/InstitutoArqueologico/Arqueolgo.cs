using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp13
{
    public class Arqueologo : Persona
    {
        private string apellido;

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        private DateTime fechaNacimiento;

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }


        private List<Descubrimiento> descubrimientos=new List<Descubrimiento>();

        public List<Descubrimiento> Descubrimientos
        {
            get { return descubrimientos; }
         
        }

    }
}