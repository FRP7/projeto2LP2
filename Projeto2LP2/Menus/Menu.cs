using System;
using System.Threading;
using System.IO;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe of the main Menu.
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Method where the main Menu is exposed.
        /// </summary>
        /// <param name="introPlay"> Check if the intro can be played.</param>
        /// <param name="splashPlay"> Check if the SplashScreen can be shown.
        /// </param>
        public void MainMenu(bool introPlay, bool splashPlay)
        {
            ConsoleKey key;

            // Required initializations.
            Intro intro = new Intro();
            SplashScreen splash = new SplashScreen();
            GameLoop game = new GameLoop();

            bool retry = false;

            // Show the game's intro.
            if (introPlay)
                intro.IntroMenu();

            // Show the SplashScreen.
            if (splashPlay)
                splash.SplashScreenMenu();

            // Show the main Menu.
            do
            {
                Console.Clear();

                Console.WriteLine("\n\t\t\t   _________   ____ __  _   ___" +
                    "      ___ ___  ____ ____  ____  ____    __ ");
                Console.WriteLine("\t\t\t  / ___/    \\ /    |  |/ ] /  _]" +
                    "    |   |   |/    |    \\|    |/    |  /  ]");
                Console.WriteLine("\t\t\t (   \\_|  _  |  o  |  ' / /  [_" +
                    "     | _   _ |  o  |  _  ||  ||  o  | /  / ");
                Console.WriteLine("\t\t\t  \\__  |  |  |     |    \\|    _]" +
                    "    |  \\_/  |     |  |  ||  ||     |/  /  ");
                Console.WriteLine("\t\t\t  /  \\ |  |  |  _  |     |   [_" +
                    "     |   |   |  _  |  |  ||  ||  _  /   \\_ ");
                Console.WriteLine("\t\t\t  \\    |  |  |  |  |  .  |     |" +
                    "    |   |   |  |  |  |  ||  ||  |  \\     | ");
                Console.WriteLine("\t\t\t   \\___|__|__|__|__|__|\\_|_____|" +
                    "    |___|___|__|__|__|__|____|__|__|\\____| ");

                Console.WriteLine("\n\n\t\t\t\t\t\t       (P)LAY");
                Console.WriteLine("\n\t\t\t\t\t\t    (I)NSTRUTIONS");
                Console.WriteLine("\n\t\t\t\t\t\t      (S)CORES");
                Console.WriteLine("\n\t\t\t\t\t\t      (C)REDITS");
                Console.WriteLine("\n\t\t\t\t\t\t       (E)XIT");

                // Variable that contains the player's choice.
                key = Console.ReadKey(true).Key;

                // Check which option was chosen.
                switch (key)
                {
                    case ConsoleKey.P:
                        Console.Clear();
                        game.Game();
                        break;
                    case ConsoleKey.I:
                        Instructions(retry);
                        break;
                    case ConsoleKey.S:
                        Score(retry);
                        break;
                    case ConsoleKey.C:
                        Credits(retry);
                        break;
                    case ConsoleKey.E:
                        Exit();
                        break;
                    default:
                        retry = true;
                        break;
                }
            } while (retry);
        }

        /// <summary>
        /// Instructions page.
        /// </summary>
        /// <param name="retry"> Check if can return back. </param>
        private void Instructions(bool retry)
        {
            ConsoleKey key;
            do
            {
                Console.Clear();

                Console.WriteLine("\n\t        You are the snake (@).");
                Console.WriteLine("\t  Use the Arrow keys to move around.");
                Console.WriteLine("\t Eat has many apples ($) has you can.");
                Console.WriteLine("\tAvoid hitting the walls, they kill you.");
                Console.WriteLine("    Avoid eating yourself, that might kill you too.");
                Console.WriteLine("\t\t   Good Luck!\n");

                // While the player doesn't click.
                while (!Console.KeyAvailable)
                {
                    Console.WriteLine("\tPress ESQ to retreat to the menu.");
                    Thread.Sleep(250);

                    // Position the cursor on the line before.
                    Console.SetCursorPosition(0, Console.CursorTop - 1);

                    // Delete the line before.
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b" +
                        "\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                    Console.WriteLine("\tPress     to retreat to the menu.");
                    Thread.Sleep(250);

                    // Position the cursor on the line before.
                    Console.SetCursorPosition(0, Console.CursorTop - 1);

                    // Delete the line before.
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b" +
                        "\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                }

                // Variable that contains the player's choice.
                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Escape)
                    MainMenu(false, false);
                else
                    retry = true;
            }
            while (retry);
        }

        /// <summary>
        /// Page of the score.
        /// </summary>
        /// <param name="retry"> Check if can return back. </param>
        private void Score(bool retry)
        {
            ConsoleKey key;
            do
            {
                Console.Clear();

                Console.WriteLine(string.Empty);
                ScoreReader();
                Console.WriteLine(string.Empty);

                // While the player doesn't click.
                while (!Console.KeyAvailable)
                {
                    Console.WriteLine("\tPress ESQ to retreat to the menu.");
                    Thread.Sleep(250);

                    // Set cursor in the line before.
                    Console.SetCursorPosition(0, Console.CursorTop - 1);

                    // Delete the line before.
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b" +
                        "\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                    Console.WriteLine("\tPress     to retreat to the menu.");
                    Thread.Sleep(250);

                    // Set cursor in the line before.
                    Console.SetCursorPosition(0, Console.CursorTop - 1);

                    // Delete the line before.
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b" +
                        "\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                }

                // Variable that contains the player's choice.
                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Escape)
                    MainMenu(false, false);
                else
                    retry = true;
            }
            while (retry);
        }

        /// <summary>
        /// Page of the Credits.
        /// </summary>
        /// <param name="retry"> Check if can return back. </param>
        private void Credits(bool retry)
        {
            ConsoleKey key;
            do
            {
                Console.Clear();

                Console.WriteLine("\n\t       Made with love by:\n\n");
                Console.WriteLine("\t\t  André Cosme;\n");
                Console.WriteLine("\t\tFrancisco Pires;\n");
                Console.WriteLine("\t\tNuno Figueiredo.\n\n");

                // While the player doesn't click.
                while (!Console.KeyAvailable)
                {
                    Console.WriteLine("\tPress ESQ to retreat to the menu.");
                    Thread.Sleep(250);

                    // Set cursor in the line before.
                    Console.SetCursorPosition(0, Console.CursorTop - 1);

                    // Delete the line before.
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b" +
                        "\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                    Console.WriteLine("\tPress     to retreat to the menu.");
                    Thread.Sleep(250);

                    // Set cursor in the line before.
                    Console.SetCursorPosition(0, Console.CursorTop - 1);

                    // Delete the line before.
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b" +
                        "\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                }

                // Variabe that contains the player's choice.
                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Escape)
                    MainMenu(false, false);
                else
                    retry = true;
            }
            while (retry);
        }

        /// <summary>
        /// Exit game.
        /// </summary>
        private void Exit()
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Read the score file.
        /// </summary>
        private void ScoreReader()
        {
            // Variable that contains the file name.
            const string fileName = "Score.txt";
            if (File.Exists(fileName)) {
                // Read the file lines.
                string[] lines = File.ReadAllLines(fileName);

                // Print the file lines.
                foreach (string line in lines) {
                    Console.WriteLine("\t" + line);
                }
            }
            else {
                Console.WriteLine("Not available");
            }
        }
    }
}
