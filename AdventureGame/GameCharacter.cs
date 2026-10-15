using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System;

namespace AdventureGame
{
    abstract class GameCharacter
    {
        private string _name;
        private int _health;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        protected int Health
        {
            get { return _health; }
            set
            {
                if (value < 0)
                    _health = 0;
                else if (value > 100)
                    _health = 100;
                else
                    _health = value;
            }
        }

        public GameCharacter(string name, int health)
        {
            Name = name;
            Health = health;
        }

        public abstract void UseSpecialAbility();

        public virtual void TakeDamage(int amount)
        {
            if (amount < 0)
                amount = 0;

            Health -= amount;
            Console.WriteLine(Name + " takes " + amount + " damage.");
        }

        public void Heal()
        {
            Heal(10);
        }

        public void Heal(int amount)
        {
            if (amount < 0)
                amount = 0;

            Health += amount;
            Console.WriteLine(Name + " heals " + amount + " points.");
            ShowHealth();
        }

        public void ShowHealth()
        {
            Console.WriteLine(Name + "'s health: " + Health);
        }
    }
}

