using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Aqui é onde é desenhado no ecrã as cenas.
    /// </summary>
    class RenderEngine
    {
        public static int count = 0;
        public void Render() {
            RenderScene();
            RenderSnake();
            RenderFood();
        }

        private void RenderScene() {
            SceneRender sceneRander = new SceneRender();
            sceneRander.RenderScene();
            if(GameLoop.direction != Direction.None) {
                count++;
            }
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
