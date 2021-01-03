using System;
using System.Collections.Generic;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe que tenta tornar o código menos esparguete.
    /// </summary>
    sealed class Facade
    {
        /// <summary>
        /// Gets (ler) Coordenada X do cenário no SceneObject.
        /// </summary>
        public static int GetSceneX { get => SceneObject.SceneX; }

        /// <summary>
        /// Gets (ler) Coordenada Y do cenário no SceneObject.
        /// </summary>
        public static int GetSceneY { get => SceneObject.SceneY; }

        /// <summary>
        /// Gets or sets a value indicating whether gets (ler) Sets
        /// (modificar) a indicação se o jogo acabou no GameLoop.
        /// </summary>
        public static bool IsGameOver {
            get {
                return GameLoop.isGameOver;
            }
            set {
                GameLoop.isGameOver = value;
            }
        }

        /// <summary>
        /// Gets or sets (ler), Sets (modificar) o corpo da cobra no 
        /// SnakeObject.
        /// </summary>
        public static List<SnakePart> GetSnakeBody {
            get {
                return SnakeObject.snakeBody;
            }
            set {
                SnakeObject.snakeBody = value;
            }
        }

        /// <summary>
        /// Gets or sets (ler), Sets (modificar) o corpo da cobra do
        /// SnakeObject.
        /// </summary>
        public static int GetCordSnakeX {
            get {
                return SnakeObject.SnakeX;
            }
            set {
                SnakeObject.SnakeX = value;
            }
        }

        /// <summary>
        /// Gets or sets (ler), Sets(modificar) a coordenada Y da cobra no
        /// SnakeObject.
        /// </summary>
        public static int GetCordSnakeY {
            get {
                return SnakeObject.SnakeY;
            }
            set {
                SnakeObject.SnakeY = value;
            }
        }

        /// <summary>
        /// Gets (ler), Sets (modificar) a cabeça da cobra no SnakeObject.
        /// </summary>
        public static SnakePart GetHead {
            get {
                return SnakeObject.Head;
            }
        }

        /// <summary>
        /// Gets (ler), Sets (modificar) a cauda da cobra no SnakePart.
        /// </summary>
        public static SnakePart GetTail {
            get {
                return SnakeObject.Tail;
            }
        }

        /// <summary>
        /// Gets or sets (ler), Sets (modificar) a direção da cobra no
        /// SnakeObject.
        /// </summary>
        public static Direction GetDirection {
            get {
                return SnakeObject.direction;
            }
            set {
                SnakeObject.direction = value;
            }
        }

        /// <summary>
        /// Gets or sets (ler), Sets (modificar) a coordenada X da comida no
        /// FoodObject.
        /// </summary>
        public static int GetCordFoodX {
            get {
                return FoodObject.FoodX;
            }
            set {
                FoodObject.FoodX = value;
            }
        }

        /// <summary>
        /// Gets or sets (ler), Sets (modificar) a coordenada Y da comida no 
        /// FoodObject.
        /// </summary>
        public static int GetCordFoodY {
            get {
                return FoodObject.FoodY;
            }
            set {
                FoodObject.FoodY = value;
            }
        }

        /// <summary>
        /// Gets or sets (ler), Sets (modificar) o tamanho da cobra no
        /// RenderEngine.
        /// </summary>
        public static int GetCount {
            get {
                return RenderEngine.count;
            }
            set {
                RenderEngine.count = value;
            }
        }

        /// <summary>
        /// Gets or sets (ler), Sets (modificar) a pontuação no GameLoop.
        /// </summary>
        public static int GetScore {
            get {
                return GameLoop.ScoreValue;
            }
            set {
                GameLoop.ScoreValue = value;
            }
        }

        // Aceder ao UserInput.
        private readonly UserInput userInput;

        // Aceder ao GameState.
        private readonly GameState gameState;

        // Aceder ao RenderEngine.
        private readonly RenderEngine renderEngine;

        /// <summary>
        /// Gets (ler) o input do jogador no UserInput.
        /// </summary>
        public ConsoleKey ConsoleKey { get => userInput.GetKey; }

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
        /// <param name="x"> Se pode correr a intro. </param>
        /// <param name="y"> Se pode correr o splashscreen. </param>
        public void Menu(bool x, bool y) {
            Menu menu = new Menu();
            menu.MainMenu(x, y);
        }

        /// <summary>
        /// Chamar o método GameOverMenu no GameOver.
        /// </summary>
        public void GameOver() {
            GameOver gameOver = new GameOver();
            gameOver.GameOverMenu();
        }

        // Array de GameObjects.
        private readonly GameObject[] gameObjects = {
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
