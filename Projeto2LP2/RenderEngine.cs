using System;
using System.Collections.Generic;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe onde é renderizado o jogo.
    /// </summary>
    class RenderEngine
    {
        // Contar o tamanho da cobra.
        public static int count = 0;

        // Aceder à coordenada X do cenário no GameLoop.
        public static int GetSceneX { get => SceneObject.SceneX; }

        // Aceder à coordenada Y do cenário no GameLoop.
        public static int GetSceneY { get => SceneObject.SceneY; }

        // Aceder à coordenada X da cobra no GameLoop.
        public static int GetSnakeX { get => SnakeObject.SnakeX; }

        // Aceder à coordenada Y da cobra no GameLoop.
        public static int GetSnakeY { get => SnakeObject.SnakeY; }

        // Aceder ao corpo da cobra no GameLoop.
        public static List<SnakePart> SnakeBody { get => SnakeObject.snakeBody; }

        // Aceder à cabeça da cobra no GameLoop.
        public static SnakePart Head { get => SnakeObject.Head; }

        // Aceder à cauda da cobra no GameLoop.
        public static SnakePart Tail { get => SnakeObject.Tail; }

        // Aceder à coordenada X da comida no GameLoop.
        public static int GetFoodX { get => FoodObject.FoodX; }

        // Aceder à coordenada Y da comida no GameLoop.
        public static int GetFoodY { get => FoodObject.FoodY; }

        // Aceder à pontuação no GameLoop.
        public static int GetScore { get => GameLoop.ScoreValue; }

        /// <summary>
        /// Renderizar o jogo.
        /// </summary>
        public void Render() {
            RenderScene();
            RenderSnake();
            RenderFood();
        }

        /// <summary>
        /// Renderizar o cenário.
        /// </summary>
        private void RenderScene() {
            GameObject sceneObject = new SceneObject();
            sceneObject.Render();
            if(SnakeObject.direction != Direction.None) {
                count++;
            }
        }

        /// <summary>
        /// Renderizar a cobra.
        /// </summary>
        private void RenderSnake() {
            GameObject snakeObject = new SnakeObject();
            snakeObject.Render();
        }

        /// <summary>
        /// Renderizar a comida.
        /// </summary>
        private void RenderFood() {
            GameObject foodObject = new FoodObject();
            foodObject.Render();
        }
    }
}
