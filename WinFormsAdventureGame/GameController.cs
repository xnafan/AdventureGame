using AdventureGameClassLibrary;
using AdventureGameClassLibrary.Challenge;
using System;
using System.Collections.Generic;

namespace WinFormsAdventureGame
{
    internal class GameController
    {
        Game game;

        public PlayerCharacter Character
        {
            get { return game?.Character; }
        }

        public Monster Monster
        {
            get { return game?.Monster; }
        }


        public List<Weapon> Weapons { get; set; } = new List<Weapon>();

        public GameController()
        {
            Weapons.Add(new Weapon("Dagger", 4));
            Weapons.Add(new Weapon("Short sword", 6));
            Weapons.Add(new Weapon("Longsword", 8));
        }

        internal void StartNewGame(string characterName, CharacterType type, Weapon weapon)
        {
            game = new Game(new PlayerCharacter(characterName, type, weapon), Game.GetRandomMonster());
        }

        internal void PlayRound()
        {
            game.PlayRound();
        }


        public string GetLatestStatus()
        {
            return game?.LatestStatus;
        }

        public bool IsGameRunning { get { if (game == null) { return false; } return !game.IsGameOver; } }
    }
}
