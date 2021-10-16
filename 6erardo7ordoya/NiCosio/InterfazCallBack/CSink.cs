using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InterfazCallBack
{
    /// <summary>
    /// Handlers de los eventos definidos en la interfaz.
    /// In computing, a sink, event sink or data sink is a class or 
    /// function designed to receive incoming events from another object or 
    /// function. This is commonly implemented in C++ as callbacks. 
    /// Other object-oriented languages, such as Java and C#, have built-in 
    /// support for sinks by allowing events to be fired to delegate functions.
    /// </summary>
    class CSink : IEvento
    {
        /// <summary>
        /// Código a ejecutar cuando suceda el evento.
        /// </summary>
        /// <param name="pKilos"></param>
        public void EReservasBajas(int pKilos)
        {
            ForegroundColor = ConsoleColor.Yellow;
            WriteLine("--> Reservas bajas de alimentos");
            WriteLine($"--> Quedan { pKilos }");
        }
    }
}
