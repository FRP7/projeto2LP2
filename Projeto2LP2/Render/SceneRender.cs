using System;

namespace Projeto2LP2
{
    class SceneRender
    {
        public void RenderScene() {
            RenderMainScene();
        }

        private void RenderMainScene() {
            //linha de cima
            for (int i = 0; i < 35; i++) {
                Console.SetCursorPosition(i, 0);
                Console.WriteLine("_");
            }

            //linha de baixo
            for (int i = 0; i < 35; i++) {
                Console.SetCursorPosition(i, 15);
                Console.WriteLine("_");
            }

            //linha da esquerda
            for (int i = 0; i < 16; i++) {
                Console.SetCursorPosition(0, i);
                Console.WriteLine("|");
            }

            //linha da direita
            for (int i = 0; i < 16; i++) {
                Console.SetCursorPosition(36, i);
                Console.WriteLine("|");
            }

            Console.SetCursorPosition(0, 17);
            Console.WriteLine("Score: ");
            // teste, delete later
            Console.WriteLine($"X: {GameLoop.X}.  Y: {GameLoop.Y}");
        }
    }
}
