using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe onde é atualizada a posição da cobra.
    /// </summary>
    class SnakePosition
    {
        /// <summary>
        /// Verificar e atualizar a posição da cobra de acordo com a direção.
        /// </summary>
        public void SnakePositionCheck() {
            if(GameLoop.direction == Direction.Up) {
                if(GameLoop.SnakeY > 0) {
                    GameLoop.SnakeY--;
                }
            }
            else if(GameLoop.direction == Direction.Down) {
                GameLoop.SnakeY++;
            }
            else if(GameLoop.direction == Direction.Left) {
                if (GameLoop.SnakeX > 0) {
                    GameLoop.SnakeX--;
                }
            }
            else if(GameLoop.direction == Direction.Right) {
                GameLoop.SnakeX++;
            }
        }
    }
}
