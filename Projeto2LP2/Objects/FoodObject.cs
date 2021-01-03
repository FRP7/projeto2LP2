using System;

namespace Projeto2LP2
{
    /// <summary>
    /// GameObject da comida.
    /// </summary>
    public class FoodObject : GameObject
    {
        /// <summary>
        /// Gets or sets coordenada x da comida.
        /// </summary>
        public static int FoodX { get; set; }

        /// <summary>
        /// Gets or sets coordenada y da comida.
        /// </summary>
        public static int FoodY { get; set; }

        /// <summary>
        /// Método para ser chamado quando o jogo começa.
        /// </summary>
        public override void Start() {
            // Definir a posição da comida inicial.
            FoodX = (Facade.GetSceneX / 2) - 5;
            FoodY = (Facade.GetSceneY / 2) - 5;
        }

        /// <summary>
        /// Método para ser chamado continuamente ao longo do jogo.
        /// </summary>
        public override void Update() {
            Random random = new Random();

            Facade.GetCordFoodX = random.Next(2, Facade.GetSceneX - 2);
            Facade.GetCordFoodY = random.Next(2, Facade.GetSceneY - 2);
        }

        /// <summary>
        /// Método de renderização.
        /// </summary>
        public override void Render() {
            Console.SetCursorPosition(Facade.GetCordFoodX, Facade.GetCordFoodY);
            Food food = new Food(Facade.GetCordFoodX, Facade.GetCordFoodY, '$');
            Console.Write(food.FoodChar);
        }
    }
}
