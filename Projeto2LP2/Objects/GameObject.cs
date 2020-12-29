using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe abstracta de GameObject.
    /// </summary>
    public abstract class GameObject
    {
        /// <summary>
        /// Método para ser chamado quando o jogo começa.
        /// </summary>
        public abstract void Start();

        /// <summary>
        /// Método para ser chamado continuamente ao longo do jogo.
        /// </summary>
        public abstract void Update();

        /// <summary>
        /// Método de renderização.
        /// </summary>
        public abstract void Render();
    }
}
