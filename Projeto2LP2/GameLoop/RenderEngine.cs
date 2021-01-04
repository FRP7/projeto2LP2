using System;
using System.Collections.Generic;

namespace Projeto2LP2
{
    /// <summary>
    /// Class where the game is rendered.
    /// </summary>
    public class RenderEngine
    {
        /// <summary>
        /// Gets or sets to count the snake's size.
        /// </summary>
        public static int Count { get; set; }

        /// <summary>
        /// Gets cord x of the game's scenario.
        /// </summary>
        public static int GetSceneX { get => Facade.GetSceneX; }

        /// <summary>
        /// Gets cord y of the game's scenario.
        /// </summary>
        public static int GetSceneY { get => Facade.GetSceneY; }

        /// <summary>
        /// Gets cord x of the snake's body.
        /// </summary>
        public static int GetSnakeX { get => Facade.GetCordSnakeX; }

        /// <summary>
        /// Gets cord y of the snake's body.
        /// </summary>
        public static int GetSnakeY { get => Facade.GetCordSnakeY; }

        /// <summary>
        /// Gets the snake's body.
        /// </summary>
        public static List<SnakePart> SnakeBody { get => Facade.GetSnakeBody; }

        /// <summary>
        /// Gets the snake's head.
        /// </summary>
        public static SnakePart Head { get => Facade.GetHead; }

        /// <summary>
        /// Gets the snake's tail.
        /// </summary>
        public static SnakePart Tail { get => Facade.GetTail; }

        /// <summary>
        /// Gets cord x of the Food.
        /// </summary>
        public static int GetFoodX { get => Facade.GetCordFoodX; }

        /// <summary>
        /// Gets cord y of the Food.
        /// </summary>
        public static int GetFoodY { get => Facade.GetCordFoodY; }

        /// <summary>
        /// Gets the score.
        /// </summary>
        public static int GetScore { get => Facade.GetScore; }

        private Facade facade;

        /// <summary>
        /// Render the game.
        /// </summary>
        public void Render() {
            facade = new Facade();
            RenderScene();
            RenderSnake();
            RenderFood();
        }

        /// <summary>
        /// Render the scenario.
        /// </summary>
        private void RenderScene() {
            facade.GameObjects[1].Render();
            if (Facade.GetDirection != Direction.None) {
                Count++;
            }
        }

        /// <summary>
        /// Render the snake.
        /// </summary>
        private void RenderSnake() {
            facade.GameObjects[2].Render();
        }

        /// <summary>
        /// Render the food.
        /// </summary>
        private void RenderFood() {
            facade.GameObjects[0].Render();
        }
    }
}
