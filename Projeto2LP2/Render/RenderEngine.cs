using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Aqui é onde é desenhado no ecrã as cenas.
    /// </summary>
    class RenderEngine
    {
        public void Render() {
            RenderScene();
            RenderSnake();
            RenderFood();
        }

        private void RenderScene() {
            SceneRender sceneRander = new SceneRender();
            sceneRander.RenderScene();
        }

        private void RenderSnake() {
            SnakeRender snakeRender = new SnakeRender();
            snakeRender.RenderSnake();
        }

        private void RenderFood() {
            FoodRender foodRender = new FoodRender();
            foodRender.RenderFood();
        }
    }
}
