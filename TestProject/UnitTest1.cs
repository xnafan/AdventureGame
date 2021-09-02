using AdventureGameClassLibrary;
using NUnit.Framework;

namespace TestProject
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestPlayerCharacterCreation()
        {
            PlayerCharacter character = new PlayerCharacter("Morgana le Fay", CharacterType.Wizard, new Weapon("Wand of fireballs", 12));
            Monster monster = new Monster("Orr'grugh", MonsterType.Orc, new Weapon("Club", 4),20);

            

        }
    }
}