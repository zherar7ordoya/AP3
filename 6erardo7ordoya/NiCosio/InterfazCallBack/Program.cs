using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace InterfazCallBack
{
    class Program
    {
        static void Main(string[] args)
        {
            CRefrigerador refrigerador = new CRefrigerador(50, -20);
            Random aleatorio = new Random();
            CSink sink1 = new CSink();

            /* Ya tenemos el refrigerador y ya tenemos el sink. Lo único que
             * nos falta es llevar a cabo esa unión entre ambos de tal forma
             * que se puedan comunicar entre ellos. Esto se hará mediante el
             * método AgregarSink().
             * Al pasar el objeto "sink1", este ya queda en la lista de los
             * sinks que tiene la clase CRefrigerador y cuando suceda el even-
             * to, su método (el de la lista) va a ser invocado.
             */
            refrigerador.AgregarSink(sink1);

            while (refrigerador.Kilos > 0)
            {
                refrigerador.Trabajar(aleatorio.Next(1, 5));
            }
            ReadKey();
        }
    }
}
