using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace Projeto2LP2
{
    /// <summary>
    /// GameObject cobra.
    /// </summary>
    public class SnakeObject : GameObject
    {
        /// <summary>
        /// Corpo da cobra.
        /// </summary>
        public static List<SnakePart> SnakeBody;

        /// <summary>
        /// Gets rabo da cobra.
        /// </summary>
        public static SnakePart Tail { get => SnakeBody[0]; }

        /// <summary>
        /// Gets cabeça da cobra.
        /// </summary>
        public static SnakePart Head { get => SnakeBody.Last(); }

        /// <summary>
        /// Gets or sets coordenada x da cobra.
        /// </summary>
        public static int SnakeX { get; set; }

        /// <summary>
        /// Gets or sets coordenada y da cobra.
        /// </summary>
        public static int SnakeY { get; set; }

        /// <summary>
        /// Direção.
        /// </summary>
        public static Direction SnakeDirection;

        /// <summary>
        /// Método para ser chamado quando o jogo começa.
        /// </summary>
        public override void Start() {
            // Definir a posição inicial da cobra.
            SnakeX = Facade.GetSceneX / 2;
            SnakeY = Facade.GetSceneY / 2;

            // Definir a direção inicial.
            SnakeDirection = Direction.Up;
            Facade.GetDirection = Direction.None;

            // Definir o tamanho da cobra.
            SnakeBody = new List<SnakePart> {
                new SnakePart(SnakeX, SnakeY, '@'),
            };
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
                    Console.SetCursorPosition(
                        Facade.GetCordSnakeX,
                        Facade.GetCordSnakeY);
                    Facade.GetSnakeBody[Facade.GetCount].CordX =
                        Facade.GetCordSnakeX;
                    Facade.GetSnakeBody[Facade.GetCount].CordY =
                        Facade.GetCordSnakeY;
                    Console.Write(Facade.GetSnakeBody[Facade.GetCount].Part);
                } else if (Facade.GetCount > Facade.GetSnakeBody.Count - 1) {
                    Thread.Sleep(500);
                    Console.SetCursorPosition(
                        Facade.GetTail.CordX,
                        Facade.GetTail.CordY);
                    Console.Write(' ');
                    Facade.GetSnakeBody.RemoveAt(0);
                    Facade.GetSnakeBody.Add(new SnakePart(
                        Facade.GetCordSnakeX, Facade.GetCordSnakeY, '@'));
                    Facade.GetCount -= 2;
                }
            }
        }

        /// <summary>
        /// Verificar e atualizar a posição da cobra de acordo com a direção.
        /// </summary>
        private void SnakePositionCheck() {
            if (SnakeDirection == Direction.Up) {
                if (Facade.GetCordSnakeY > 0) {
                    Facade.GetCordSnakeY--;
                }
            } else if (SnakeDirection == Direction.Down) {
                Facade.GetCordSnakeY++;
            } else if (SnakeDirection == Direction.Left) {
                if (GameState.GetCordSnakeX > 0) {
                    Facade.GetCordSnakeX--;
                }
            } else if (SnakeDirection == Direction.Right) {
                Facade.GetCordSnakeX++;
            }
        }

        /// <summary>
        /// Verificar se a cobra colidiu com a comida.
        /// </summary>
        private void CheckFood() {
            if (Facade.GetHead.CordX == Facade.GetCordFoodX &&
                Facade.GetHead.CordY == Facade.GetCordFoodY) {
                Facade.GetSnakeBody.Add(new SnakePart(
                    Facade.GetCordSnakeX, Facade.GetCordSnakeY, '@'));
                Console.SetCursorPosition(
                    Facade.GetCordFoodX,
                    Facade.GetCordFoodY);
                Console.Write(' ');
                FoodObject foodObject = new FoodObject();
                foodObject.Update();
                Facade.GetScore++;
            }
        }

        /// <summary>
        ///  Verificar se a cobra colidiu em si própria.
        /// </summary>
        private void CheckSnakeTouch() {
            for (int i = 3; i < Facade.GetSnakeBody.Count; i++) {
                if (Facade.GetSnakeBody[0].CordX ==
                    Facade.GetSnakeBody[i].CordX &&
                    Facade.GetSnakeBody[0].CordY ==
                    Facade.GetSnakeBody[i].CordY) {
                    Facade.IsGameOver = true;
                }
            }
        }

        /// <summary>
        /// Verificar se a cobra colidiu numa parede.
        /// </summary>
        private void CheckWalls() {
            if (Facade.GetCordSnakeX == 0) {
                Facade.IsGameOver = true;
            }

            if (Facade.GetCordSnakeX == Facade.GetSceneX - 1) {
                Facade.IsGameOver = true;
            }

            if (Facade.GetCordSnakeY == 0) {
                Facade.IsGameOver = true;
            }

            if (Facade.GetCordSnakeY == Facade.GetSceneY - 1) {
                Facade.IsGameOver = true;
            }
        }
    }
}
