using System;
using System.Threading;
using System.IO;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe de GameOver.
    /// </summary>
    class GameOver
    {
        /// <summary>
        /// Página do GameOver.
        /// </summary>
        /// <param name="key"> Input do jogador. </param>
        /// <param name="retry"> Indicar se pode sair da página. </param>
        public void GameOverMenu()
        {
            Menu menu = new Menu();

            string fileName = "Score.txt";
            bool retry;

            do
            {
                Console.Clear();
                File.AppendAllText(fileName, Environment.NewLine + 
                    $"Date: {DateTime.Now.ToString()} | Score: {GameLoop.ScoreValue}");
                Console.WriteLine("\n\tYou have met an unfortunate end.");
                Console.WriteLine("\n\t\tFinal score: " + GameLoop.ScoreValue);

                if (GameLoop.ScoreValue < 0)
                    Console.WriteLine("\n\tHow did you get this score!? Cheater!\n");
                else if (GameLoop.ScoreValue == 0)
                    Console.WriteLine("\n\t     You didn't even try...\n");
                else if (GameLoop.ScoreValue >= 1 && GameLoop.ScoreValue < 10)
                    Console.WriteLine("\n       You can do better I believe in you!\n");
                else if (GameLoop.ScoreValue >= 10 && GameLoop.ScoreValue < 20)
                    Console.WriteLine("\n\t    Not bad at all, good job!\n");
                else if (GameLoop.ScoreValue >= 20)
                    Console.WriteLine("\n\t  Great score, congratulations!\n");
                while (!Console.KeyAvailable)
                {
                    Console.WriteLine("\tPress ESQ to retreat to the menu.");
                    Thread.Sleep(250);
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b" +
                        "\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                    Console.WriteLine("\tPress     to retreat to the menu.");
                    Thread.Sleep(250);
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    Console.Write("\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b" +
                        "\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                }

                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Escape)
                {
                    menu.MainMenu(false, false);
                    retry = false;
                }
                else retry = true;
            }
            while (retry == true);
        }
    }
}
