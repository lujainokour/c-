
using System;

namespace AdventureGame
{
    class Warrior : GameCharacter
    {
        public Warrior(string name, int health)
            : base(name, health)
        {
        }

        public override void UseSpecialAbility()
        {
            Console.WriteLine("The Warrior attacks with a sword!");
        }

        public override void TakeDamage(int amount)
        {
            int actualDamage = Math.Max(0, amount - 2);
            base.TakeDamage(actualDamage);
        }
    }
}
