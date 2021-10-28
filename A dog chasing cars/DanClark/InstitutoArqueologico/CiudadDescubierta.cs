using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace WindowsFormsApp13
{
    public class CiudadDescubierta : Descubrimiento
    {

        private string nombreCiudad;

        public string NombreCiudad
        {
            get { return nombreCiudad; }
            set { nombreCiudad = value; }
        }



        private int cantidadHabitantes;

        public int CantidadHabitantes
        {
            get { return cantidadHabitantes; }
            set { cantidadHabitantes = value; }
        }

        private DateTime desde;

        public DateTime Desde
        {
            get { return desde; }
            set { desde = value; }
        }

        private DateTime hasta;

        public DateTime Hasta
        {
            get { return hasta; }
            set { hasta = value; }
        }

        public override float CalcularExcavacion()
        {
            return (float)(this.presupuesto * 45) / 100;
        }

        public override float CalcularMateriales()
        {
            return(float)(this.presupuesto * 35) / 100;
        }

        public override float CalcularPermisos()
        {
            return (float)(this.presupuesto * 20) / 100;
        }
    }
}