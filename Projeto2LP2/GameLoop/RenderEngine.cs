using System;
using System.Collections.Generic;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe onde é renderizado o jogo.
    /// </summary>
    public class RenderEngine
    {
        // Contar o tamanho da cobra.
        public static int count = 0;

        // Aceder à coordenada X do cenário no GameLoop.
        public static int GetSceneX { get => Facade.GetSceneX; }

        // Aceder à coordenada Y do cenário no GameLoop.
        public static int GetSceneY { get => Facade.GetSceneY; }

        // Aceder à coordenada X da cobra no GameLoop.
        public static int GetSnakeX { get => Facade.GetCordSnakeX; }

        // Aceder à coordenada Y da cobra no GameLoop.
        public static int GetSnakeY { get => Facade.GetCordSnakeY; }

        // Aceder ao corpo da cobra no GameLoop.
        public static List<SnakePart> SnakeBody { get => Facade.GetSnakeBody; }

        // Aceder à cabeça da cobra no GameLoop.
        public static SnakePart Head { get => Facade.GetHead; }

        // Aceder à cauda da cobra no GameLoop.
        public static SnakePart Tail { get => Facade.GetTail; }

        // Aceder à coordenada X da comida no GameLoop.
        public static int GetFoodX { get => Facade.GetCordFoodX; }

        // Aceder à coordenada Y da comida no GameLoop.
        public static int GetFoodY { get => Facade.GetCordFoodY; }

        // Aceder à pontuação no GameLoop.
        public static int GetScore { get => Facade.GetScore; }

        private Facade facade;

        /// <summary>
        /// Renderizar o jogo.
        /// </summary>
        public void Render() {
            facade = new Facade();
            RenderScene();
            RenderSnake();
            RenderFood();
        }

        /// <summary>
        /// Renderizar o cenário.
        /// </summary>
        private void RenderScene() {
            facade.GameObjects[1].Render();
            if(Facade.GetDirection != Direction.None) {
                count++;
            }
        }

        /// <summary>
        /// Renderizar a cobra.
        /// </summary>
        private void RenderSnake() {
            facade.GameObjects[2].Render();
        }

        /// <summary>
        /// Renderizar a comida.
        /// </summary>
        private void RenderFood() {
            facade.GameObjects[0].Render();
        }
    }
}
