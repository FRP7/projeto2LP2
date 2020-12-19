using System;
using System.Collections.Generic;
using System.Linq;

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
        public static int SnakeX { get; set; }
        public static int SnakeY { get; set; }

        public static Direction direction;

        public static List<SnakePart> snakeBody;
        public static SnakePart Tail { get => snakeBody.First(); }
        public static SnakePart Head { get => snakeBody.Last(); }

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
            SnakeX = 15;
            SnakeY = 7;
            direction = new Direction();
            direction = Direction.None;
            snakeBody = new List<SnakePart>();
            snakeBody.Add(new SnakePart(SnakeX, SnakeY, '@'));
            snakeBody.Add(new SnakePart(SnakeX, SnakeY, '@'));
            snakeBody.Add(new SnakePart(SnakeX, SnakeY, '@'));
            snakeBody.Add(new SnakePart(SnakeX, SnakeY, '@'));
            snakeBody.Add(new SnakePart(SnakeX, SnakeY, '@'));
            snakeBody.Add(new SnakePart(SnakeX, SnakeY, '@'));
        }
    }
}
