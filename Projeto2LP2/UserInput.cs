using System;

namespace Projeto2LP2
{
    class UserInput
    {
        public ConsoleKey Key { get => getKey; }
        private ConsoleKey getKey;

        public void CheckUserInput() {
            ConsoleKey key;
            if (Console.KeyAvailable) {
                key = Console.ReadKey().Key;
                getKey = key;
                switch (key) {
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
                    default:
                        GameLoop.direction = Direction.None;
                        break;
                }
            }
        }
    }
}
