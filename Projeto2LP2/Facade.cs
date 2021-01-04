using System;
using System.Collections.Generic;

namespace Projeto2LP2
{
    /// <summary>
    /// Facade class that tries to keep the general code more organized.
    /// </summary>
    public class Facade
    {
        /// <summary>
        /// Gets cord x from the game scenario.
        /// </summary>
        public static int GetSceneX { get => SceneObject.SceneX; }

        /// <summary>
        /// Gets cord y from the game scenario.
        /// </summary>
        public static int GetSceneY { get => SceneObject.SceneY; }

        /// <summary>
        /// Gets or sets a value indicating whether the game is lost.
        /// </summary>
        public static bool IsGameOver
        {
            get
            {
                return GameLoop.IsGameOver;
            }
            set
            {
                GameLoop.IsGameOver = value;
            }
        }

        /// <summary>
        /// Gets or sets the body of the Snake.
        /// </summary>
        public static List<SnakePart> GetSnakeBody
        {
            get
            {
                return SnakeObject.SnakeBody;
            }
            set
            {
                SnakeObject.SnakeBody = value;
            }
        }

        /// <summary>
        /// Gets or sets the cord x of the Snake's body.
        /// </summary>
        public static int GetCordSnakeX
        {
            get
            {
                return SnakeObject.SnakeX;
            }
            set
            {
                SnakeObject.SnakeX = value;
            }
        }

        /// <summary>
        /// Gets or sets the cord y of the Snake's body.
        /// </summary>
        public static int GetCordSnakeY
        {
            get
            {
                return SnakeObject.SnakeY;
            }
            set
            {
                SnakeObject.SnakeY = value;
            }
        }

        /// <summary>
        /// Gets the Snake's head.
        /// </summary>
        public static SnakePart GetHead { get => SnakeObject.Head; }

        /// <summary>
        /// Gets the Snake's tail.
        /// </summary>
        public static SnakePart GetTail { get => SnakeObject.Tail; }

        /// <summary>
        /// Gets or sets the Snake's current direction.
        /// </summary>
        public static Direction GetDirection
        {
            get
            {
                return SnakeObject.SnakeDirection;
            }
            set
            {
                SnakeObject.SnakeDirection = value;
            }
        }

        /// <summary>
        /// Gets or sets the cord x of the Food.
        /// </summary>
        public static int GetCordFoodX
        {
            get
            {
                return FoodObject.FoodX;
            }
            set
            {
                FoodObject.FoodX = value;
            }
        }

        /// <summary>
        /// Gets or sets the cord y of the Food.
        /// </summary>
        public static int GetCordFoodY
        {
            get
            {
                return FoodObject.FoodY;
            }
            set
            {
                FoodObject.FoodY = value;
            }
        }

        /// <summary>
        /// Gets or sets the Snake size.
        /// </summary>
        public static int GetCount
        {
            get
            {
                return RenderEngine.Count;
            }
            set
            {
                RenderEngine.Count = value;
            }
        }

        /// <summary>
        /// Gets or sets the Score.
        /// </summary>
        public static int GetScore
        {
            get
            {
                return GameLoop.ScoreValue;
            }
            set
            {
                GameLoop.ScoreValue = value;
            }
        }

        // Access UserInput.
        private readonly UserInput userInput;

        // Access GameState.
        private readonly GameState gameState;

        // Access RenderEngine.
        private readonly RenderEngine renderEngine;

        /// <summary>
        /// Gets the player input.
        /// </summary>
        public ConsoleKey ConsoleKey { get => userInput.GetKey; }

        /// <summary>
        /// Calls the method CheckUserInput from UserInput class.
        /// </summary>
        public void CheckUserInput()
        {
            userInput.CheckUserInput();
        }

        /// <summary>
        /// Calls the Update method from GameState class.
        /// </summary>
        public void Update()
        {
            gameState.Update();
        }

        /// <summary>
        /// Calls the Render method from RenderEngine class.
        /// </summary>
        public void Render()
        {
            renderEngine.Render();
        }

        /// <summary>
        /// Calls the MainMenu method from Menu class.
        /// </summary>
        /// <param name="x"> Check if intro can be run. </param>
        /// <param name="y"> Check if splashscreen can be run. </param>
        public void Menu(bool x, bool y)
        {
            Menu menu = new Menu();
            menu.MainMenu(x, y);
        }

        /// <summary>
        /// Call GameOverMenu method from GameOver class.
        /// </summary>
        public void GameOver()
        {
            GameOver gameOver = new GameOver();
            gameOver.GameOverMenu();
        }

        /// <summary>
        /// Array of GameObjects.
        /// </summary>
        private readonly GameObject[] gameObjects =
        {
            new FoodObject(),
            new SceneObject(),
            new SnakeObject(),
        };

        /// <summary>
        /// Gets GameObjects.
        /// </summary>
        public GameObject[] GameObjects { get => gameObjects; }

        /// <summary>
        /// Initialize variables.
        /// </summary>
        public Facade()
        {
            userInput = new UserInput();
            gameState = new GameState();
            renderEngine = new RenderEngine();
        }
    }
}
