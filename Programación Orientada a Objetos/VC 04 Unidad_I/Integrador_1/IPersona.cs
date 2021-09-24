using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Integrador_1
{
    interface IPersona
    {
        void AgregarAuto(Auto pAuto);
        List<Auto> RetornarListaAutos();
        void BorrarAuto(Auto pAuto);
    }
}
