using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Aqui é o ciclo de jogo. 
    /// </summary>
    class GameLoop
    {
        // Recolher informação do teclado.
        public static ConsoleKey GetKey { get; private set; }

        // Recolher informação da posição da cobra.
        public static int X { get; set; }
        public static int Y { get; set; }

        // Aqui é onde é chamado tudo no jogo
        public void Game() {
            while (true) {
                CheckUserInput();
                Update();
                Render();
            }
        }

        private void CheckUserInput() {
            UserInput userInput = new UserInput();
            userInput.CheckUserInput();
            GetKey = userInput.Key;
        }

        private void Update() {
            GameState gameState = new GameState();
            gameState.Update();
        }

        private void Render() {
            RenderEngine render = new RenderEngine();
            render.Render();
        }

        public GameLoop() {
            X = 15;
            Y = 7;
        }
    }
}
