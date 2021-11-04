using static System.Console;

namespace Delegados1
{
    //Desarrollo 1
    //public delegate void Delegado();

    //Desarrollo 2
    //public delegate void Delegado(int x);

    //Desarrollo 3
    //public delegate int Delegado(int numero);

    //Desarrollo 4
    public delegate void Delegado(int numero);
    class Program
    {
        static void Main(string[] args)
        {
            //Desarrollo 1
            //Delegado delegado1 = Método;

            //Desarrollo 2
            //Delegado delegado2 = Método;

            // Desarrollo 3
            //Delegado cuadrado = delegate (int n) { return n * n; };
            //WriteLine(cuadrado(5));

            //Desarrollo 4
            Delegado delegado4a, delegado4b, delegado4c, delegado4d;
            delegado4a = Metodo1;
            delegado4b = Metodo2;
            delegado4c = delegado4a + delegado4b;
            delegado4d = Metodo1;
            delegado4d += Metodo2;

            /*==================================================================*/
            //Desarrrollo 1
            //delegado1();

            //Desarrollo 2
            //delegado2(100);

            //Desarrollo 4
            delegado4c(5);
            delegado4c -= delegado4b;
            delegado4c(7);
            delegado4d(9);

            ReadKey();
        }
        //Desarrollo 1
        //public static void Método() { WriteLine("Método"); }

        //Desarrollo 2
        //public static void Método(int numero) { WriteLine($"Número {numero}"); }

        //Desarrollo 4
        public static void Metodo1(int i) { WriteLine($"\nMétodo 1: {i}"); }
        public static void Metodo2(int i) { WriteLine($"Método 2: {i}"); }
    }
}
