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
                        break;
                    case ConsoleKey.DownArrow:
                        //Console.WriteLine("Down");
                        //y++;
                        break;
                    case ConsoleKey.LeftArrow:
                        //Console.WriteLine("Left");
                        /*if (x > 0) {
                            x--;
                        }*/
                        break;
                    case ConsoleKey.RightArrow:
                        //Console.WriteLine("Right");
                        //x++;
                        break;
                    default:
                        //Console.WriteLine("Nothing");
                        break;
                }
            }
        }
    }
}
