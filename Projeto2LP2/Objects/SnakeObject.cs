using System;
using System.Threading;
using System.Collections.Generic;
using System.Linq;

namespace Projeto2LP2
{
    /// <summary>
    /// Snake GameObject.
    /// </summary>
    public class SnakeObject : GameObject
    {
        /// <summary>
        /// Gets or sets the snake body.
        /// </summary>
        public static List<SnakePart> SnakeBody { get; set; }

        /// <summary>
        /// Gets the snake tail.
        /// </summary>
        public static SnakePart Tail { get => SnakeBody[0]; }

        /// <summary>
        /// Gets the snake head.
        /// </summary>
        public static SnakePart Head { get => SnakeBody.Last(); }

        /// <summary>
        /// Gets or sets the cord x of snake.
        /// </summary>
        public static int SnakeX { get; set; }

        /// <summary>
        /// Gets or sets the cord y of snake.
        /// </summary>
        public static int SnakeY { get; set; }

        /// <summary>
        /// Gets or sets the current direction..
        /// </summary>
        public static Direction SnakeDirection { get; set; }

        /// <summary>
        /// Method to be called when the game starts.
        /// </summary>
        public override void Start() {
            // Sets the initial position of the snake.
            SnakeX = Facade.GetSceneX / 2;
            SnakeY = Facade.GetSceneY / 2;

            // Sets the initial direction.
            SnakeDirection = Direction.None;
            Facade.GetDirection = Direction.None;

            // Set the snake body.
            SnakeBody = new List<SnakePart> {
                new SnakePart(SnakeX, SnakeY, '@'),
            };
        }

        /// <summary>
        /// Method to be called all the time during the whole game session.
        /// </summary>
        public override void Update() {
            // Check the snake's position.
            SnakePositionCheck();

            // Check if the snake collided with the food.
            CheckFood();

            // Check if the snake collided with itself.
            CheckSnakeTouch();

            // Check if the snake collided with the wall.
            CheckWalls();
        }

        /// <summary>
        /// Method where the snake is rendered.
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
        /// Check and update the snake's position according to the direction.
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
        /// Check if the snake collided with the food.
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
        /// Check if the snake collided with itself.
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
        /// Check if the snake collided with the wall.
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
