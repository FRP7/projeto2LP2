using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe onde é renderizada o cenário.
    /// </summary>
    class SceneRender
    {
        /// <summary>
        /// Método onde é renderizado o cenário.
        /// </summary>
        public void RenderScene() {
            RenderMainScene();
        }

        /// <summary>
        /// Método onde é renderizado o cenário.
        /// </summary>
        private void RenderMainScene() {
            // Linha de cima
            for (int i = 0; i < 35; i++) {
                Console.SetCursorPosition(i, 0);
                Console.WriteLine("_");
            }

            // Linha de baixo.
            for (int i = 0; i < 35; i++) {
                Console.SetCursorPosition(i, 15);
                Console.WriteLine("_");
            }

            // Linha da esquerda.
            for (int i = 0; i < 16; i++) {
                Console.SetCursorPosition(0, i);
                Console.WriteLine("|");
            }

            // Linha da direita.
            for (int i = 0; i < 16; i++) {
                Console.SetCursorPosition(36, i);
                Console.WriteLine("|");
            }

            // Pontuação.
            Console.SetCursorPosition(0, 17);
            Console.WriteLine("Score: ");
            // teste, delete later
            Console.WriteLine($"SnakeX: {RenderEngine.GetSnakeX}.  SnakeY: {RenderEngine.GetSnakeY}");
        }
    }
}
