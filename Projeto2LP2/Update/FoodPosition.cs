using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe onde é atualizada a posição da comida.
    /// </summary>
    class FoodPosition
    {
        private Random random;

        /// <summary>
        /// Atualizar a posição da comida.
        /// </summary>
        public void FoodPositionCheck()
        {
            GenerateFood();
        }
      
        /// <summary>
        /// Definir aleatoriamente as coordenadas da comida.
        /// </summary>
        private void GenerateFood()
        {
            random = new Random();

            GameState.GetCordFoodX = random.Next(2, GameState.GetSceneX - 2);
            GameState.GetCordFoodY = random.Next(2, GameState.GetSceneY - 2);
        }

    }
}

