﻿using System;
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
        public void GameOverMenu(ConsoleKey key, bool retry)
        {
            Menu menu = new Menu();

            string fileName = "Score.txt";

            do
            {
                Console.Clear();
                File.AppendAllText(fileName, Environment.NewLine + $"Date: {DateTime.Now.ToString()} | Score: {GameLoop.ScoreValue}");
                menu.AlignText("");
                menu.AlignText("You have met an unfortunate end.");
                menu.AlignText("");
                menu.AlignText("Final score: " + GameLoop.ScoreValue);
                menu.AlignText("");

                if (GameLoop.ScoreValue < 0)
                {
                    menu.AlignText("How did you get this score!? Cheater!");
                    menu.AlignText("");
                }
                if (GameLoop.ScoreValue == 0)
                {
                    menu.AlignText("You didn't even try...");
                    menu.AlignText("");
                }
                if (GameLoop.ScoreValue >= 1 && GameLoop.ScoreValue < 10)
                {
                    menu.AlignText("You can do better I believe in you!");
                    menu.AlignText("");
                }
                else if (GameLoop.ScoreValue >= 10 && GameLoop.ScoreValue < 20)
                {
                    menu.AlignText("Not bad at all, good job!");
                    menu.AlignText("");
                }
                else if (GameLoop.ScoreValue >= 20)
                {
                    menu.AlignText("Great score, congratulations!");
                    menu.AlignText("");
                }
                while (!Console.KeyAvailable)
                {
                    menu.AlignText("Press ESQ to retreat to the menu.");
                    Thread.Sleep(500);
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    menu.ClearCurrentConsoleLine();
                    menu.AlignText("Press     to retreat to the menu.");
                    Thread.Sleep(500);
                    Console.SetCursorPosition(0, Console.CursorTop - 1);
                    menu.ClearCurrentConsoleLine();
                }

                key = Console.ReadKey(true).Key;

                if (key == ConsoleKey.Escape)
                {
                    Console.Clear();
                    menu.MainMenu(false, false);
                    retry = false;
                }
                else
                {
                    Console.Clear();
                    retry = true;
                }
            } while (retry == true);
        }
    }
}
