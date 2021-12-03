using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace PatronEstrategia
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato = string.Empty, opcion = string.Empty;
            double x = 0, y = 0, r = 0;

            IOperacion miOperacion = new CSuma();

            while(true)
            {
                WriteLine("1) Suma \t 2) Resta \t 3) Multplicación \t 4) División \t 5) Salir");
                opcion = ReadLine();
                if (opcion.Equals("5")) { break; }

                WriteLine("Valor de A:");
                dato = ReadLine();
                x = Convert.ToDouble(dato);

                WriteLine("Valor de B:");
                dato = ReadLine();
                y = Convert.ToDouble(dato);

                switch (opcion)
                {
                    case "1":
                        miOperacion = new CSuma();
                        break;
                    case "2":
                        miOperacion = new CResta();
                        break;
                    case "3":
                        miOperacion = new CMultiplicacion();
                        break;
                    case "4":
                        miOperacion = new CDivision();
                        break;
                }
                r = miOperacion.Operacion(x, y);
                WriteLine($"Resultado: {r}");
            }
        }
    }
}
