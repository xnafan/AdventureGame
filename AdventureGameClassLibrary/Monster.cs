namespace AdventureGameClassLibrary
{
    public enum MonsterType { Goblin, Orc, Ogre, Troll }
    public class Monster : Creature
    {
        public MonsterType MonsterType { get; set; }

        public Monster(string name, MonsterType monsterType, Weapon weapon, int hitpoints) : base(name, weapon, hitpoints)
        {
            MonsterType = monsterType;
            Gold = random.Next(25)+1;
        }

        public override string ToString()
        {
            return $"I'm a {MonsterType}. My name is {Name}. I have {HitPoints} hp and {GetWeaponName()}.";
        }
    }
}