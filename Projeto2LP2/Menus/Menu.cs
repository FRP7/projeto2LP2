using System;
using System.Threading;
using System.IO;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe do menu principal.
    /// </summary>
    public class Menu
    {
        private ConsoleKey key;

        /// <summary>
        /// Método onde é exposto o menu principal.
        /// </summary>
        /// <param name="introPlay"> Indicar se pode correr a intro. </param>
        /// <param name="splashPlay"> Indicar se pode correr o splashscreen. 
        /// </param>
        public void MainMenu(bool introPlay, bool splashPlay)
        {
            // Inicializações necessárias
            Intro intro = new Intro();
            SplashScreen splash = new SplashScreen();
            GameLoop game = new GameLoop();

            bool retry = false;

            // Mostrar a introdução do jogo.
            if (introPlay)
                intro.IntroMenu();

            // Mostrar o splash do jogo.
            if (splashPlay)
                splash.SplashScreenMenu();

            // Mostrar o menu principal.
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

                // Variável que contem a opção do jogador
                key = Console.ReadKey(true).Key;

                // Switch para verificar qual opção foi escolhida
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
        /// Páginas das instruções.
        /// </summary>
        /// <param name="retry"> Indicar se pode voltar atrás. </param>
        private void Instructions(bool retry)
        {
            do
            {
                Console.Clear();

                Console.WriteLine("\n\t        You are the snake (@).");
                Console.WriteLine("\t  Use the Arrow keys to move around.");
                Console.WriteLine("\t Eat has many apples ($) has you can.");
                Console.WriteLine("\tAvoid hitting the walls, they kill you.");
                Console.WriteLine("    Avoid eating yourself, that might kill you too.");
                Console.WriteLine("\t\t   Good Luck!\n");

                // Enquanto o jogador não clicar
                while (!Console.KeyAvailable)
                {
                    Console.WriteLine("\tPress ESQ to retreat to the menu.");
                    Thread.Sleep(250);

                    // Posicionar o cursor na linha anterior
                    Console.SetCursorPosition(0, Console.CursorTop - 1);

                    // Apagar a linha anterior
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b" +
                        "\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                    Console.WriteLine("\tPress     to retreat to the menu.");
                    Thread.Sleep(250);

                    // Posicionar o cursor na linha anterior
                    Console.SetCursorPosition(0, Console.CursorTop - 1);

                    // Apagar a linha anterior
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b" +
                        "\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                }

                // Variável que contem a opção do jogador
                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Escape)
                    MainMenu(false, false);
                else
                    retry = true;
            }
            while (retry);
        }

        /// <summary>
        /// Página da pontuação.
        /// </summary>
        /// <param name="retry"> Indicar se pode voltar atrás. </param>
        private void Score(bool retry)
        {
            do
            {
                Console.Clear();

                Console.WriteLine(string.Empty);
                ScoreReader();
                Console.WriteLine(string.Empty);

                // Enquanto o jogador não clicar
                while (!Console.KeyAvailable)
                {
                    Console.WriteLine("\tPress ESQ to retreat to the menu.");
                    Thread.Sleep(250);

                    // Posicionar o cursor na linha anterior
                    Console.SetCursorPosition(0, Console.CursorTop - 1);

                    // Apagar a linha anterior
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b" +
                        "\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                    Console.WriteLine("\tPress     to retreat to the menu.");
                    Thread.Sleep(250);

                    // Posicionar o cursor na linha anterior
                    Console.SetCursorPosition(0, Console.CursorTop - 1);

                    // Apagar a linha anterior
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b" +
                        "\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                }

                // Variável que contem a opção do jogador
                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Escape)
                    MainMenu(false, false);
                else
                    retry = true;
            }
            while (retry);
        }

        /// <summary>
        /// Página dos créditos.
        /// </summary>
        /// <param name="retry"> Indicar se pode voltar atrás. </param>
        private void Credits(bool retry)
        {
            do
            {
                Console.Clear();

                Console.WriteLine("\n\t       Made with love by:\n\n");
                Console.WriteLine("\t\t  André Cosme;\n");
                Console.WriteLine("\t\tFrancisco Pires;\n");
                Console.WriteLine("\t\tNuno Figueiredo.\n\n");

                // Enquanto o jogador não clicar
                while (!Console.KeyAvailable)
                {
                    Console.WriteLine("\tPress ESQ to retreat to the menu.");
                    Thread.Sleep(250);

                    // Posicionar o cursor na linha anterior
                    Console.SetCursorPosition(0, Console.CursorTop - 1);

                    // Apagar a linha anterior
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b" +
                        "\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                    Console.WriteLine("\tPress     to retreat to the menu.");
                    Thread.Sleep(250);

                    // Posicionar o cursor na linha anterior
                    Console.SetCursorPosition(0, Console.CursorTop - 1);

                    // Apagar a linha anterior
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b" +
                        "\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                }

                // Variável que contem a opção do jogador
                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Escape)
                    MainMenu(false, false);
                else
                    retry = true;
            }
            while (retry);
        }

        /// <summary>
        /// Sair do jogo.
        /// </summary>
        private void Exit()
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// Leitura da pontuação.
        /// </summary>
        private void ScoreReader()
        {
            // Variável que contém o ficheiro do score
            string fileName = "Score.txt";
            if (File.Exists(fileName)) {
                // Ler as linhas do ficheiro
                string[] lines = File.ReadAllLines(fileName);

                // Imprimir as linhas do ficheiro
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
