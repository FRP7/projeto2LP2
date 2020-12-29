using System;
using System.Threading;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe do ciclo de jogo. 
    /// </summary>
    sealed class GameLoop
    {
        // Recolher informação do teclado definida no UserInput.
        public static ConsoleKey GetKey { get; private set; }

        // Pontuação.
        public static int ScoreValue;

        // Thread do user input.
        private Thread inputThread;

        // Indicar se o jogo acabou.
        public static bool isGameOver;

        //Facade
        private Facade facade;

        /// <summary>
        /// Ciclo de jogo.
        /// </summary>
        public void Game() {

            // Chamado no início do jogo.
            Start();
            // Chamado em todos os frames.
            Update();
        }

        /// <summary>
        /// Método de início do jogo.
        /// </summary>
        private void Start() {

            facade = new Facade();

            // Inicializar bool.
            isGameOver = false;

            // Start do cenário.
            facade.gameObjects[1].Start();

            // Start da cobra.
            facade.gameObjects[2].Start();

            // Star da comida.
            facade.gameObjects[0].Start();

            // Definir o score inicial.
            ScoreValue = 0;

            // Colocar o contador a zero.
            Facade.GetCount = 0;
        }

        /// <summary>
        ///  Método que corre todos os frames.
        /// </summary>
        private void Update() {
            while (isGameOver == false) {

                // Verificar o input do jogador.
                CheckUserInput();

                // Atualizar o estado do jogo.
                GameState();

                // Desenhar o jogo.
                Render();
            }

            // Mostrar o menu de game over caso perca.
            facade.GameOver();
        }

        /// <summary>
        /// Input do jogador.
        /// </summary>
        private void CheckUserInput() {
            // Começar thread para o input do jogador.
            inputThread = new Thread(facade.CheckUserInput);
            inputThread.Start();
            GetKey = facade.consoleKey;
            // Fechar a thread.
            inputThread.Join();
        }

        /// <summary>
        /// Update do estado lógico do jogo.
        /// </summary>
        private void GameState() {
            facade.Update();
        }

        /// <summary>
        /// Renderizar o visual do jogo.
        /// </summary>
        private void Render() {
            facade.Render();
        }
    }
}
