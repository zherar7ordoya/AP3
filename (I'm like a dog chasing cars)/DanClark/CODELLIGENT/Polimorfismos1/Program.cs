using static System.Console;

/// <summary>
/// https://dev.to/mundim/refactoring-replacing-conditional-with-polymorphism-2ob6
/// </summary>

namespace Polimorfismos1
{
    class Program
    {
        static void Main(string[] args)
        {
            Bird africanBird = new AfricanBird();
            Bird americanBird = new AmericanBird();
            Bird europeanBird = new EuropeanBird();

            WriteLine($"African Speed:  \t{africanBird.GetSpeed()}");
            WriteLine($"American Speed: \t{americanBird.GetSpeed()}");
            WriteLine($"European Speed: \t{europeanBird.GetSpeed()}");

            ReadKey();
        }
    }
    public abstract class Bird
    {
        public abstract double GetSpeed();
    }
    public class AfricanBird : Bird
    {
        public override double GetSpeed() { return 1; }
    }

    public class AmericanBird : Bird
    {
        public override double GetSpeed() { return 0.7; }
    }

    public class EuropeanBird : Bird
    {
        public override double GetSpeed() { return 1.05; }
    }
}
