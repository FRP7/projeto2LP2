using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe onde é definida a posição da comida.
    /// </summary>
    class FoodPosition
    {
        bool Coco = false;
        /// <summary>
        /// Definir a posição da comida.
        /// </summary>
        public void FoodPositionCheck()
        {
            if (Coco == false)
            {
                RandomPosition();
                Coco = true;
            }
        }
        private void GenerateFood(int x, int y)
        { 
            GameState.GetCordFoodX = x;
            GameState.GetCordFoodY = y;
        }
        private void RandomPosition()
        {
            int x;
            int y;

            Random random = new Random();
            x = random.Next(0, 10);
            y = random.Next(0, 10);

            GenerateFood(x, y);
        }
    }
}

