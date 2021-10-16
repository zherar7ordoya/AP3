using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfazCallBack
{
    /// <summary>
    /// Eventos que tendrá refrigerador.
    /// </summary>
    interface IEvento
    {
        void EReservasBajas(int pKilos);
    }
}
