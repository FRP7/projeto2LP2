using System;
using System.Collections.Generic;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe de verificação das colisões do jogo.
    /// </summary>
    class Collisions
    {
        public void CollisionCheck()
        {
            CheckFood();
            CheckSnakeTouch();
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
        private void CheckSnakeTouch()
        {
            for (int i = 3; i < GameState.GetSnakeBody.Count; i++)
            {
                if (GameState.GetSnakeBody[0].CordX == GameState.GetSnakeBody[i].CordX && GameState.GetSnakeBody[0].CordY == GameState.GetSnakeBody[i].CordY)
                {
                    Environment.Exit(0); 
                }
            }

        }
        private void CheckFood()
        {
            if (GameState.GetHead.CordX == GameState.GetCordFoodX && GameState.GetHead.CordY == GameState.GetCordFoodY)
            {
                GameState.GetSnakeBody.Add(new SnakePart(GameState.GetCordSnakeX, GameState.GetCordSnakeY, '@'));
                Console.SetCursorPosition(GameState.GetCordFoodX, GameState.GetCordFoodY);
                Console.Write(' ');
                FoodPosition foodPosition = new FoodPosition();
                foodPosition.FoodPositionCheck();
                GameState.GetScore++;
            }
            
        }

    }
}
