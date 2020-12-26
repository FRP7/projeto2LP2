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
            FoodX = (SceneObject.SceneX / 2) - 5;
            FoodY = (SceneObject.SceneY / 2) - 5;
        }

        public override void Update() {
            random = new Random();

            GameState.GetCordFoodX = random.Next(2, GameState.GetSceneX - 2);
            GameState.GetCordFoodY = random.Next(2, GameState.GetSceneY - 2);
        }

        public override void Render() {
            Console.SetCursorPosition(RenderEngine.GetFoodX, RenderEngine.GetFoodY);
            Food food = new Food(RenderEngine.GetFoodX, RenderEngine.GetFoodY, '$');
            Console.Write(food.FoodChar);
        }
    }
}
