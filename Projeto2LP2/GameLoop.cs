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

        // Recolher informação da posição da cobra.
        public static int SnakeX { get; set; }
        public static int SnakeY { get; set; }

        public static int FoodX { get; set; }
        public static int FoodY { get; set; }

        // Verificar qual a direção atual da cobra.
        public static Direction direction;

        // Corpo da cobra.
        public static List<SnakePart> snakeBody;
        public static SnakePart Tail { get => snakeBody.First(); }
        public static SnakePart Head { get => snakeBody.Last(); }

        //SCORE.
        public static int ScoreValue;

        //public static bool CanSpawnFood.
        //public static bool CanSpawnFood;


        // Thread do user input.
        Thread inputThread;

        /// <summary>
        /// Ciclo de jogo.
        /// </summary>
        public void Game() {
            //START
            FoodPosition foodPosition = new FoodPosition();
            foodPosition.FoodPositionCheck();
            FoodRender foodRender = new FoodRender();
            foodRender.RenderFood();
            ScoreValue = 0;
            //UPDATE
            while (true) {
                CheckUserInput();
                Update();
                Render();
            }
        }

        /// <summary>
        /// Input do jogador.
        /// </summary>
        private void CheckUserInput() {
            UserInput userInput = new UserInput();
            inputThread = new Thread(userInput.CheckUserInput);
            inputThread.Start();
            GetKey = userInput.Key;
            inputThread.Join();
        }

        /// <summary>
        /// Update do estado lógico do jogo.
        /// </summary>
        private void Update() {
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

        /// <summary>
        /// Inicializar as variáveis.
        /// </summary>
        public GameLoop() {
            SnakeX = 15;
            SnakeY = 7;
            direction = new Direction();
            direction = Direction.None;
            snakeBody = new List<SnakePart>();
            snakeBody.Add(new SnakePart(SnakeX, SnakeY, '@'));
            //snakeBody.Add(new SnakePart(SnakeX, SnakeY, '@'));
            //snakeBody.Add(new SnakePart(SnakeX, SnakeY, '@'));
            //snakeBody.Add(new SnakePart(SnakeX, SnakeY, '@'));
            //snakeBody.Add(new SnakePart(SnakeX, SnakeY, '@'));
            //snakeBody.Add(new SnakePart(SnakeX, SnakeY, '@'));
        }
    }
}
