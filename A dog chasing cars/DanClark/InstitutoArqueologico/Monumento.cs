using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp13
{
    public class Monumento : Descubrimiento
    {
        private bool jeroglificos;

        public bool Jeroglificos
        {
            get { return jeroglificos; }
            set { jeroglificos = value; }
        }

        public override float CalcularExcavacion()
        {

            return(float)(this.presupuesto * 15) / 100;
        }

        public override float CalcularMateriales()
        {
            return (float)(this.presupuesto * 65) / 100;
        }

        public override float CalcularPermisos()
        {
            return (float)(this.presupuesto * 20) / 100;
        }
    }
}