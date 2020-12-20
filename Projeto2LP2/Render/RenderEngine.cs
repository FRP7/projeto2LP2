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

        // Aceder à coordenada X da cobra no GameLoop.
        public static int GetSnakeX { get => GameLoop.SnakeX; }

        // Aceder à coordenada Y da cobra no GameLoop.
        public static int GetSnakeY { get => GameLoop.SnakeY; }

        // Aceder ao corpo da cobra no GameLoop.
        public static List<SnakePart> SnakeBody { get => GameLoop.snakeBody; }

        // Aceder à cabeça da cobra no GameLoop.
        public static SnakePart Head { get => GameLoop.Head; }

        // Aceder à cauda da cobra no GameLoop.
        public static SnakePart Tail { get => GameLoop.Tail; }

        /// <summary>
        /// Renderizar.
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
            SceneRender sceneRander = new SceneRender();
            sceneRander.RenderScene();
            if(GameLoop.direction != Direction.None) {
                count++;
            }
        }

        /// <summary>
        /// Renderizar a cobra.
        /// </summary>
        private void RenderSnake() {
            SnakeRender snakeRender = new SnakeRender();
            snakeRender.RenderSnake();
        }

        /// <summary>
        /// Renderizar a comida.
        /// </summary>
        private void RenderFood() {
            FoodRender foodRender = new FoodRender();
            foodRender.RenderFood();
        }
    }
}
