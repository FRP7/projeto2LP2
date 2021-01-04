using System;
using System.Threading;

namespace Projeto2LP2
{
    /// <summary>
    /// Class of the SplashScreen.
    /// </summary>
    public class SplashScreen
    {
        /// <summary>
        /// Method of the page that appears before entering the menu.
        /// </summary>
        public void SplashScreenMenu()
        {
            bool retry;
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
                    "    |___|___|__|__|__|__|____|__|__|\\____| \n\n");

                // While the player doesn't click.
                while (!Console.KeyAvailable)
                {
                    Console.WriteLine("\t\t\t\t\t\tPress ENTER to continue.");
                    Thread.Sleep(250);

                    // Set the cursor in the line before.
                    Console.SetCursorPosition(0, Console.CursorTop - 1);

                    // Delete the line before.
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b" +
                        "\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                    Console.WriteLine("\t\t\t\t\t\tPress       to continue.");
                    Thread.Sleep(250);

                    // Set the cursor in the line before.
                    Console.SetCursorPosition(0, Console.CursorTop - 1);

                    // Delete the line before.
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b" +
                        "\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                }

                // The player's choice.
                ConsoleKey key = Console.ReadKey(true).Key;

                retry = key != ConsoleKey.Enter;
            }
            while (retry);
        }
    }
}
