using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe do menu principal.
    /// </summary>
    class Menu
    {
        /// <summary>
        /// Método onde é exposto o menu principal.
        /// </summary>
        public void MainMenu()
        {
            bool retry = false;
            ConsoleKey key = ConsoleKey.Backspace;

            SplashScreen(key, retry);

            do
            {
                Console.Clear();

                AlignText("");
                AlignText("   _________   ____ __  _   ___      ___ ___  ____ ____  ____  ____    __ ");
                AlignText("  / ___/    \\ /    |  |/ ] /  _]    |   |   |/    |    \\|    |/    |  /  ]");
                AlignText(" (   \\_|  _  |  o  |  ' / /  [_     | _   _ |  o  |  _  ||  ||  o  | /  / ");
                AlignText("  \\__  |  |  |     |    \\|    _]    |  \\_/  |     |  |  ||  ||     |/  /  ");
                AlignText("  /  \\ |  |  |  _  |     |   [_     |   |   |  _  |  |  ||  ||  _  /   \\_ ");
                AlignText("   \\    |  |  |  |  |  .  |     |    |   |   |  |  |  |  ||  ||  |  \\     | ");
                AlignText("    \\___|__|__|__|__|__|\\_|_____|    |___|___|__|__|__|__|____|__|__|\\____| ");
                AlignText("");
                AlignText("");
                AlignText("(P)LAY");
                AlignText("");
                AlignText("(I)NSTRUTIONS");
                AlignText("");
                AlignText("(H)IGHSCORE");
                AlignText("");
                AlignText("(C)REDITS");
                AlignText("");
                AlignText("(E)XIT");

                key = Console.ReadKey(true).Key;

                switch (key)
                {
                    case ConsoleKey.P:
                        Console.Clear();
                        DeleteLater();
                        break;
                    case ConsoleKey.I:
                        Console.Clear();
                        Instructions(key, retry);
                        break;
                    case ConsoleKey.H:
                        Console.Clear();
                        HighScore(key, retry);
                        break;
                    case ConsoleKey.C:
                        Console.Clear();
                        Credits(key, retry);
                        break;
                    case ConsoleKey.E:
                        Console.Clear();
                        Exit();
                        break;
                    default:
                        retry = true;
                        break;
                }
            } while (retry == true);
        }

        private void SplashScreen(ConsoleKey key, bool retry)
        {
            do
            {
                Console.Clear();

                AlignText("");
                AlignText("   _________   ____ __  _   ___      ___ ___  ____ ____  ____  ____    __ ");
                AlignText("  / ___/    \\ /    |  |/ ] /  _]    |   |   |/    |    \\|    |/    |  /  ]");
                AlignText(" (   \\_|  _  |  o  |  ' / /  [_     | _   _ |  o  |  _  ||  ||  o  | /  / ");
                AlignText("  \\__  |  |  |     |    \\|    _]    |  \\_/  |     |  |  ||  ||     |/  /  ");
                AlignText("  /  \\ |  |  |  _  |     |   [_     |   |   |  _  |  |  ||  ||  _  /   \\_ ");
                AlignText("   \\    |  |  |  |  |  .  |     |    |   |   |  |  |  |  ||  ||  |  \\     | ");
                AlignText("    \\___|__|__|__|__|__|\\_|_____|    |___|___|__|__|__|__|____|__|__|\\____| ");
                AlignText("");
                AlignText("");
                AlignText("Press 'ENTER' to continue.");

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

        private void Instructions(ConsoleKey key, bool retry)
        {
            do
            {
                Console.Clear();

                AlignText("");
                AlignText("Instructions!");
                AlignText("");
                AlignText("Press 'ESQ' to go to menu.");

                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    MainMenu();
                    retry = false;
                }
                else
                {
                    retry = true;
                }
            } while (retry == true);
        }
        private void HighScore(ConsoleKey key, bool retry)
        {
            do
            {
                Console.Clear();

                AlignText("");
                AlignText("HighScore!");
                AlignText("");
                AlignText("Press 'ESQ' to go to menu.");

                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    MainMenu();
                    retry = false;
                }
                else
                {
                    retry = true;
                }
            } while (retry == true);
        }

        private void Credits(ConsoleKey key, bool retry)
        {
            do
            {
                Console.Clear();

                AlignText("");
                AlignText("Credits!");
                AlignText("");
                AlignText("Press 'ESQ' to go to menu.");

                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    MainMenu();
                    retry = false;
                }
                else
                {
                    Console.Clear();
                    retry = true;
                }
            } while (retry == true);
        }

        private void Exit()
        {
            Environment.Exit(0);
        }

        private void AlignText(string text)
        {
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);
            Console.WriteLine(text);
        }

        private void DeleteLater()
        {
            GameLoop game = new GameLoop();
            game.Game();
        }

    }
}
