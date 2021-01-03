using System;
using System.Collections.Generic;
namespace Projeto2LP2
{
    /// <summary>
    /// Classe onde é atualizada a lógica do jogo.
    /// </summary>
    public class GameState
    {
        // Aceder à coordenada X do cenário no GameLoop.
        public static int GetSceneX { get => Facade.GetSceneX; }

        // Aceder à coordenada Y do cenário no GameLoop.
        public static int GetSceneY { get => Facade.GetSceneY; }

        // Aceder ao corpo da cobra no GameLoop.
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

        // Aceder à coordenada X da cobra no GameLoop.
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

        // Aceder à coordenada Y da cobra no GameLoop.
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

        // Aceder à cabeça da cobra no GameLoop.
        public static SnakePart GetHead {
            get {
                return Facade.GetHead;
            }
        }

        // Aceder à cauda da cobra no GameLoop.
        public static SnakePart GetTail {
            get {
                return Facade.GetTail;
            }
        }

        // Aceder à direção da cobra no GameLoop.
        public static Direction GetDirection { get => Facade.GetDirection; }

        // Aceder à coordenada X da comida no GameLoop.
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

        // Aceder à coordenada Y da comida no GameLoop.
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

        // Aceder à pontuação no GameLoop.
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
            facade.gameObjects[2].Update();
        }
    }
}
