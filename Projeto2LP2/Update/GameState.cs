using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Aqui é o "update" do jogo.
    /// </summary>
    class GameState
    {
        public void Update() {
            CollisionCheck();
            SnakePositionCheck();
            FoodPositionCheck();
            ScoreCheck();
        }

        private void CollisionCheck() {
            Collisions collisions = new Collisions();
            collisions.CollisionCheck();
        }

        private void SnakePositionCheck() {
            SnakePosition snakePosition = new SnakePosition();
            snakePosition.SnakePositionCheck();
        }

        private void FoodPositionCheck() {
            FoodPosition foodPosition = new FoodPosition();
            foodPosition.FoodPositionCheck();
        }

        private void ScoreCheck() {
            Score score = new Score();
            score.ScoreCheck();
        }
    }
}
