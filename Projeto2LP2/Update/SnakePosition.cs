using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Aqui é onde é actualizada a posição da cobra.
    /// </summary>
    class SnakePosition
    {
        public void SnakePositionCheck() {
            if(GameLoop.GetKey == ConsoleKey.UpArrow) {
                if(GameLoop.Y > 0) {
                    GameLoop.Y--;
                }
            }
            else if(GameLoop.GetKey == ConsoleKey.DownArrow) {
                GameLoop.Y++;
            }
            else if(GameLoop.GetKey == ConsoleKey.LeftArrow) {
                if (GameLoop.X > 0) {
                    GameLoop.X--;
                }
            }
            else if(GameLoop.GetKey == ConsoleKey.RightArrow) {
                GameLoop.X++;
            }
            // testar
            Console.WriteLine(GameLoop.GetKey);
            Console.WriteLine($"X: {GameLoop.X}. Y: {GameLoop.Y}");
        }
    }
}
