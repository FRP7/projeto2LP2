using System;
using System.Collections.Generic;
namespace Projeto2LP2
{
    /// <summary>
    /// Class where the game logic is updated.
    /// </summary>
    public class GameState
    {
        /// <summary>
        /// Gets cord x of the game's scenario.
        /// </summary>
        public static int GetSceneX { get => Facade.GetSceneX; }

        /// <summary>
        /// Gets cord y of the game's scenario.
        /// </summary>
        public static int GetSceneY { get => Facade.GetSceneY; }

        /// <summary>
        /// Gets or sets the snake's body.
        /// </summary>
        public static List<SnakePart> GetSnakeBody
        {
            get
            {
                return Facade.GetSnakeBody;
            }
            set
            {
                Facade.GetSnakeBody = value;
            }
        }

        /// <summary>
        /// Gets or sets the cord x of the snake.
        /// </summary>
        public static int GetCordSnakeX
        {
            get
            {
                return Facade.GetCordSnakeX;
            }
            set
            {
                Facade.GetCordSnakeX = value;
            }
        }

        /// <summary>
        /// Gets or sets the cord y of the snake.
        /// </summary>
        public static int GetCordSnakeY
        {
            get
            {
                return Facade.GetCordSnakeY;
            }
            set
            {
                Facade.GetCordSnakeY = value;
            }
        }

        /// <summary>
        /// Gets the snake's head.
        /// </summary>
        public static SnakePart GetHead {
            get {
                return Facade.GetHead;
            }
        }

        /// <summary>
        /// Gets the snake's tail.
        /// </summary>
        public static SnakePart GetTail {
            get {
                return Facade.GetTail;
            }
        }

        /// <summary>
        /// Gets the snake's direction.
        /// </summary>
        public static Direction GetDirection { get => Facade.GetDirection; }

        /// <summary>
        /// Gets or sets the cord x of the Food.
        /// </summary>
        public static int GetCordFoodX
        {
            get
            {
                return Facade.GetCordFoodX;
            }
            set
            {
                Facade.GetCordFoodX = value;
            }
        }

        /// <summary>
        /// Gets or sets the cord y of the Food.
        /// </summary>
        public static int GetCordFoodY
        {
            get
            {
                return Facade.GetCordFoodY;
            }
            set
            {
                Facade.GetCordFoodY = value;
            }
        }

        /// <summary>
        /// Gets the score.
        /// </summary>
        public static int GetScore
        {
            get
            {
                return Facade.GetScore;
            }
        }

        /// <summary>
        /// Update the game logic.
        /// </summary>
        public void Update()
        {
            SnakeUpdate();
        }

        /// <summary>
        /// Update the snake.
        /// </summary>
        private void SnakeUpdate()
        {
            Facade facade = new Facade();
            facade.GameObjects[2].Update();
        }
    }
}
