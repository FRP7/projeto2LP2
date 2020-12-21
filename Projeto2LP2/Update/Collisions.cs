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
            /*for (int i = 1; i < GameState.GetSnakeBody.Count; i++)
            {
                if (GameState.GetSnakeBody[0].CordX > GameState.GetSnakeBody[i].CordX + (i * 64) || (GameState.GetSnakeBody[0].CordX + (i * 64)) < GameState.GetSnakeBody[i].CordX || GameState.GetSnakeBody[0].CordY > (GameState.GetSnakeBody[i].CordY + (i * 64)) || (GameState.GetSnakeBody[0].CordY + (i * 64)) < GameState.GetSnakeBody[i].CordY)
                {
                    Environment.Exit(0);
                }
                else
                {
                    Environment.Exit(0);
                }
            }*/

        }
        private void CheckFood()
        {
            if (GameState.GetHead.CordX == GameState.GetCordFoodX)
            {
                GameState.GetSnakeBody.Add(new SnakePart(GameState.GetCordSnakeX, GameState.GetCordSnakeY, '@'));
                Console.SetCursorPosition(GameState.GetCordFoodX, GameState.GetCordFoodY);
                Console.Write(' ');
            }
        }
    }
}
