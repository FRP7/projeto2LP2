using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe onde é analisado o input do jogador.
    /// </summary>
    sealed class UserInput
    {
        /// Input do user.
        public ConsoleKey GetKey { get; private set; }

        /// <summary>
        /// Verificar o input do user e escolher a direção atual da cobra.
        /// </summary>
        public void CheckUserInput() {
            Facade facade = new Facade();
            if (Console.KeyAvailable) {
                GetKey = Console.ReadKey(true).Key;
                switch (GetKey) {
                    case ConsoleKey.UpArrow:
                        if (Facade.GetDirection != Direction.Down) {
                            Facade.GetDirection = Direction.Up;
                        }
                        break;
                    case ConsoleKey.DownArrow:
                        if (Facade.GetDirection != Direction.Up) {
                            Facade.GetDirection = Direction.Down;
                        }
                        break;
                    case ConsoleKey.LeftArrow:
                        if (Facade.GetDirection != Direction.Right) {
                            Facade.GetDirection = Direction.Left;
                        }
                        break;
                    case ConsoleKey.RightArrow:
                        if (Facade.GetDirection != Direction.Left) {
                            Facade.GetDirection = Direction.Right;
                        }
                        break;
                    case ConsoleKey.Escape:
                        facade.Menu();
                        break;
                    default:
                        Facade.GetDirection = Direction.None;
                        break;
                }
            }
        }
    }
}
