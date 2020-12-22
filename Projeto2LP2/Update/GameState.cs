using System;
using System.Collections.Generic;
namespace Projeto2LP2
{
    /// <summary>
    /// Classe onde é atualizada a lógica do jogo.
    /// </summary>
    class GameState
    {
        public static List<SnakePart> GetSnakeBody
        {
            get
            {
                return GameLoop.snakeBody;
            }
            set 
            {
                GameLoop.snakeBody = value;
            }
        }
        // Aceder à coordenada X da cobra no GameLoop.
        public static int GetCordSnakeX
        {
            get
            {
                return GameLoop.SnakeX;
            }
            set
            {
                GameLoop.SnakeX = value;
            }
        }

        // Aceder à coordenada Y da cobra no GameLoop.
        public static int GetCordSnakeY
        {
            get
            {
                return GameLoop.SnakeY;
            }
            set
            {
                GameLoop.SnakeY = value;
            }
        }

        public static SnakePart GetHead {
            get {
                return GameLoop.Head;
            }
        }

        public static SnakePart GetTail {
            get {
                return GameLoop.Tail;
            }
        }

        // Aceder à direção da cobra no GameLoop.
        public static Direction GetDirection { get => GameLoop.direction; }

        public static int GetCordFoodX
        {
            get
            {
                return GameLoop.FoodX;
            }
            set
            {
                GameLoop.FoodX = value;
            }
        }
        public static int GetCordFoodY
        {
            get
            {
                return GameLoop.FoodY;
            }
            set
            {
                GameLoop.FoodY = value;
            }
        }
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
            CollisionCheck();
            SnakePositionCheck();
            //FoodPositionCheck();
            ScoreCheck();
        }

        /// <summary>
        /// Verificar colisões.
        /// </summary>
        private void CollisionCheck()
        {
            Collisions collisions = new Collisions();
            collisions.CollisionCheck();
        }

        /// <summary>
        /// Verificar a posição da cobra.
        /// </summary>
        private void SnakePositionCheck()
        {
            SnakePosition snakePosition = new SnakePosition();
            snakePosition.SnakePositionCheck();
        }

        /// <summary>
        /// Verificar a posição da comida.
        /// </summary>
        private void FoodPositionCheck()
        {
            FoodPosition foodPosition = new FoodPosition();
            foodPosition.FoodPositionCheck();
        }

        /// <summary>
        /// Verificar a pontuação.
        /// </summary>
        private void ScoreCheck()
        {
            Score score = new Score();
            score.ScoreCheck();
        }
    }
}
