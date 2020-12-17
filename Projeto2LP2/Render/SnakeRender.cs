using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Desenhar a cobra.
    /// </summary>
    class SnakeRender
    {
        public void RenderSnake() {
            try {
                if(GameLoop.X >= 0 && GameLoop.Y >= 0) {
                    //Console.Clear();
                    //System.Threading.Thread.Sleep(500);
                    Console.SetCursorPosition(GameLoop.X, GameLoop.Y);
                    Console.Write('@');
                }
            }
            catch (Exception) {
            }
        }
    }
}
