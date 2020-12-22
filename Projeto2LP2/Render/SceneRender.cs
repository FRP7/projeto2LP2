using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe onde é renderizada o cenário.
    /// </summary>
    class SceneRender
    {
        /// <summary>
        /// Método onde é chamado o renderizador do cenário.
        /// </summary>
        public void RenderScene() {
            RenderMainScene();
        }

        /// <summary>
        /// Método onde é renderizado o cenário.
        /// </summary>
        private void RenderMainScene() {

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
