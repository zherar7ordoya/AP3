namespace PARCIAL_1
{
    interface IEmpleado
    {
        void Alta(CEmpleado empleado, CManejador empleados);
        void Baja(CEmpleado empleado, CManejador empleados);
        void Modificacion(CEmpleado empleado, CManejador empleados);
    }
}
