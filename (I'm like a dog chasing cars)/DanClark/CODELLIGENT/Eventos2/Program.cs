using System;
using static System.Console;

/// <summary>
/// https://youtu.be/i0lnTVtwYT8
/// </summary>

namespace Eventos2
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat
            {
                Id = 1,
                Name = "Michifús",
                Health = 200
            };
            cat.OnHealthChanged += Cat_OnHealthChanged;
            cat.OnHealthChanged += Cat_IsDead;

            for (int i = 0; i < 10; i++)
            {
                cat.Health -= 20;
            }

            ReadKey();
        }

        private static void Cat_OnHealthChanged(object sender, int health)
        {
            var cat = (Cat)sender;
            WriteLine($"{cat.Name} has new health: {health}");
        }
        private static void Cat_IsDead(object sender, int health)
        {
            var cat = (Cat)sender;
            if (cat.Health <= 0) { WriteLine($"{cat.Name} is no longer alive... :("); }
        }

    }

    public class Cat
    {
        private int health;
        public int Id { get; set; }
        public string Name { get; set; }
        public int Health
        {
            get => this.health;
            set
            {
                this.health = value;
                this.OnHealthChanged?.Invoke(this, this.health);
            }
        }
        public event EventHandler<int> OnHealthChanged;
    }
}
