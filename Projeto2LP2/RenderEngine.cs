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

        // Array de GameObjects.
        private GameObject[] gameObjects;

        /// <summary>
        /// Renderizar o jogo.
        /// </summary>
        public void Render() {

            gameObjects = new GameObject[3];
            gameObjects[0] = new FoodObject();
            gameObjects[1] = new SceneObject();
            gameObjects[2] = new SnakeObject();

            RenderScene();
            RenderSnake();
            RenderFood();
        }

        /// <summary>
        /// Renderizar o cenário.
        /// </summary>
        private void RenderScene() {
            gameObjects[1].Render();
            if(SnakeObject.direction != Direction.None) {
                count++;
            }
        }

        /// <summary>
        /// Renderizar a cobra.
        /// </summary>
        private void RenderSnake() {
            gameObjects[2].Render();
        }

        /// <summary>
        /// Renderizar a comida.
        /// </summary>
        private void RenderFood() {
            gameObjects[0].Render();
        }
    }
}
