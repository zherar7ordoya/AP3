using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador_1
{
    interface IConcesionario
    {
        List<Persona> RetornarListaPersonas();
        void AgregarPersona(Persona pPersona);
        void BorrarPersona(Persona pPersona);
        void ModificarPersona(Persona pPersona);
    }
}
