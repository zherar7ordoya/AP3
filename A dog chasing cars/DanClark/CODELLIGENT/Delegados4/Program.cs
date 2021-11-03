using System;
using static System.Console;
namespace Delegados4
{
    class Program
    {
        static void Main(string[] args)
        {
            Action delegado1 = Metodo1;
            delegado1();

            Action<int, int> delegado2 = Metodo2;
            delegado2(3, 7);

            Func<int> delegado3 = Metodo3;
            WriteLine("El método 3 devuelve " + delegado3());

            Func<int, int, string> delegado4 = Metodo4;
            WriteLine(delegado4(21, 7));

            ReadKey();
        }
        public static void Metodo1() { WriteLine("Método 1"); }
        public static void Metodo2(int a, int b) { WriteLine($"Envió {a} y {b} al método 2"); }
        public static int Metodo3() { return 0; }
        public static string Metodo4(int a, int b) { return $"Envió {a} y {b} al método 4"; }
    }
}
