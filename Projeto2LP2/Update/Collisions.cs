using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe de verificação das colisões do jogo.
    /// </summary>
    class Collisions
    {
        // Verificar as colisções do jogo.
        public void CollisionCheck()
        {
            // Verificar se a cobra colidiu com a comida.
            CheckFood();
            // Verificar se a cobra colidiu em si própria.
            CheckSnakeTouch();
            // Verificar se a cobra colidiu numa parede.
            CheckWalls();
        }

        // Verificar se a cobra colidiu com a comida.
        private void CheckFood() {
            if (GameState.GetHead.CordX == GameState.GetCordFoodX && GameState.GetHead.CordY == GameState.GetCordFoodY) {
                GameState.GetSnakeBody.Add(new SnakePart(GameState.GetCordSnakeX, GameState.GetCordSnakeY, '@'));
                Console.SetCursorPosition(GameState.GetCordFoodX, GameState.GetCordFoodY);
                Console.Write(' ');
                FoodPosition foodPosition = new FoodPosition();
                foodPosition.FoodPositionCheck();
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
        private void CheckWalls()
        {
            if (GameState.GetCordSnakeX == 0)
            {
                GameLoop.isGameOver = true;
            }
            if (GameState.GetCordSnakeX == GameState.GetSceneX - 1)
            {
                GameLoop.isGameOver = true;
            }
            if (GameState.GetCordSnakeY == 0)
            {
                GameLoop.isGameOver = true;
            }
            if (GameState.GetCordSnakeY == GameState.GetSceneY - 1)
            {
                GameLoop.isGameOver = true;
            }
        }
    }
}
