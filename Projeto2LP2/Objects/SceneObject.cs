using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Scenario GameObject.
    /// </summary>
    public class SceneObject : GameObject
    {
        /// <summary>
        /// Gets the Scene's width.
        /// </summary>
        public static int SceneX { get; private set; }

        /// <summary>
        /// Gets the Scene's height.
        /// </summary>
        public static int SceneY { get; private set; }

        /// <summary>
        /// Method to be called when the game begins.
        /// </summary>
        public override void Start() {
            // Set scene size.
            SceneX = 35;
            SceneY = 16;
        }

        /// <summary>
        /// Method to be called the whole time during the game session.
        /// </summary>
        public override void Update() {
        }

        /// <summary>
        /// Method where the scenario is rendered.
        /// </summary>
        public override void Render() {
                // Up line.
                for (int i = 0; i < Facade.GetSceneX; i++) {
                    Console.SetCursorPosition(i, 0);
                    Console.WriteLine("_");
                }

                // Down line.
                for (int i = 0; i < Facade.GetSceneX; i++) {
                    Console.SetCursorPosition(i, Facade.GetSceneY - 1);
                    Console.WriteLine("_");
                }

                // Left line.
                for (int i = 0; i < Facade.GetSceneY; i++) {
                    Console.SetCursorPosition(0, i);
                    Console.WriteLine("|");
                }

                // RIght line.
                for (int i = 0; i < Facade.GetSceneY; i++) {
                    Console.SetCursorPosition(Facade.GetSceneX, i);
                    Console.WriteLine("|");
                }

                // Score.
                Console.SetCursorPosition(0, Facade.GetSceneY + 1);
                Console.WriteLine("Score: " + Facade.GetScore);
        }
    }
}
