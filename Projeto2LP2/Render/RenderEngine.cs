using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe onde é renderizado o jogo.
    /// </summary>
    class RenderEngine
    {
        // Contar o tamanho da cobra.
        public static int count = 0;

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
