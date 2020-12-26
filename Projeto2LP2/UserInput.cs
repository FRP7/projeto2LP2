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
                getKey = Console.ReadKey(true).Key;
                switch (getKey) {
                    case ConsoleKey.UpArrow:
                        if (SnakeObject.direction != Direction.Down) {
                            SnakeObject.direction = Direction.Up;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (SnakeObject.direction != Direction.Up) {
                            SnakeObject.direction = Direction.Down;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (SnakeObject.direction != Direction.Right) {
                            SnakeObject.direction = Direction.Left;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (SnakeObject.direction != Direction.Left) {
                            SnakeObject.direction = Direction.Right;
                        }
                        break;
                    case ConsoleKey.Escape:
                        Menu menu = new Menu();
                        menu.MainMenu();
                        break;
                    default:
                        SnakeObject.direction = Direction.None;
                        break;
                }
            }
        }
    }
}
