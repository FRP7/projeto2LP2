using System;
using System.Collections.Generic;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe onde é renderizado o jogo.
    /// </summary>
    public class RenderEngine
    {
        /// <summary>
        /// Contar o tamanho da cobra.
        /// </summary>
        public static int count = 0;

        /// <summary>
        /// Gets coordenada X do cenário no GameLoop.
        /// </summary>
        public static int GetSceneX { get => Facade.GetSceneX; }

        /// <summary>
        /// Gets coordenada Y do cenário no GameLoop.
        /// </summary>
        public static int GetSceneY { get => Facade.GetSceneY; }

        /// <summary>
        /// Gets coordenada X da cobra no GameLoop.
        /// </summary>
        public static int GetSnakeX { get => Facade.GetCordSnakeX; }

        /// <summary>
        /// Gets coordenada y da cobra.
        /// </summary>
        public static int GetSnakeY { get => Facade.GetCordSnakeY; }

        /// <summary>
        /// Gets corpo da cobra.
        /// </summary>
        public static List<SnakePart> SnakeBody { get => Facade.GetSnakeBody; }

        /// <summary>
        /// Gets cabeça da cobra no GameLoop.
        /// </summary>
        public static SnakePart Head { get => Facade.GetHead; }

        /// <summary>
        /// Gets cauda da cobra no GameLoop.
        /// </summary>
        public static SnakePart Tail { get => Facade.GetTail; }

        /// <summary>
        /// Gets coordenada X da comida no GameLoop.
        /// </summary>
        public static int GetFoodX { get => Facade.GetCordFoodX; }

        /// <summary>
        /// Gets coordenada Y da comida no GameLoop.
        /// </summary>
        public static int GetFoodY { get => Facade.GetCordFoodY; }

        /// <summary>
        /// Gets pontuação no GameLoop.
        /// </summary>
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
