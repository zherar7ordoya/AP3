namespace DelegadosPredicadosLambdas
{
    partial class Program
    {
        static bool DamePares(int num)
        {
            if (num % 2 == 0) return true;
            else return false;
        }
        static bool ExisteJuan(Persona persona)
        {
            if (persona.Nombre == "Juan") return true;
            else return false;
        }
        static bool ExistenMayores(Persona persona)
        {
            if (persona.Edad > 17) return true;
            else return false;
        }
        public static int Cuadrado(int num)
        {
            return num * num;
        }
        public static int Suma(int num1,int num2)
        {
            return num1 + num2;
        }
    }
}
