using System;
using System.Threading;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe onde é executada a intro do jogo.
    /// </summary>
    class Intro
    {
        // Iniciar a intro.
        public void StartIntro() {
            Menu menu = new Menu();
            IntroContent();
            Thread.Sleep(1000);
            menu.MainMenu();
        }

        // Conteúdo da intro.
        private void IntroContent() {
            Console.WriteLine("Inserir intro.");
        }
    }
}
