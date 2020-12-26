using System;
using System.Collections.Generic;
namespace Projeto2LP2
{
    /// <summary>
    /// Classe onde é atualizada a lógica do jogo.
    /// </summary>
    class GameState
    {
        // Aceder à coordenada X do cenário no GameLoop.
        public static int GetSceneX { get => GameLoop.SceneX; }

        // Aceder à coordenada Y do cenário no GameLoop.
        public static int GetSceneY { get => GameLoop.SceneY; }

        // Aceder ao corpo da cobra no GameLoop.
        public static List<SnakePart> GetSnakeBody
        {
            get
            {
                return SnakeObject.snakeBody;
            }
            set 
            {
                SnakeObject.snakeBody = value;
            }
        }

        // Aceder à coordenada X da cobra no GameLoop.
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

        // Aceder à coordenada Y da cobra no GameLoop.
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

        // Aceder à cabeça da cobra no GameLoop.
        public static SnakePart GetHead {
            get {
                return SnakeObject.Head;
            }
        }

        // Aceder à cauda da cobra no GameLoop.
        public static SnakePart GetTail {
            get {
                return SnakeObject.Tail;
            }
        }

        // Aceder à direção da cobra no GameLoop.
        public static Direction GetDirection { get => SnakeObject.direction; }

        // Aceder à coordenada X da comida no GameLoop.
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

        // Aceder à coordenada Y da comida no GameLoop.
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

        // Aceder à pontuação no GameLoop.
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
            GameObject snakeObject = new SnakeObject();
            snakeObject.Update();
        }
    }
}
