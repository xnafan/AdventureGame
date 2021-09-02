using System;

namespace MonoGameAdventureGameForDesktop
{
    public static class Program
    {
        [STAThread]
        static void Main()
        {
            using (var game = new MonoAdventureGame())
                game.Run();
        }
    }
}
