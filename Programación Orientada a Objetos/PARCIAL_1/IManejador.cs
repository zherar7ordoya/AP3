using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PARCIAL_1
{
    interface IManejador
    {
        void AltaAdelanto(CAdelanto adelanto, CManejador adelantos);
        void BajaAdelanto(CAdelanto adelanto, CManejador adelantos);
        void ModificacionAdelanto(CAdelanto adelanto, CManejador adelantos);
        void AsignarAdelanto(CAdelanto adelanto, CManejador adelantos, CEmpleado empleado, CManejador empleados);
        void CancelarAdelantos(CManejador empleados);
        void AltaEmpleado(CEmpleado empleado, CManejador empleados);
        void BajaEmpleado(CEmpleado empleado, CManejador empleados);
        void ModificacionEmpleado(CEmpleado empleado, CManejador empleados);
    }
}
