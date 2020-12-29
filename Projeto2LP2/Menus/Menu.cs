using System;
using System.Threading;
using System.IO;

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
        /// <param name="introPlay"> Indicar se pode correr a intro. </param>
        /// <param name="splashPlay"> Indicar se pode correr o splashscreen. 
        /// </param>
        public void MainMenu(bool introPlay, bool splashPlay) {
            Intro intro = new Intro();
            SplashScreen splash = new SplashScreen();
            GameLoop game = new GameLoop();

            bool retry = false;
            ConsoleKey key = ConsoleKey.Backspace;

            if (introPlay) intro.IntroMenu();

            if (splashPlay) splash.SplashScreenMenu(key, retry);

            do {
                Console.Clear();

                AlignText("");
                AlignText("   _________   ____ __  _   ___      ___ ___ " +
                    " ____ ____  ____  ____    __ ");
                AlignText("  / ___/    \\ /    |  |/ ] /  _]    |   |" +
                    "   |/    |    \\|    |/    |  /  ]");
                AlignText(" (   \\_|  _  |  o  |  ' / /  [_     | _   _" +
                    " |  o  |  _  ||  ||  o  | /  / ");
                AlignText("  \\__  |  |  |     |    \\|    _]    |  \\_/ " +
                    " |     |  |  ||  ||     |/  /  ");
                AlignText("  /  \\ |  |  |  _  |     |   [_     |   |   |" +
                    "  _  |  |  ||  ||  _  /   \\_ ");
                AlignText("   \\    |  |  |  |  |  .  |     |    |   |   " +
                    "|  |  |  |  ||  ||  |  \\     | ");
                AlignText("    \\___|__|__|__|__|__|\\_|_____|    |___|__" +
                    "_|__|__|__|__|____|__|__|\\____| ");
                AlignText("");
                AlignText("");
                AlignText("(P)LAY");
                AlignText("");
                AlignText("(I)NSTRUTIONS");
                AlignText("");
                AlignText("(S)CORES");
                AlignText("");
                AlignText("(C)REDITS");
                AlignText("");
                AlignText("(E)XIT");

                key = Console.ReadKey(true).Key;

                switch (key) {
                    case ConsoleKey.P:
                        Console.Clear();
                        game.Game();
                        break;
                    case ConsoleKey.I:
                        Console.Clear();
                        Instructions(key, retry);
                        break;
                    case ConsoleKey.S:
                        Console.Clear();
                        Score(key, retry);
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

        /// <summary>
        /// Páginas das instruções.
        /// </summary>
        /// <param name="key"> Input do jogador. </param>
        /// <param name="retry"> Indicar se pode voltar atrás. </param>
        private void Instructions(ConsoleKey key, bool retry) {
            do {
                Console.Clear();

                AlignText("");
                AlignText("You are the snake (@).");
                AlignText("Use the Arrow keys to move the snake around.");
                AlignText("Eat has many apples ($) has you can.");
                AlignText("Avoid hitting the wall has these will kill you.");
                AlignText("Also avoid hitting yourself, so you dont eat " +
                    "yourself and die dummy.");
                AlignText("Good Luck!");
                AlignText("");
                while (!Console.KeyAvailable) {
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

                if (key == ConsoleKey.Escape) {
                    Console.Clear();
                    MainMenu(false, false);
                    retry = false;
                } else {
                    retry = true;
                }
            } while (retry == true);
        }

        /// <summary>
        /// Página da pontuação.
        /// </summary>
        /// <param name="key"> Input do jogador. </param>
        /// <param name="retry"> Indicar se pode voltar atrás. </param>
        private void Score(ConsoleKey key, bool retry) {
            do {
                Console.Clear();

                AlignText("");
                ScoreReader();
                AlignText("");
                while (!Console.KeyAvailable) {
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

                if (key == ConsoleKey.Escape) {
                    Console.Clear();
                    MainMenu(false, false);
                    retry = false;
                } else {
                    retry = true;
                }
            } while (retry == true);
        }

        /// <summary>
        /// Página dos créditos.
        /// </summary>
        /// <param name="key"> Input do jogador. </param>
        /// <param name="retry"> Indicar se pode voltar atrás. </param>
        private void Credits(ConsoleKey key, bool retry) {
            do {
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
                while (!Console.KeyAvailable) {
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

                if (key == ConsoleKey.Escape) {
                    Console.Clear();
                    MainMenu(false, false);
                    retry = false;
                } else {
                    Console.Clear();
                    retry = true;
                }
            } while (retry == true);
        }

        /// <summary>
        /// Sair do jogo.
        /// </summary>
        private void Exit() {
            Environment.Exit(0);
        }

        /// <summary>
        /// Leitura da pontuação.
        /// </summary>
        private void ScoreReader() {
            string fileName = "Score.txt";

            string[] lines = File.ReadAllLines(fileName);
            foreach (string line in lines) {
                Console.WriteLine(line);
            }
        }

        /// <summary>
        /// Alinhar o texto.
        /// </summary>
        /// <param name="text"></param>
        public void AlignText(string text) {
            Console.SetCursorPosition((Console.WindowWidth - text.Length)
                / 2, Console.CursorTop);
            Console.WriteLine(text);
        }

        /// <summary>
        /// Limpar o ecrã.
        /// </summary>
        public void ClearCurrentConsoleLine() {
            int currentLineCursor = Console.CursorTop;
            Console.SetCursorPosition(0, Console.CursorTop);
            Console.Write(new string(' ', Console.WindowWidth));
            Console.SetCursorPosition(0, currentLineCursor);
        }
    }
}
