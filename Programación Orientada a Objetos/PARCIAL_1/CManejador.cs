using System.Collections.Generic;

namespace PARCIAL_1
{
    class CManejador : IManejador
    {
        private List<CAdelanto> adelantos;
        private List<CEmpleado> empleados;

        internal List<CAdelanto> Adelantos { get => adelantos; set => adelantos = value; }
        internal List<CEmpleado> Empleados { get => empleados; set => empleados = value; }

        public void AltaAdelanto(CAdelanto adelanto, CManejador adelantos)
        {
            throw new System.NotImplementedException();
        }

        public void AltaEmpleado(CEmpleado empleado, CManejador empleados)
        {
            throw new System.NotImplementedException();
        }

        public void AsignarAdelanto(CAdelanto adelanto, CManejador adelantos, CEmpleado empleado, CManejador empleados)
        {
            throw new System.NotImplementedException();
        }

        public void BajaAdelanto(CAdelanto adelanto, CManejador adelantos)
        {
            throw new System.NotImplementedException();
        }

        public void BajaEmpleado(CEmpleado empleado, CManejador empleados)
        {
            throw new System.NotImplementedException();
        }

        public void CancelarAdelantos(CManejador empleados)
        {
            throw new System.NotImplementedException();
        }

        public void ModificacionAdelanto(CAdelanto adelanto, CManejador adelantos)
        {
            throw new System.NotImplementedException();
        }

        public void ModificacionEmpleado(CEmpleado empleado, CManejador empleados)
        {
            throw new System.NotImplementedException();
        }
    }
}
