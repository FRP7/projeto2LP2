﻿using System;
using System.Collections.Generic;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe que tenta tornar o código menos esparguete.
    /// </summary>
    sealed class Facade
    {
        // Aceder à coordenada X do cenário no SceneObject.
        public static int GetSceneX { get => SceneObject.SceneX; }

        // Aceder à coordenada Y do cenário no SceneObject.
        public static int GetSceneY { get => SceneObject.SceneY; }


        // Aceder ao corpo da cobra no SnakeObject.
        public static List<SnakePart> GetSnakeBody {
            get {
                return SnakeObject.snakeBody;
            }
            set {
                SnakeObject.snakeBody = value;
            }
        }

        // Aceder à coordenada X da cobra no SnakeObject.
        public static int GetCordSnakeX {
            get {
                return SnakeObject.SnakeX;
            }
            set {
                SnakeObject.SnakeX = value;
            }
        }

        // Aceder à coordenada Y da cobra no SnakeObject.
        public static int GetCordSnakeY {
            get {
                return SnakeObject.SnakeY;
            }
            set {
                SnakeObject.SnakeY = value;
            }
        }

        // Aceder à cabeça da cobra no SnakeObject.
        public static SnakePart GetHead {
            get {
                return SnakeObject.Head;
            }
        }

        // Aceder à cauda da cobra no SnakePart.
        public static SnakePart GetTail {
            get {
                return SnakeObject.Tail;
            }
        }

        // Aceder à direção da cobra no SnakeObject.
        public static Direction GetDirection {
            get {
                return SnakeObject.direction;
            }
            set {
                SnakeObject.direction = value;
            }
        }

        // Aceder à coordenada X da comida no FoodObject.
        public static int GetCordFoodX {
            get {
                return FoodObject.FoodX;
            }
            set {
                FoodObject.FoodX = value;
            }
        }

        // Aceder à coordenada Y da comida no FoodObject.
        public static int GetCordFoodY {
            get {
                return FoodObject.FoodY;
            }
            set {
                FoodObject.FoodY = value;
            }
        }

        // Aceder à contagem do tamanho da cobra no RenderEngine.
        public static int GetCount {
            get {
                return RenderEngine.count;
            }
            set {
                RenderEngine.count = value;
            }
        }

        // Aceder à pontuação no GameLoop.
        public static int GetScore {
            get {
                return GameLoop.ScoreValue;
            }
            set {
                GameLoop.ScoreValue = value;
            }
        }

        // Aceder ao UserInput.
        private UserInput userInput;

        // Aceder ao GameState.
        private GameState gameState;

        // Aceder ao RenderEngine.
        private RenderEngine renderEngine;

        // Aceder ao input do jogador no UserInput.
        public ConsoleKey consoleKey { get => userInput.GetKey; }

        /// <summary>
        /// / Chamar o método CheckUserInput no User Input.
        /// </summary>
        public void CheckUserInput() {
            userInput.CheckUserInput();
        }

        /// <summary>
        ///  Chamar o método Update no GameState.
        /// </summary>
        public void Update() {
            gameState.Update();
        }

        /// <summary>
        /// Chamar o método Render no RenderEngine.
        /// </summary>
        public void Render() {
            renderEngine.Render();
        }

        /// <summary>
        /// Chamar o método MainMenu no Menu.
        /// </summary>
        public void Menu() {
            Menu menu = new Menu();
            menu.MainMenu();
        }

        /// <summary>
        /// Chamar o método GameOverMenu no GameOver.
        /// </summary>
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

        /// <summary>
        /// Inicializar as variáveis.
        /// </summary>
        public Facade() {
            userInput = new UserInput();
            gameState = new GameState();
            renderEngine = new RenderEngine();
        }
    }
}