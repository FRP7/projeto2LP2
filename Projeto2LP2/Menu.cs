using System;

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
        public void MainMenu() {
            ConsoleKey key;
            bool shut = false;

            Console.Clear();

            Console.WriteLine("Aqui é o main menu");

            // Enquanto o menu não estiver terminado, fica isto pa entrar no jogo:

            while(shut == false) {
                Console.WriteLine("Clique em enter para começar a jogar.");
                key = Console.ReadKey().Key;

                if (key == ConsoleKey.Enter) {
                    Console.Clear();
                    DeleteLater();
                }
                else {
                    Console.WriteLine("Tente de novo");
                }
            }

        }

        // Enquanto o menu não estiver terminado, fica isto pa entrar no jogo:
        private void DeleteLater() {
            GameLoop game = new GameLoop();
            game.Game();
        }
    }
}
