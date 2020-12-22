using System;
using System.Collections.Generic;
using System.Linq;
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

        // Definir o tamanho do cenário.
        public static int SceneX = 35;
        public static int SceneY = 16;

        // Recolher informação da posição da cobra.
        public static int SnakeX { get; set; }
        public static int SnakeY { get; set; }

        // Recolher informação da posição da comida.
        public static int FoodX { get; set; }
        public static int FoodY { get; set; }

        // Verificar qual a direção atual da cobra.
        public static Direction direction;

        // Corpo da cobra.
        public static List<SnakePart> snakeBody;
        public static SnakePart Tail { get => snakeBody.First(); }
        public static SnakePart Head { get => snakeBody.Last(); }

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

        // Método de início do jogo.
        private void Start() {

            // Inicializar o GameOver.
            gameOver = new GameOver();

            // Inicializar bool.
            isGameOver = false;

            // Definir a posição inicial da cobra.
            SnakeX = SceneX / 2;
            SnakeY = SceneY / 2;

            // Definir a direção inicial.
            direction = new Direction();
            direction = Direction.None;

            // Definir o tamanho da cobra.
            snakeBody = new List<SnakePart>();
            snakeBody.Add(new SnakePart(SnakeX, SnakeY, '@'));

            // Definir a posição da comida inicial.
            FoodX = (SceneX / 2) - 5;
            FoodY = (SceneY / 2) - 5;

            // Definir o score inicial.
            ScoreValue = 0;

            // Colocar o contador a zero.
            RenderEngine.count = 0;
        }

        // Método que corre todos os frames.
        private void Update() {
            while (isGameOver == false) {
                // Verificar o input do jogador.
                CheckUserInput();
                // Atualizar o estado do jogo.
                GameState();
                // Desenhar o jogo.
                Render();
            }
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
            GetKey = userInput.inputKey;
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
