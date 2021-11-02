using static System.Console;

namespace Delegados
{
    public delegate void Delegado();
    class Program
    {
        static void Main(string[] args)
        {
            Delegado delegado = Método;
            delegado();
            ReadKey();
        }
        public static void Método() { Write("Soy el método."); }
    }
}
