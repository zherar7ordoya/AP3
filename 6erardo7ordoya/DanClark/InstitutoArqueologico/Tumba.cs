using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp13
{
    public class Tumba : Descubrimiento
    {
        private int cantidadMomias;

        public int CantidadMomias
        {
            get { return cantidadMomias; }
            set { cantidadMomias = value; }
        }

        public override float CalcularExcavacion()
        {
            return(float)(this.presupuesto * 50) / 100;
        }

        public override float CalcularMateriales()
        {
            return (float)(this.presupuesto * 40) / 100;
        }

        public override float CalcularPermisos()
        {
            return (float)(this.presupuesto * 10) / 100;
        }
    }
}