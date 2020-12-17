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
                        //Console.WriteLine("Up");
                        /*if (y > 0) {
                            y--;
                        }*/
                        //Console.Clear();
                        GameLoop.direction = Direction.Up;
                        break;
                    case ConsoleKey.DownArrow:
                        //Console.WriteLine("Down");
                        //y++;
                        //Console.Clear();
                        GameLoop.direction = Direction.Down;
                        break;
                    case ConsoleKey.LeftArrow:
                        //Console.WriteLine("Left");
                        /*if (x > 0) {
                            x--;
                        }*/
                        //Console.Clear();
                        GameLoop.direction = Direction.Left;
                        break;
                    case ConsoleKey.RightArrow:
                        //Console.WriteLine("Right");
                        //x++;
                        //Console.Clear();
                        GameLoop.direction = Direction.Right;
                        break;
                    default:
                        //Console.WriteLine("Nothing");
                        GameLoop.direction = Direction.None;
                        break;
                }
            }
        }
    }
}
