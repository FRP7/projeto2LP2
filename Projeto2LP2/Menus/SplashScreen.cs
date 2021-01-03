using System;
using System.Threading;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe do SplashScreen.
    /// </summary>
    class SplashScreen
    {
        /// <summary>
        /// Método da página que aparece antes de entrar para o menu.
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
                // Enquanto o jogador não clicar
                while (!Console.KeyAvailable)
                {
                    Console.WriteLine("\t\t\t\t\t\tPress ENTER to continue.");
                    Thread.Sleep(250);
                    // Posicionar o cursor na linha anterior
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    // Apagar a linha anterior
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b" +
                        "\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                    Console.WriteLine("\t\t\t\t\t\tPress       to continue.");
                    Thread.Sleep(250);
                    // Posicionar o cursor na linha anterior
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    // Apagar a linha anterior
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b" +
                        "\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                }
                // Variável que contêm a opção do jogador
                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Enter) retry = false;
                else retry = true;
            }
            while (retry == true);
        }
    }
}
