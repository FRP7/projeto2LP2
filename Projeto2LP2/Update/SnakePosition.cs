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
            if(GameState.GetDirection == Direction.Up) {
                if(GameState.GetCordSnakeY > 0) {
                    GameState.GetCordSnakeY--;
                }
            }
            else if(GameState.GetDirection == Direction.Down) {
                GameState.GetCordSnakeY++;
            }
            else if(GameState.GetDirection == Direction.Left) {
                if (GameState.GetCordSnakeX > 0) {
                    GameState.GetCordSnakeX--;
                }
            }
            else if(GameState.GetDirection == Direction.Right) {
                GameState.GetCordSnakeX++;
            }
        }
    }
}
