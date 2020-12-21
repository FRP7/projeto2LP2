using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe de verificação das colisões do jogo.
    /// </summary>
    class Collisions
    {
        public void CollisionCheck()
        {

            CheckWallks();
        }
        private void CheckWallks()
        {

            if (GameState.GetCordSnakeX == 0)
            {
                Environment.Exit(0);
            }
            if (GameState.GetCordSnakeX == 36)
            {
                Environment.Exit(0);
            }
            if (GameState.GetCordSnakeY == 0)
            {
                Environment.Exit(0);
            }
            if (GameState.GetCordSnakeY == 15)
            {
                Environment.Exit(0);
            }
        }
    }
}
