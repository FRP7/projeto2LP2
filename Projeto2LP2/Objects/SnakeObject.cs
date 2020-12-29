using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace Projeto2LP2
{
    /// <summary>
    /// GameObject cobra.
    /// </summary>
    class SnakeObject : GameObject
    {
        // Corpo da cobra.
        public static List<SnakePart> snakeBody;

        // Cauda da cobra.
        public static SnakePart Tail { get => snakeBody.First(); }

        // Cabeça da cobra.
        public static SnakePart Head { get => snakeBody.Last(); }

        // Verificar qual a direção atual da cobra.
        public static Direction direction;

        // Recolher informação da posição da cobra.
        public static int SnakeX { get; set; }
        public static int SnakeY { get; set; }

        /// <summary>
        /// Método para ser chamado quando o jogo começa.
        /// </summary>
        public override void Start() {

            // Definir a posição inicial da cobra.
            SnakeX = SceneObject.SceneX / 2;
            SnakeY = SceneObject.SceneY / 2;

            // Definir a direção inicial.
            direction = new Direction();
            direction = Direction.None;

            // Definir o tamanho da cobra.
            snakeBody = new List<SnakePart>();
            snakeBody.Add(new SnakePart(SnakeX, SnakeY, '@'));
        }

        /// <summary>
        /// Método para ser chamado continuamente ao longo do jogo.
        /// </summary>
        public override void Update() {

            // Verificar a posição da cobra.
            SnakePositionCheck();

            // Verificar se a cobra colidiu com a comida.
            CheckFood();

            // Verificar se a cobra colidiu em si própria.
            CheckSnakeTouch();

            // Verificar se a cobra colidiu numa parede.
            CheckWalls();
        }

        /// <summary>
        /// Método onde é renderizado a cobra.
        /// </summary>
        public override void Render() {
            if (Facade.GetCordSnakeX >= 0 && Facade.GetCordSnakeY >= 0) {
                if (Facade.GetCount < Facade.GetSnakeBody.Count) {
                    Thread.Sleep(100);
                    Console.SetCursorPosition(Facade.GetCordSnakeX, 
                        Facade.GetCordSnakeY);
                    Facade.GetSnakeBody[Facade.GetCount].CordX = 
                        Facade.GetCordSnakeX;
                    Facade.GetSnakeBody[Facade.GetCount].CordY = 
                        Facade.GetCordSnakeY;
                    Console.Write(Facade.GetSnakeBody[Facade.GetCount].Part);
                } else if (Facade.GetCount > Facade.GetSnakeBody.Count - 1) {
                    Thread.Sleep(500);
                    Console.SetCursorPosition(Facade.GetTail.CordX, 
                        Facade.GetTail.CordY);
                    Console.Write(' ');
                    Facade.GetSnakeBody.RemoveAt(0);
                    Facade.GetSnakeBody.Add(new SnakePart(Facade.GetCordSnakeX,
                        Facade.GetCordSnakeY, '@'));
                    Facade.GetCount -= 2;
                }
            }
        }

        /// <summary>
        /// Verificar e atualizar a posição da cobra de acordo com a direção.
        /// </summary>
        private void SnakePositionCheck() {
            if (GameState.GetDirection == Direction.Up) {
                if (GameState.GetCordSnakeY > 0) {
                    GameState.GetCordSnakeY--;
                }
            } else if (GameState.GetDirection == Direction.Down) {
                GameState.GetCordSnakeY++;
            } else if (GameState.GetDirection == Direction.Left) {
                if (GameState.GetCordSnakeX > 0) {
                    GameState.GetCordSnakeX--;
                }
            } else if (GameState.GetDirection == Direction.Right) {
                GameState.GetCordSnakeX++;
            }
        }

        /// <summary>
        /// Verificar se a cobra colidiu com a comida.
        /// </summary>
        private void CheckFood() {
            if (GameState.GetHead.CordX == GameState.GetCordFoodX && 
                GameState.GetHead.CordY == GameState.GetCordFoodY) {
                GameState.GetSnakeBody.Add(new SnakePart(
                    GameState.GetCordSnakeX, GameState.GetCordSnakeY, '@'));
                Console.SetCursorPosition(GameState.GetCordFoodX, 
                    GameState.GetCordFoodY);
                Console.Write(' ');
                GameObject foodObject = new FoodObject();
                foodObject.Update();
                Facade.GetScore++;
            }

        }

        /// <summary>
        ///  Verificar se a cobra colidiu em si própria.
        /// </summary>
        private void CheckSnakeTouch() {
            for (int i = 3; i < GameState.GetSnakeBody.Count; i++) {
                if (GameState.GetSnakeBody[0].CordX == 
                    GameState.GetSnakeBody[i].CordX && 
                    GameState.GetSnakeBody[0].CordY ==
                    GameState.GetSnakeBody[i].CordY) {
                    GameLoop.isGameOver = true;
                }
            }

        }

        /// <summary>
        /// Verificar se a cobra colidiu numa parede.
        /// </summary>
        private void CheckWalls() {
            if (GameState.GetCordSnakeX == 0) {
                GameLoop.isGameOver = true;
            }
            if (GameState.GetCordSnakeX == GameState.GetSceneX - 1) {
                GameLoop.isGameOver = true;
            }
            if (GameState.GetCordSnakeY == 0) {
                GameLoop.isGameOver = true;
            }
            if (GameState.GetCordSnakeY == GameState.GetSceneY - 1) {
                GameLoop.isGameOver = true;
            }
        }
    }
}
