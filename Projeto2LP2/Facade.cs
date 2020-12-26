﻿using System;
using System.Collections.Generic;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe que tenta tornar o código menos esparguete.
    /// </summary>
    class Facade {
        // Aceder à coordenada X do cenário no GameLoop.
        public static int GetSceneX { get => SceneObject.SceneX; }

        // Aceder à coordenada Y do cenário no GameLoop.
        public static int GetSceneY { get => SceneObject.SceneY; }


        // Aceder ao corpo da cobra no GameLoop.
        public static List<SnakePart> GetSnakeBody {
            get {
                return SnakeObject.snakeBody;
            }
            set {
                SnakeObject.snakeBody = value;
            }
        }

        // Aceder à coordenada X da cobra no GameLoop.
        public static int GetCordSnakeX {
            get {
                return SnakeObject.SnakeX;
            }
            set {
                SnakeObject.SnakeX = value;
            }
        }

        // Aceder à coordenada Y da cobra no GameLoop.
        public static int GetCordSnakeY {
            get {
                return SnakeObject.SnakeY;
            }
            set {
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
        public static Direction GetDirection { get => SnakeObject.direction; set => SnakeObject.direction = value; }


        // Aceder à coordenada X da comida no GameLoop.
        public static int GetCordFoodX {
            get {
                return FoodObject.FoodX;
            }
            set {
                FoodObject.FoodX = value;
            }
        }

        // Aceder à coordenada Y da comida no GameLoop.
        public static int GetCordFoodY {
            get {
                return FoodObject.FoodY;
            }
            set {
                FoodObject.FoodY = value;
            }
        }

        public static int GetCount {
            get {
                return RenderEngine.count;
            }
            set {
                RenderEngine.count = value;
            }
        }

        public static int GetScore {
            get {
                return GameLoop.ScoreValue;
            }
            set {
                GameLoop.ScoreValue = value;
            }
        }

        private UserInput userInput;

        private GameState gameState;

        private RenderEngine renderEngine;

        public ConsoleKey consoleKey { get => userInput.Key; }

        public void CheckUserInput() {
            userInput.CheckUserInput();
        }

        public void Update() {
            gameState.Update();
        }

        public void Render() {
            renderEngine.Render();
        }

        public void Menu() {
            Menu menu = new Menu();
            menu.MainMenu();
        }

        public void GameOver() {
            GameOver gameOver = new GameOver();
            gameOver.GameOverMenu();
        }

        // Array de GameObjects.
        public GameObject[] gameObjects = {
            new FoodObject(),
            new SceneObject(),
            new SnakeObject(),
    };

        public Facade() {
            userInput = new UserInput();
            gameState = new GameState();
            renderEngine = new RenderEngine();
        }
    }
}
