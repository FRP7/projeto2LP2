using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Aqui é o ciclo de jogo. 
    /// </summary>
    class GameLoop
    {
        // Aqui é onde é chamado tudo no jogo
        public void Game() {
           while(true) {
                CheckUserInput();
                Update();
                Render();
            }
        }

        private void CheckUserInput() {

        }

        private void Update() {
            GameState gameState = new GameState();
            gameState.Update();
        }

        private void Render() {
            RenderEngine render = new RenderEngine();
            render.Render();
        }
    }
}
