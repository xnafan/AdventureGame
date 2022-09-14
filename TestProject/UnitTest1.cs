using AdventureGameClassLibrary;
using NUnit.Framework;
using System;

namespace TestProject
{
    public class Tests
    {
        [Test]
        public void TestPlayerCharacterCreation()
        {
            //Arrange
            string characterName = "Morgana le Fay";
            CharacterType type = CharacterType.Wizard;
            Weapon weapon = new Weapon("Wand of fireballs", 12);
            
            //Act
            PlayerCharacter character = new PlayerCharacter(characterName, type, weapon);

            //Assert
            Assert.AreEqual(characterName, character.Name, "The saved name was not correct");
            Assert.AreEqual(type, character.CharacterType, "The saved character type was not correct");
            Assert.AreEqual(weapon, character.Weapon, "The saved weapon was not correct");
            Assert.AreEqual(PlayerCharacter.DEFAULT_HP, character.HitPoints, "The default hitpoints was not used for construction");
        }


        [Test]
        public void TestMonsterCreation()
        {
            //Arrange
            string name = "Orr'grugh";
            MonsterType type = MonsterType.Orc;
            Weapon weapon = new Weapon("Wand of fireballs", 12);
            int hitpoints = 14;

            //Act
            Monster monster = new Monster(name, type, weapon, hitpoints);

            //Assert
            Assert.AreEqual(name, monster.Name, "The saved name was not correct");
            Assert.AreEqual(type, monster.MonsterType, "The saved character type was not correct");
            Assert.AreEqual(weapon, monster.Weapon, "The saved weapon was not correct");
            Assert.AreEqual(hitpoints, monster.HitPoints, "The saved number of hp was not correct");
        }


        [Test]
        public void TestIsAliveProperty()
        {
            //Arrange
            PlayerCharacter character = new PlayerCharacter("John the dying", CharacterType.Thief, null);

            //Act
            character.HitPoints = 20;
            //Assert
             Assert.IsTrue(character.IsAlive, "The returned IsAlive was wrong");

            //Act
            character.HitPoints = -20;
            //Assert
            Assert.IsTrue(!character.IsAlive, "The returned IsAlive was wrong");
        }


        [Test]
        public void TestLevelCalculationFromXP()
        {
            //Arrange
            PlayerCharacter character = new PlayerCharacter("John the leveler", CharacterType.Thief, null);

            //Act
            character.ExperiencePoints = 1;
            //Assert
            Assert.AreEqual(1, character.Level, "The returned Level was wrong");

            //Act
            character.ExperiencePoints = 999;
            //Assert
            Assert.AreEqual(1, character.Level, "The returned Level was wrong");

            //Act
            character.ExperiencePoints = 1000;
            //Assert
            Assert.AreEqual(2, character.Level, "The returned Level was wrong");

            //Act
            character.ExperiencePoints = 2999;
            //Assert
            Assert.AreEqual(3, character.Level, "The returned Level was wrong");

            //Act
            character.ExperiencePoints = 9999;
            //Assert
            Assert.AreEqual(10, character.Level, "The returned Level was wrong");
        }

        [Test]
        public void TestAttackFunctionWithNoWeapon()
        {
            //Arrange
            PlayerCharacter character = new PlayerCharacter("Tongo", CharacterType.Warrior, null);

            //Act
            int damage = character.Attack();

            //Assert
            Assert.AreEqual(1, damage, "The default damage was not used for an attack without a weapon");
        }

        [Test]
        public void TestAttackFunctionWithWeapon()
        {
            //Arrange
            Weapon weapon = new Weapon("Sword of the Gods", 12);
            int numberOfAttacks = 10000;
            double maxAcceptedDeviation = 1;

            //Act
            PlayerCharacter character = new PlayerCharacter("Taranga Leela", CharacterType.Warrior, weapon);

            double damage = 0;
            
            for (int i = 0; i < numberOfAttacks; i++)
            {
                damage += character.Attack();
            }

            double averageDamage = damage / numberOfAttacks;
            double expectedAverageDamage = character.Weapon.MaxDamage / 2 + .5f;
            double actualAbsoluteDeviation = Math.Abs(averageDamage - expectedAverageDamage);

            //Assert
            Assert.IsTrue(actualAbsoluteDeviation < maxAcceptedDeviation, "The average damage was off");
        }

    }
}