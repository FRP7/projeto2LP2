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
        /// <summary>
        /// Começar o jogo.
        /// </summary>
        /// <param name="args"> Argumentos. </param>
        static void Main(string[] args) {
            Intro intro = new Intro();
            intro.StartIntro();
        }
    }
}
