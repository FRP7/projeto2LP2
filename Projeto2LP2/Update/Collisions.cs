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

            testParedes();
        }
        private void testParedes()
        {

            if (RenderEngine.GetSnakeX == 0)
            {
                Environment.Exit(0);
            }
            if (RenderEngine.GetSnakeX == 36)
            {
                Environment.Exit(0);
            }
            if (RenderEngine.GetSnakeY == 0)
            {
                Environment.Exit(0);
            }
            if (RenderEngine.GetSnakeY == 15)
            {
                Environment.Exit(0);
            }
        }
    }
}
