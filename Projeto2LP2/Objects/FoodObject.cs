using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Food GameObject.
    /// </summary>
    public class FoodObject : GameObject
    {
        /// <summary>
        /// Gets or sets cord x of the Food.
        /// </summary>
        public static int FoodX { get; set; }

        /// <summary>
        /// Gets or sets cord y of the Food.
        /// </summary>
        public static int FoodY { get; set; }

        /// <summary>
        /// Method to be called when the game begins.
        /// </summary>
        public override void Start() {
            // Set the first Food position.
            FoodX = (Facade.GetSceneX / 2) - 5;
            FoodY = (Facade.GetSceneY / 2) - 5;
        }

        /// <summary>
        /// Method to be called the whole time during the game session.
        /// </summary>
        public override void Update() {
            Random random = new Random();

            Facade.GetCordFoodX = random.Next(2, Facade.GetSceneX - 2);
            Facade.GetCordFoodY = random.Next(2, Facade.GetSceneY - 2);
        }

        /// <summary>
        /// Method where the Food is rendered.
        /// </summary>
        public override void Render() {
            Console.SetCursorPosition(Facade.GetCordFoodX, Facade.GetCordFoodY);
            Food food = new Food(Facade.GetCordFoodX, Facade.GetCordFoodY, '$');
            Console.Write(food.FoodChar);
        }
    }
}
