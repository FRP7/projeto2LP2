using System;

namespace Projeto2LP2
{
    class FoodObject : GameObject
    {
        private Random random;

        // Recolher informação da posição da comida.
        public static int FoodX { get; set; }
        public static int FoodY { get; set; }

        public override void Start() {
            // Definir a posição da comida inicial.
            FoodX = (Facade.GetSceneX / 2) - 5;
            FoodY = (Facade.GetSceneY / 2) - 5;
        }

        public override void Update() {
            random = new Random();

            Facade.GetCordFoodX = random.Next(2, Facade.GetSceneX - 2);
            Facade.GetCordFoodY = random.Next(2, Facade.GetSceneY - 2);
        }

        public override void Render() {
            Console.SetCursorPosition(Facade.GetCordFoodX, Facade.GetCordFoodY);
            Food food = new Food(Facade.GetCordFoodX, Facade.GetCordFoodY, '$');
            Console.Write(food.FoodChar);
        }
    }
}
