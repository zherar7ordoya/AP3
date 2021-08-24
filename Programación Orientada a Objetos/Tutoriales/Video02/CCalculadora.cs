using System;
using System.Collections.Generic;
using System.Text;

namespace Video02
{
    class CCalculadora
    {
        // Atributos
        public double a;
        public double b;
        private double r;

        // Métodos
        public void Suma()
        {
            r = a + b;
            Muestra();
        }
        private void Muestra()
        {
            Console.Title = "Gerardo Tordoya";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(
                "a={0}, \tb={1}, \tr={2}",
                a, b, r
            );
        }
    }
}
