using System;
using System.Threading;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe onde é renderizada a cobra.
    /// </summary>
    class SnakeRender
    {
        /// <summary>
        /// Renderizar a cobra.
        /// </summary>
        public void RenderSnake() {
                if(RenderEngine.GetSnakeX >= 0 && RenderEngine.GetSnakeY >= 0) {
                    if (RenderEngine.count < RenderEngine.SnakeBody.Count) {
                        Thread.Sleep(100);
                        Console.SetCursorPosition(RenderEngine.GetSnakeX, RenderEngine.GetSnakeY);
                        RenderEngine.SnakeBody[RenderEngine.count].CordX = RenderEngine.GetSnakeX;
                        RenderEngine.SnakeBody[RenderEngine.count].CordY = RenderEngine.GetSnakeY;
                        Console.Write(RenderEngine.SnakeBody[RenderEngine.count].Part);
                    }
                    else if(RenderEngine.count > RenderEngine.SnakeBody.Count - 1) {
                        Thread.Sleep(500);
                        Console.SetCursorPosition(RenderEngine.Tail.CordX, RenderEngine.Tail.CordY);
                        Console.Write(' ');
                        RenderEngine.SnakeBody.RemoveAt(0);
                        RenderEngine.SnakeBody.Add(new SnakePart(RenderEngine.GetSnakeX, 
                            RenderEngine.GetSnakeY, '@'));
                        RenderEngine.count -= 2;
                    }
                }
            }
        }
    }
