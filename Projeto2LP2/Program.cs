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
        // Começar o jogo.
        static void Main(string[] args) {
            Menu menu = new Menu();
            menu.MainMenu();
        }
    }
}
