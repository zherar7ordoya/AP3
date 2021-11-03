using System.Threading;
using static System.Console;


namespace Delegados2
{
    class Program
    {
        static void Main(string[] args)
        {
            OtraClase objeto = new OtraClase();
            var hilo = new Thread(() => objeto.MetodoCallback(MetodoImprimir));
            hilo.Start();
            WriteLine("EOF para Main");
            ReadKey();
        }
        public static void MetodoImprimir(int x) { WriteLine($"Imprimo un {x}"); }
    }
    class OtraClase
    {
        public delegate void Delegado(int numero);
        public void MetodoCallback(Delegado metodo)
        {
            Thread.Sleep(5000);
            metodo(10);
        }
    }
}
