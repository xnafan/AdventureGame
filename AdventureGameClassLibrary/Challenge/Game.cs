using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AdventureGameClassLibrary.Challenge
{
    public class Game
    {
        
        #region Properties and constants
        public PlayerCharacter Character { get; set; }
        public Monster Monster { get; set; }
        public bool IsGameOver { get { return !Character.IsAlive; } }
        public string LatestStatus { get { return stringBuilder.ToString(); } }
        private StringBuilder stringBuilder = new StringBuilder();

        private static Random random = new Random();
        private static string[] monsterNames = { "Monnaur", "Drilgrannor", "Dag'thonel", "Erranath", "Ur'goron", "Gorzan", "Braz'geriun", "Saz'gas", "Aglomuth", "Agmoxaz", "Drollmereth", "Izonnen", "Braz'geriun", "Saz'gas", "Aglomuth", "Agmoxaz", "Drollmereth", "Izonnen", "Kerthramen", "Trozgemin", "Vur'akag", "Brolvonar", "Urromath", "Ornaxeth" };
        public static readonly Dictionary<MonsterType, int> DefaultHPforMonsters = new Dictionary<MonsterType, int> { { MonsterType.Goblin, 6 }, { MonsterType.Orc, 8 }, { MonsterType.Ogre, 10 }, { MonsterType.Troll, 12 } };
        public static readonly List<Weapon> PossibleWeapons = new List<Weapon>() { new Weapon("Dagger", 3), new Weapon("Wooden club", 4), new Weapon("Short sword", 6), new Weapon("Longsword", 8) };
        public const int XP_PER_MONSTER = 100;
        #endregion

        public Game(PlayerCharacter character, Monster monster = null)
        {
            Character = character;
            Monster = monster;
        }

        public static Monster GetRandomMonster()
        {
            MonsterType monstertype = GetRandomMonsterType();
            int hp = DefaultHPforMonsters[monstertype];
            return new Monster(GetRandomMonsterName(), monstertype, GetRandomWeapon(), hp);
        }

        public static string GetRandomMonsterName()
        {
            return monsterNames[random.Next(monsterNames.Length)];
        }

        public void PlayRound()
        {
            IfGameIsOverThrowException();
            stringBuilder.Clear();
            stringBuilder.AppendLine();
            EnsureMonsterExistsAndLogIt();

            int damageToMonster = 0, damageToPlayer = 0;
            int goldGotten = 0, xpGotten = 0;

            damageToMonster = Character.Attack();
            Monster.HitPoints -= damageToMonster;
            if (Monster.IsAlive)
            {
                damageToPlayer = Monster.Attack();
                Character.HitPoints -= damageToPlayer;
            }
            else
            {
                Character.Gold += goldGotten = Monster.Gold;
                Character.ExperiencePoints += xpGotten = XP_PER_MONSTER;
            }

            LogRoundStatus(damageToMonster, damageToPlayer, goldGotten, xpGotten);
        }

        private void EnsureMonsterExistsAndLogIt()
        {
            if (Monster == null || !Monster.IsAlive)
            {
                Monster = GetRandomMonster();
                stringBuilder.AppendLine($"The following monster steps forward and introduces itself:");
                stringBuilder.AppendLine($"'{Monster}'");
                stringBuilder.AppendLine();
            }
        }

        private void LogRoundStatus(int damageToMonster, int damageToPlayer, int goldGotten, int xpGotten)
        {
            stringBuilder.AppendLine($"{Character.Name} hits the {Monster.MonsterType} for {damageToMonster} hp.");
            stringBuilder.AppendLine($"The {Monster.MonsterType} has {Monster.HitPoints} hp left.");

            if (!Monster.IsAlive)
            {
                stringBuilder.AppendLine($"The {Monster.MonsterType} died.");
                stringBuilder.AppendLine($"{Character.Name} earned {goldGotten} gold and {xpGotten} xp.");
                stringBuilder.AppendLine($"{Character.Name} now has {Character.Gold} gold and {Character.ExperiencePoints} xp.");
            }
            else
            {
                stringBuilder.AppendLine($"The {Monster.MonsterType} hits {Character.Name} for {damageToPlayer} hp.");
                if (!Character.IsAlive) { stringBuilder.AppendLine($"The {Character.CharacterType}, {Character.Name}, is dead!"); }
                else
                {
                    stringBuilder.AppendLine($"{Character.Name} has {Character.HitPoints} hp left.");
                }
            }
        }

        private void IfGameIsOverThrowException()
        {
            if (IsGameOver) { throw new Exception("Error - game is over!"); }
        }

        public static MonsterType GetRandomMonsterType()
        {
            List<MonsterType> allMonsterTypes = Enum.GetValues(typeof(MonsterType)).Cast<MonsterType>().ToList();
            return allMonsterTypes[random.Next(allMonsterTypes.Count)];
        }
        public static Weapon GetRandomWeapon()
        {
            return PossibleWeapons[random.Next(PossibleWeapons.Count)];
        }
    }
}