using System;
using System.Threading;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe do menu game over.
    /// </summary>
    class GameOver
    {
        // Iniciar o menu de game over.
        public void GameOverMenu() {
            MenuContent();
        }

        // Conteúdo do menu de game over.
        private void MenuContent() {
            Console.Clear();
            Console.WriteLine("Inserir menu de game over.");
            Console.WriteLine("Score final: " + GameLoop.ScoreValue);
            Thread.Sleep(1000);
            ReturnMainMenu();
        }

        // Voltar ao main menu.
        private void ReturnMainMenu() {
            Menu menu = new Menu();
            menu.MainMenu();
        }
    }
}
