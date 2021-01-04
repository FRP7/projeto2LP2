using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe of the player's input.
    /// </summary>
    public class UserInput
    {
        /// <summary>
        /// Gets input from the player.
        /// </summary>
        public ConsoleKey GetKey { get; private set; }

        /// <summary>
        /// Check the player's input and set the snake's direction.
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
                        facade.Menu(false, false);
                        break;
                    default:
                        Facade.GetDirection = Direction.None;
                        break;
                }
            }
        }
    }
}
