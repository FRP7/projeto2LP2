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
                /*if(GameLoop.X >= 0 && GameLoop.Y >= 0) {
                    //Console.Clear();
                    System.Threading.Thread.Sleep(500);
                    Console.SetCursorPosition(GameLoop.X, GameLoop.Y);
                    Console.Write('@');
                    Console.Write(RenderEngine.count);
                }*/

                if(GameLoop.X >= 0 && GameLoop.Y >= 0) {
                    if (RenderEngine.count < GameLoop.snakeBody.Count) {
                        System.Threading.Thread.Sleep(500);
                        Console.SetCursorPosition(GameLoop.X, GameLoop.Y);
                        GameLoop.snakeBody[RenderEngine.count].CordX = GameLoop.X;
                        GameLoop.snakeBody[RenderEngine.count].CordY = GameLoop.Y;
                        Console.Write(GameLoop.snakeBody[RenderEngine.count].Part);
                    }
                    else if(RenderEngine.count > GameLoop.snakeBody.Count - 1) {
                        System.Threading.Thread.Sleep(500);
                        Console.SetCursorPosition(GameLoop.Tail.CordX, GameLoop.Tail.CordY);
                        Console.Write(' ');
                        GameLoop.snakeBody.RemoveAt(0);
                        GameLoop.snakeBody.Add(new SnakePart(GameLoop.X, 
                            GameLoop.Y, '@'));
                        RenderEngine.count -= 2;
                    }
                }
            }
            catch (Exception) {
            }
        }
    }
}
