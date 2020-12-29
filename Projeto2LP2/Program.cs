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
        /// <param name="args"> Argumentos. </param>
        static void Main(string[] args) {
            Menu menu = new Menu();
            menu.MainMenu(true, true);
        }
    }
}
