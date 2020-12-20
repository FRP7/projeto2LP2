using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe onde é atualizada a lógica do jogo.
    /// </summary>
    class GameState
    {
        // Aceder à coordenada X da cobra no GameLoop.
        public static int GetCordSnakeX {
            get {
                return GameLoop.SnakeX;
            }
            set {
                GameLoop.SnakeX = value;
            }
        }

        // Aceder à coordenada Y da cobra no GameLoop.
        public static int GetCordSnakeY {
            get {
                return GameLoop.SnakeY;
            }
            set {
                GameLoop.SnakeY = value;
            }
        }

        // Aceder à direção da cobra no GameLoop.
        public static Direction GetDirection { get => GameLoop.direction; }

        /// <summary>
        /// Verificar a lógica do jogo.
        /// </summary>
        public void Update() {
            CollisionCheck();
            SnakePositionCheck();
            FoodPositionCheck();
            ScoreCheck();
        }

        /// <summary>
        /// Verificar colisões.
        /// </summary>
        private void CollisionCheck() {
            Collisions collisions = new Collisions();
            collisions.CollisionCheck();
        }

        /// <summary>
        /// Verificar a posição da cobra.
        /// </summary>
        private void SnakePositionCheck() {
            SnakePosition snakePosition = new SnakePosition();
            snakePosition.SnakePositionCheck();
        }

        /// <summary>
        /// Verificar a posição da comida.
        /// </summary>
        private void FoodPositionCheck() {
            FoodPosition foodPosition = new FoodPosition();
            foodPosition.FoodPositionCheck();
        }

        /// <summary>
        /// Verificar a pontuação.
        /// </summary>
        private void ScoreCheck() {
            Score score = new Score();
            score.ScoreCheck();
        }
    }
}
