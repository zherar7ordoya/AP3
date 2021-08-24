using System;

namespace Video02
{
    class Program
    {
        static void Main(string[] args)
        {
            CCalculadora calcu1 = new CCalculadora
            {
                a = 5,
                b = 3
            };
            CCalculadora calcu2 = new CCalculadora
            {
                a = 18,
                b = 53
            };
            calcu1.Suma();
            calcu2.Suma();
        }
    }
}
