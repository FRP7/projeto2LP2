using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe onde inicia o jogo.
    /// </summary>
    sealed class Program
    {
        /// <summary>
        /// Começar o jogo.
        /// </summary>
        static void Main(/*string[] args*/) {
            Menu menu = new Menu();
            menu.MainMenu(true, true);
        }
    }
}
