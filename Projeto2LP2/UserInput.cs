using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe onde é analisado o input do jogador.
    /// </summary>
    class UserInput
    {
        /// Input do user.
        public ConsoleKey Key { get => getKey; }

        // Input do user.
        private ConsoleKey getKey;

        /// <summary>
        /// Verificar o input do user e escolher a direção atual da cobra.
        /// </summary>
        public void CheckUserInput() {
            if (Console.KeyAvailable) {
                getKey = Console.ReadKey().Key;
                switch (getKey) {
                    case ConsoleKey.UpArrow:
                        if (GameLoop.direction != Direction.Down) {
                            GameLoop.direction = Direction.Up;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (GameLoop.direction != Direction.Up) {
                            GameLoop.direction = Direction.Down;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (GameLoop.direction != Direction.Right) {
                            GameLoop.direction = Direction.Left;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (GameLoop.direction != Direction.Left) {
                            GameLoop.direction = Direction.Right;
                        }
                        break;
                    case ConsoleKey.Escape:
                        Menu menu = new Menu();
                        menu.MainMenu();
                        break;
                    default:
                        GameLoop.direction = Direction.None;
                        break;
                }
            }
        }
    }
}
