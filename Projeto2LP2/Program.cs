using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe onde inicia o jogo.
    /// Podem utilizar pa testar os métodos do jogo enquanto o menu não estiver
    /// terminado, só peço que não façam add ás alterações desta classe no git.
    /// </summary>
    class Program
    {
        static void Main(string[] args) {
            //Menu menu = new Menu();
            //Console.WriteLine("Entrar na solução.");
            //menu.MainMenu();
            // testar cenas
            GameLoop loop = new GameLoop();
            loop.Game();
        }
    }
}
