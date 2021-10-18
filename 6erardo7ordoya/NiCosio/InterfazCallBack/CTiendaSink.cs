using System;
using static System.Console;

namespace InterfazCallBack
{
    class CTiendaSink : IEvento
    {
        public void EReservasBajas(int pKilos)
        {
            ForegroundColor = ConsoleColor.Green;
            WriteLine("\n---> Le enviaremos su pedido");
            WriteLine($"---> Serán { pKilos } kilos");
        }
    }
}
