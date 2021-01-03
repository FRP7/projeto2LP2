using System;

namespace Projeto2LP2
{
    /// <summary>
    /// GameObject do cenário.
    /// </summary>
    public class SceneObject : GameObject
    {
        // Tamanho do cenário.
        public static int SceneX { get; private set; }
        public static int SceneY { get; private set; }

        /// <summary>
        /// Método para ser chamado quando o jogo começa.
        /// </summary>
        public override void Start() {
            // Definir o tamanho do cenário.
            SceneX = 35;
            SceneY = 16;
        }

        /// <summary>
        /// Método para ser chamado continuamente ao longo do jogo.
        /// </summary>
        public override void Update() {
        }

        /// <summary>
        /// Método onde é renderizado o cenário.
        /// </summary>
        public override void Render() {
                // Linha de cima
                for (int i = 0; i < Facade.GetSceneX; i++) {
                    Console.SetCursorPosition(i, 0);
                    Console.WriteLine("_");
                }

                // Linha de baixo.
                for (int i = 0; i < Facade.GetSceneX; i++) {
                    Console.SetCursorPosition(i, Facade.GetSceneY - 1);
                    Console.WriteLine("_");
                }

                // Linha da esquerda.
                for (int i = 0; i < Facade.GetSceneY; i++) {
                    Console.SetCursorPosition(0, i);
                    Console.WriteLine("|");
                }

                // Linha da direita.
                for (int i = 0; i < Facade.GetSceneY; i++) {
                    Console.SetCursorPosition(Facade.GetSceneX, i);
                    Console.WriteLine("|");
                }

                // Pontuação.
                Console.SetCursorPosition(0, Facade.GetSceneY + 1);
                Console.WriteLine("Score: " + Facade.GetScore);
        }
    }
}
