using System;
using System.Threading;

namespace Projeto2LP2
{
    /// <summary>
    /// Game cycle class.
    /// </summary>
    public class GameLoop
    {
        /// <summary>
        /// Gets player's input.
        /// </summary>
        public static ConsoleKey GetKey { get; private set; }

        /// <summary>
        /// Gets or sets score.
        /// </summary>
        public static int ScoreValue { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether the game is over.
        /// </summary>
        public static bool IsGameOver { get; set; }

        /// <summary>
        /// Facade.
        /// </summary>
        private Facade facade;

        /// <summary>
        /// Game cycle.
        /// </summary>
        public void Game() {
            // Called in the start of the game.
            Start();

            // Called in every frame during the game's session.
            Update();
        }

        /// <summary>
        /// Method to be called in the beginning of the game.
        /// </summary>
        private void Start() {
            facade = new Facade();

            // Set the bool to false.
            IsGameOver = false;

            // Start of the scenario.
            facade.GameObjects[1].Start();

            // Start of the snake.
            facade.GameObjects[2].Start();

            // Start of the Food.
            facade.GameObjects[0].Start();

            // Set the initial score.
            ScoreValue = 0;

            // Set the snake's body counter to zero.
            Facade.GetCount = 0;
        }

        /// <summary>
        ///  Method to be called the whole time during the game's session.
        /// </summary>
        private void Update() {
            while (!IsGameOver) {
                // Check player's input.
                CheckUserInput();

                // Update the game's state.
                GameState();

                // Render the game.
                Render();
            }

            // Show the GameOver menu when the game is lost.
            facade.GameOver();
        }

        /// <summary>
        /// Player's input.
        /// </summary>
        private void CheckUserInput() {
            // Start a new thread for the player's input.
            Thread inputThread = new Thread(facade.CheckUserInput);
            inputThread.Start();
            GetKey = facade.ConsoleKey;

            // Close the thread.
            inputThread.Join();
        }

        /// <summary>
        /// Update the game's logic.
        /// </summary>
        private void GameState() {
            facade.Update();
        }

        /// <summary>
        /// Render the game.
        /// </summary>
        private void Render() {
            facade.Render();
        }
    }
}
