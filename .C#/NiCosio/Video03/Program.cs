using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video03
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            double vala = 0.0;
            double valb = 0.0;

            string valor = "";

            IOperacion operacion = new CSuma();

            while (opcion != 5)
            {
                Console.WriteLine("1 (suma)  ||  "              +
                                  "2 (resta)  ||  "             +
                                  "3 (multiplicación)  ||  "    +
                                  "4 (división)  ||  "          +
                                  "5 (salir)");
                
                Console.WriteLine("Opción:");
                valor = Console.ReadLine();
                opcion = Convert.ToInt32(valor);

                Console.WriteLine("Valor de a:");
                valor = Console.ReadLine();
                vala = Convert.ToDouble(valor);

                Console.WriteLine("Valor de b:");
                valor = Console.ReadLine();
                valb = Convert.ToDouble(valor);

                if (opcion == 1)
                {
                    operacion = new CSuma();
                }
                if (opcion == 2)
                {
                    operacion = new CResta();
                }
                if (opcion == 3)
                {
                    operacion = new CMultiplicacion();
                }
                if (opcion == 4)
                {
                    operacion = new CDivision();
                }

                operacion.calcular(vala, valb);
                operacion.mostrar();
            }
        }
    }
}
