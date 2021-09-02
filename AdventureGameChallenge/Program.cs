using AdventureGameClassLibrary;
using AdventureGameClassLibrary.Challenge;
using System;

namespace AdventureGameChallenge
{
    class Program
    {
        private static Game game;
        static void Main(string[] args)
        {
            SetupNewGame();
            WriteIntroduction();
            RunGameLoop();
            WriteFinalScore();
        }

        
        private static void SetupNewGame()
        {
            PlayerCharacter character = new PlayerCharacter("Morgana le Fay", CharacterType.Wizard, new Weapon("Wand of fireballs", 12)) { Gold = 0 };
            game = new Game(character);
        }

        private static void WriteIntroduction()
        {
            Console.WriteLine("WELCOME TO THE ADVENTURE GAME!");
            Console.WriteLine("See if you can beat the highscore");
            Console.WriteLine();
            Console.WriteLine($"Your character introduces itself: '{game.Character}'");
        }

        private static void RunGameLoop()
        {
            while (!game.IsGameOver)
            {
                Console.WriteLine("Press any key to play a round");
                Console.ReadKey();
                game.PlayRound();
                Console.WriteLine(game.LatestStatus);
            }
        }

        private static void WriteFinalScore()
        {
            Console.WriteLine($"Your final score was: {game.Character.Gold} gold and {game.Character.ExperiencePoints} xp");
        }
    }
}