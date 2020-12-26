using System;
using System.Threading;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe do ciclo de jogo. 
    /// Funciona como um Facade também.
    /// </summary>
    class GameLoop
    {
        // Recolher informação do teclado definida no UserInput.
        public static ConsoleKey GetKey { get; private set; }

        // Pontuação.
        public static int ScoreValue;

        // Thread do user input.
        private Thread inputThread;

        // Menu de game over.
        private GameOver gameOver;

        // Indicar se o jogo acabou.
        public static bool isGameOver;

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

            // Inicializar o GameOver.
            gameOver = new GameOver();

            // Inicializar bool.
            isGameOver = false;

            // Start do cenário.
            GameObject sceneObject = new SceneObject();
            sceneObject.Start();

            // Start da cobra.
            GameObject snakeObject = new SnakeObject();
            snakeObject.Start();

            // Star da comida.
            GameObject foodObject = new FoodObject();
            foodObject.Start();

            // Definir o score inicial.
            ScoreValue = 0;

            // Colocar o contador a zero.
            RenderEngine.count = 0;
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
            gameOver.GameOverMenu();
        }

        /// <summary>
        /// Input do jogador.
        /// </summary>
        private void CheckUserInput() {
            UserInput userInput = new UserInput();
            // Começar thread para o input do jogador.
            inputThread = new Thread(userInput.CheckUserInput);
            inputThread.Start();
            GetKey = userInput.Key;
            // Fechar a thread.
            inputThread.Join();
        }

        /// <summary>
        /// Update do estado lógico do jogo.
        /// </summary>
        private void GameState() {
            GameState gameState = new GameState();
            gameState.Update();
        }

        /// <summary>
        /// Renderizar o visual do jogo.
        /// </summary>
        private void Render() {
            RenderEngine render = new RenderEngine();
            render.Render();
        }
    }
}
