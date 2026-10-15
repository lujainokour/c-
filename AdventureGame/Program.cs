using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace AdventureGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("===== ADVENTURE GAME =====");

            Warrior warrior = new Warrior("Alex", 80);
            Wizard wizard = new Wizard("Luna", 70);

            List<GameCharacter> characters = new List<GameCharacter>();

            characters.Add(warrior);
            characters.Add(wizard);

            foreach (GameCharacter character in characters)
            {
                Console.WriteLine();
                Console.WriteLine(character.Name + " enters the game!");
                character.UseSpecialAbility();
                character.TakeDamage(10);
                character.ShowHealth();
            }

            Console.WriteLine();

            warrior.Heal();
            Console.WriteLine();

            warrior.Heal(15);
            Console.WriteLine();

            HealthPotion potion = new HealthPotion("Health Potion");
            potion.Collect();

            Console.WriteLine();

            potion.Use(wizard, "15");

            Console.WriteLine();

            potion.Use(wizard, "abc");

            Console.ReadKey();
        }
    }
}
