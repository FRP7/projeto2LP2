using System;

namespace Projeto2LP2
{
    /// <summary>
    /// GameObject abstract class.
    /// </summary>
    public abstract class GameObject
    {
        /// <summary>
        /// Method to be called when the game begins.
        /// </summary>
        public abstract void Start();

        /// <summary>
        /// Method to be called the whole time during the game session.
        /// </summary>
        public abstract void Update();

        /// <summary>
        /// Rendering method.
        /// </summary>
        public abstract void Render();
    }
}
