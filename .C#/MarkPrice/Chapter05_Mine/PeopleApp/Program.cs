using System;
using Packt.Shared;
using static System.Console;

namespace PeopleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Out.NewLine = "\r\n\r\n";
            Console.ForegroundColor = ConsoleColor.Green;

            var bob = new Person
            {
                Name = "Bob Smith",
                DateOfBirth = new DateTime(1965, 12, 22),
                FavoriteAncientWonder = WondersOfTheAncientWorld.StatueOfZeusAtOlympia
            };

            WriteLine
            (
                format: "\n{0} was born on {1:dddd, d MMMM yyyy}",
                arg0: bob.Name,
                arg1: bob.DateOfBirth
            );

            var alice = new Person
            {
                Name = "Alice Jones",
                DateOfBirth = new DateTime(1998, 3, 7)
            };

            WriteLine
            (
                format: "{0} was born on {1:dd MMM yy}",
                arg0: alice.Name,
                arg1: alice.DateOfBirth
            );

            WriteLine
            (
                format: "{0}'s favorite wonder is {1}. Its integer is {2}.",
                arg0: bob.Name,
                arg1: bob.FavoriteAncientWonder,
                arg2: (int)bob.FavoriteAncientWonder
            );

            Console.ResetColor();
        }
    }
}
