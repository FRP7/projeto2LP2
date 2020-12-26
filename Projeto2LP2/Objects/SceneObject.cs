using System;

namespace Projeto2LP2
{
    class SceneObject : GameObject
    {
        // Definir o tamanho do cenário.
        public static int SceneX { get; private set; }
        public static int SceneY { get; private set; }

        public override void Start() {
            SceneX = 35;
            SceneY = 16;
        }

        public override void Update() {

        }

        /// <summary>
        /// Método onde é renderizado o cenário.
        /// </summary>
        public override void Render() {
                // Linha de cima
                for (int i = 0; i < RenderEngine.GetSceneX; i++) {
                    Console.SetCursorPosition(i, 0);
                    Console.WriteLine("_");
                }

                // Linha de baixo.
                for (int i = 0; i < RenderEngine.GetSceneX; i++) {
                    Console.SetCursorPosition(i, RenderEngine.GetSceneY - 1);
                    Console.WriteLine("_");
                }

                // Linha da esquerda.
                for (int i = 0; i < RenderEngine.GetSceneY; i++) {
                    Console.SetCursorPosition(0, i);
                    Console.WriteLine("|");
                }

                // Linha da direita.
                for (int i = 0; i < RenderEngine.GetSceneY; i++) {
                    Console.SetCursorPosition(RenderEngine.GetSceneX, i);
                    Console.WriteLine("|");
                }

                // Pontuação.
                Console.SetCursorPosition(0, RenderEngine.GetSceneY + 1);
                Console.WriteLine("Score: " + RenderEngine.GetScore);
        }
    }
}
