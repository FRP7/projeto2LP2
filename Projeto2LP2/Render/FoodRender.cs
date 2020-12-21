using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe onde é renderizada a comida.
    /// </summary>
    class FoodRender
    {
        /// <summary>
        /// Renderizar a comida.
        /// </summary>
        public void RenderFood()
        {
            Console.SetCursorPosition(RenderEngine.GetFoodX, RenderEngine.GetFoodY);
            Food food = new Food(RenderEngine.GetFoodX, RenderEngine.GetFoodY, '$');
            Console.Write(food.FoodChar);
        }
    }
 }
