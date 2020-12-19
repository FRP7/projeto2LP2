using System;
using System.Linq;

namespace Projeto2LP2
{
    /// <summary>
    /// Desenhar a cobra.
    /// </summary>
    class SnakeRender
    {
        public void RenderSnake() {
            try {
                if(GameLoop.SnakeX >= 0 && GameLoop.SnakeY >= 0) {
                    if (RenderEngine.count < GameLoop.snakeBody.Count) {
                        System.Threading.Thread.Sleep(100);
                        Console.SetCursorPosition(GameLoop.SnakeX, GameLoop.SnakeY);
                        GameLoop.snakeBody[RenderEngine.count].CordX = GameLoop.SnakeX;
                        GameLoop.snakeBody[RenderEngine.count].CordY = GameLoop.SnakeY;
                        Console.Write(GameLoop.snakeBody[RenderEngine.count].Part);
                    }
                    else if(RenderEngine.count > GameLoop.snakeBody.Count - 1) {
                        System.Threading.Thread.Sleep(500);
                        Console.SetCursorPosition(GameLoop.Tail.CordX, GameLoop.Tail.CordY);
                        Console.Write(' ');
                        GameLoop.snakeBody.RemoveAt(0);
                        GameLoop.snakeBody.Add(new SnakePart(GameLoop.SnakeX, 
                            GameLoop.SnakeY, '@'));
                        RenderEngine.count -= 2;
                    }
                }
            }
            catch (Exception) {
            }
        }
    }
}
