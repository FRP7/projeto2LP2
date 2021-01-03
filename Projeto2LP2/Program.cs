using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe onde inicia o jogo.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Começar o jogo.
        /// </summary>
        private static void Main(/*string[] args*/) {
            Menu menu = new Menu();
            menu.MainMenu(true, true);
        }
    }
}
