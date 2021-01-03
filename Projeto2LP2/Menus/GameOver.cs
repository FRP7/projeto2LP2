using System;
using System.Threading;
using System.IO;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe de GameOver.
    /// </summary>
    public class GameOver
    {
        /// <summary>
        /// Página do GameOver.
        /// </summary>
        public void GameOverMenu()
        {
            Facade facade = new Facade();

            const string fileName = "Score.txt";
            bool retry;

            do
            {
                Console.Clear();
                // Escrever no ficheiro o score adquirido
                if(File.Exists(fileName)) {
                    File.AppendAllText(fileName, Environment.NewLine +
                   $"Date: {DateTime.Now} | Score: " +
                   $"{Facade.GetScore}");
                }
                else {
                    using StreamWriter sr = new StreamWriter(fileName, true);
                    sr.WriteLine(Environment.NewLine + "Date:" +
                        $" {DateTime.Now} " +
                        "| Score: " + $"{Facade.GetScore}");
                }
                Console.WriteLine("\n\tYou have met an unfortunate end.");
                Console.WriteLine("\n\t\tFinal score: " + Facade.GetScore);

                if (Facade.GetScore < 0)
                    Console.WriteLine("\n\tHow did you get this score!? Cheater!\n");
                else if (Facade.GetScore == 0)
                    Console.WriteLine("\n\t     You didn't even try...\n");
                else if (Facade.GetScore >= 1 && Facade.GetScore < 10)
                    Console.WriteLine("\n       You can do better I believe in you!\n");
                else if (Facade.GetScore >= 10 && Facade.GetScore < 20)
                    Console.WriteLine("\n\t    Not bad at all, good job!\n");
                else if (Facade.GetScore >= 20)
                    Console.WriteLine("\n\t  Great score, congratulations!\n");
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
                ConsoleKey key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Escape)
                {
                    facade.Menu(false, false);
                    retry = false;
                }
                else
                {
                    retry = true;
                }
            }
            while (retry);
        }
    }
}
