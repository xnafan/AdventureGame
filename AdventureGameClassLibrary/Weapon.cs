using System;
using System.Text;

namespace AdventureGameClassLibrary
{
    public class Weapon
    {
        Random random = new Random();
        public string Name { get; set; }
        public int MaxDamage { get; set; }

        public Weapon(string name, int maxDamage)
        {
            Name = name;
            MaxDamage = maxDamage;
        }


        public int Attack()
        {
            return random.Next(MaxDamage)+1;
        }

        public override string ToString()
        {
            return $"{Name} (1-{MaxDamage} damage)";
        }

    }
}