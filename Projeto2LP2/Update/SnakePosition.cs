using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Aqui é onde é actualizada a posição da cobra.
    /// </summary>
    class SnakePosition
    {
        public void SnakePositionCheck() {
            if(GameLoop.direction == Direction.Up) {
                if(GameLoop.Y > 0) {
                    GameLoop.Y--;
                }
            }
            else if(GameLoop.direction == Direction.Down) {
                GameLoop.Y++;
            }
            else if(GameLoop.direction == Direction.Left) {
                if (GameLoop.X > 0) {
                    GameLoop.X--;
                }
            }
            else if(GameLoop.direction == Direction.Right) {
                GameLoop.X++;
            }
            // testar
            //Console.WriteLine(GameLoop.GetKey);
            //Console.WriteLine($"X: {GameLoop.X}. Y: {GameLoop.Y}");
        }
    }
}
