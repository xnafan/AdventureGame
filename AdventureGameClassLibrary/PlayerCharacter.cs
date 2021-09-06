namespace AdventureGameClassLibrary
{
    public enum CharacterType { Warrior, Wizard, Thief }
    public class PlayerCharacter : Creature
    {
        public const int DEFAULT_HP = 20;
        public int ExperiencePoints { get; set; }
        public int Level { get { return ExperiencePoints / 1000 + 1; } }
        public CharacterType CharacterType { get; set; }

        public PlayerCharacter(string name, CharacterType characterType, Weapon weapon, int hitpoints = DEFAULT_HP) : base(name, weapon, hitpoints)
        {
            Name = name;
            CharacterType = characterType;
        }

        public override string ToString()
        {
            return $"I'm a level {Level} {CharacterType}. My name is {Name}. I have {HitPoints} hp, {Gold} gold, {ExperiencePoints} xp and {GetWeaponName()}.";
        }
    }
}