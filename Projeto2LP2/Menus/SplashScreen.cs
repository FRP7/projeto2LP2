using System;
using System.Threading;

namespace Projeto2LP2
{
    class SplashScreen
    {
        public void SplashScreenMenu(ConsoleKey key, bool retry)
        {
            Menu menu = new Menu();

            do
            {
                Console.Clear();

                menu.AlignText("");
                menu.AlignText("   _________   ____ __  _   ___      ___ ___  ____ ____  ____  ____    __ ");
                menu.AlignText("  / ___/    \\ /    |  |/ ] /  _]    |   |   |/    |    \\|    |/    |  /  ]");
                menu.AlignText(" (   \\_|  _  |  o  |  ' / /  [_     | _   _ |  o  |  _  ||  ||  o  | /  / ");
                menu.AlignText("  \\__  |  |  |     |    \\|    _]    |  \\_/  |     |  |  ||  ||     |/  /  ");
                menu.AlignText("  /  \\ |  |  |  _  |     |   [_     |   |   |  _  |  |  ||  ||  _  /   \\_ ");
                menu.AlignText("   \\    |  |  |  |  |  .  |     |    |   |   |  |  |  |  ||  ||  |  \\     | ");
                menu.AlignText("    \\___|__|__|__|__|__|\\_|_____|    |___|___|__|__|__|__|____|__|__|\\____| ");
                menu.AlignText("");
                menu.AlignText("");

                while (!Console.KeyAvailable)
                {
                    menu.AlignText("Press ENTER to continue.");
                    Thread.Sleep(500);
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    menu.ClearCurrentConsoleLine();
                    menu.AlignText("Press       to continue.");
                    Thread.Sleep(500);
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    menu.ClearCurrentConsoleLine();
                }

                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    retry = false;
                }
                else
                {
                    retry = true;
                }
            } while (retry == true);
        }
    }
}
