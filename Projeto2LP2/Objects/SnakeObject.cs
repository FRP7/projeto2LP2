using System;
using System.Threading;

namespace Projeto2LP2
{
    class SnakeObject : GameObject
    {
        public override void Update() {
            // Verificar a posição da cobra.
            SnakePositionCheck();
            // Verificar se a cobra colidiu com a comida.
            CheckFood();
            // Verificar se a cobra colidiu em si própria.
            CheckSnakeTouch();
            // Verificar se a cobra colidiu numa parede.
            CheckWalls();
        }

        public override void Render() {
            if (RenderEngine.GetSnakeX >= 0 && RenderEngine.GetSnakeY >= 0) {
                if (RenderEngine.count < RenderEngine.SnakeBody.Count) {
                    Thread.Sleep(100);
                    Console.SetCursorPosition(RenderEngine.GetSnakeX, RenderEngine.GetSnakeY);
                    RenderEngine.SnakeBody[RenderEngine.count].CordX = RenderEngine.GetSnakeX;
                    RenderEngine.SnakeBody[RenderEngine.count].CordY = RenderEngine.GetSnakeY;
                    Console.Write(RenderEngine.SnakeBody[RenderEngine.count].Part);
                } else if (RenderEngine.count > RenderEngine.SnakeBody.Count - 1) {
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

        /// <summary>
        /// Verificar e atualizar a posição da cobra de acordo com a direção.
        /// </summary>
        private void SnakePositionCheck() {
            if (GameState.GetDirection == Direction.Up) {
                if (GameState.GetCordSnakeY > 0) {
                    GameState.GetCordSnakeY--;
                }
            } else if (GameState.GetDirection == Direction.Down) {
                GameState.GetCordSnakeY++;
            } else if (GameState.GetDirection == Direction.Left) {
                if (GameState.GetCordSnakeX > 0) {
                    GameState.GetCordSnakeX--;
                }
            } else if (GameState.GetDirection == Direction.Right) {
                GameState.GetCordSnakeX++;
            }
        }

        // Verificar se a cobra colidiu com a comida.
        private void CheckFood() {
            if (GameState.GetHead.CordX == GameState.GetCordFoodX && GameState.GetHead.CordY == GameState.GetCordFoodY) {
                GameState.GetSnakeBody.Add(new SnakePart(GameState.GetCordSnakeX, GameState.GetCordSnakeY, '@'));
                Console.SetCursorPosition(GameState.GetCordFoodX, GameState.GetCordFoodY);
                Console.Write(' ');
                //FoodPosition foodPosition = new FoodPosition();
                //foodPosition.FoodPositionCheck();
                GameObject foodObject = new FoodObject();
                foodObject.Update();
                GameState.GetScore++;
            }

        }

        // Verificar se a cobra colidiu em si própria.
        private void CheckSnakeTouch() {
            for (int i = 3; i < GameState.GetSnakeBody.Count; i++) {
                if (GameState.GetSnakeBody[0].CordX == GameState.GetSnakeBody[i].CordX && GameState.GetSnakeBody[0].CordY == GameState.GetSnakeBody[i].CordY) {
                    GameLoop.isGameOver = true;
                }
            }

        }

        // Verificar se a cobra colidiu numa parede.
        private void CheckWalls() {
            if (GameState.GetCordSnakeX == 0) {
                GameLoop.isGameOver = true;
            }
            if (GameState.GetCordSnakeX == GameState.GetSceneX - 1) {
                GameLoop.isGameOver = true;
            }
            if (GameState.GetCordSnakeY == 0) {
                GameLoop.isGameOver = true;
            }
            if (GameState.GetCordSnakeY == GameState.GetSceneY - 1) {
                GameLoop.isGameOver = true;
            }
        }
    }
}
