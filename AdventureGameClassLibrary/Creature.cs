using System;

namespace AdventureGameClassLibrary
{
    public abstract class Creature  //this class is abstract, as it isn't meant for instantiation, only for inheritance
    {
        #region Properties
        internal static Random random = new Random();
        public string Name { get; set; }
        public int HitPoints { get; set; }
        public bool IsAlive { get { return HitPoints > 0; } }
        public Weapon Weapon { get; set; }
        public int Gold { get; set; } = random.Next(25);
        #endregion

        public Creature(string name, Weapon weapon = null, int hitpoints = 20)
        {
            Name = name;
            Weapon = weapon;
            HitPoints = hitpoints;
        }

        public int Attack()
        {
            if (Weapon == null) { return 1; }
            else { return Weapon.Attack(); }
        }

        public override string ToString()
        {
           return $"I'm a {GetType().Name}. My name is {Name}. I have {HitPoints} hp and {GetWeaponName()}.";
        }

        protected string GetWeaponName()
        {
            string weaponName = "no weapon";
            if (Weapon != null) { weaponName = $"a {Weapon.Name}"; }
            return weaponName;
        }
    }
}