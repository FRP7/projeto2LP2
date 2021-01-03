using System;
using System.Collections.Generic;
namespace Projeto2LP2
{
    /// <summary>
    /// Classe onde é atualizada a lógica do jogo.
    /// </summary>
    public class GameState
    {
        /// <summary>
        /// Gets coordenada X do cenário no GameLoop.
        /// </summary>
        public static int GetSceneX { get => Facade.GetSceneX; }

        /// <summary>
        /// Gets coordenada Y do cenário no GameLoop.
        /// </summary>
        public static int GetSceneY { get => Facade.GetSceneY; }

        /// <summary>
        /// Gets or sets corpo da cobra.
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
        /// Gets or sets coordenada x da cobra.
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
        /// Gets or sets coordenada Y da cobra.
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
        /// Gets cabeça da cobra.
        /// </summary>
        public static SnakePart GetHead {
            get {
                return Facade.GetHead;
            }
        }

        /// <summary>
        /// Gets cauda da cobra.
        /// </summary>
        public static SnakePart GetTail {
            get {
                return Facade.GetTail;
            }
        }

        /// <summary>
        /// Gets direção da cobra.
        /// </summary>
        public static Direction GetDirection { get => Facade.GetDirection; }

        /// <summary>
        /// Gets or sets coordenada x da comida.
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
        /// Gets or sets coordenada Y da comida.
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
        /// Gets pontuação no GameLoop.
        /// </summary>
        public static int GetScore
        {
            get
            {
                return Facade.GetScore;
            }
        }

        /// <summary>
        /// Verificar a lógica do jogo.
        /// </summary>
        public void Update()
        {
            SnakeUpdate();
        }

        /// <summary>
        /// Verificar posição e colisões da cobra.
        /// </summary>
        private void SnakeUpdate()
        {
            Facade facade = new Facade();
            facade.GameObjects[2].Update();
        }
    }
}
