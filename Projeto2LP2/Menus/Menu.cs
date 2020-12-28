using System;
using System.Threading;

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
        public void MainMenu(bool introPlay, bool splashPlay)
        {
            Intro intro = new Intro();
            SplashScreen splash = new SplashScreen();
            GameLoop game = new GameLoop();

            bool retry = false;
            ConsoleKey key = ConsoleKey.Backspace;

            if (introPlay) intro.IntroMenu();

            if (splashPlay) splash.SplashScreenMenu(key, retry);

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
                        game.Game();
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

        private void Instructions(ConsoleKey key, bool retry)
        {
            do
            {
                Console.Clear();

                AlignText("");
                AlignText("You are the snake (@).");
                AlignText("Use the Arrow keys to move the snake around.");
                AlignText("Eat has many apples ($) has you can.");
                AlignText("Avoid hitting the wall has these will kill you.");
                AlignText("Also avoid hitting yourself, so you dont eat yourself and die dummy.");
                AlignText("Good Luck!");
                AlignText("");
                while (!Console.KeyAvailable)
                {
                    AlignText("Press ESQ to retreat to the menu.");
                    Thread.Sleep(500);
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();
                    AlignText("Press     to retreat to the menu.");
                    Thread.Sleep(500);
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();
                }

                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    MainMenu(false, false);
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
                AlignText("Not yet implemented! :(");
                AlignText("");
                while (!Console.KeyAvailable)
                {
                    AlignText("Press ESQ to retreat to the menu.");
                    Thread.Sleep(500);
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();
                    AlignText("Press     to retreat to the menu.");
                    Thread.Sleep(500);
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();
                }

                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    MainMenu(false, false);
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
                AlignText("Made with love by:");
                AlignText("");
                AlignText("");
                AlignText("André Cosme;");
                AlignText("");
                AlignText("Francisco Pires;");
                AlignText("");
                AlignText("Nuno Figueiredo.");
                AlignText("");
                AlignText("");
                while (!Console.KeyAvailable)
                {
                    AlignText("Press ESQ to retreat to the menu.");
                    Thread.Sleep(500);
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();
                    AlignText("Press     to retreat to the menu.");
                    Thread.Sleep(500);
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    ClearCurrentConsoleLine();
                }

                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    MainMenu(false, false);
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

        public void AlignText(string text)
        {
            Console.SetCursorPosition((Console.WindowWidth - text.Length) / 2, Console.CursorTop);
            Console.WriteLine(text);
        }
        public void ClearCurrentConsoleLine()
        {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}
