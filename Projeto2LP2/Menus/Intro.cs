using System;
using System.Threading;

namespace Projeto2LP2
{
    /// <summary>
    /// Intro do jogo.
    /// </summary>
    class Intro
    {
        /// <summary>
        /// Método que reproduz a intro do jogo.
        /// </summary>
        public void IntroMenu()
        {
            Menu menu = new Menu();

            Console.Clear();

            menu.AlignText("    \\___|__|__|__|__|__|\\_|_____|    |___|__" +
                "_|__|__|__|__|____|__|__|\\____| ");
            Thread.Sleep(500);
            Console.Clear();
            menu.AlignText("   \\    |  |  |  |  |  .  |     |    |   | " +
                "  |  |  |  |  ||  ||  |  \\     | ");
            menu.AlignText("    \\___|__|__|__|__|__|\\_|_____|    |___|_" +
                "__|__|__|__|__|____|__|__|\\____| ");
            Thread.Sleep(500);
            Console.Clear();
            menu.AlignText("  /  \\ |  |  |  _  |     |   [_     |   |  " +
                " |  _  |  |  ||  ||  _  /   \\_ ");
            menu.AlignText("   \\    |  |  |  |  |  .  |     |    |   | " +
                "  |  |  |  |  ||  ||  |  \\     | ");
            menu.AlignText("    \\___|__|__|__|__|__|\\_|_____|    |___|_" +
                "__|__|__|__|__|____|__|__|\\____| ");
            Thread.Sleep(500);
            Console.Clear();
            menu.AlignText("  \\__  |  |  |     |    \\|    _]    |  \\_/ " +
                " |     |  |  ||  ||     |/  /  ");
            menu.AlignText("  /  \\ |  |  |  _  |     |   [_     |   |" +
                "   |  _  |  |  ||  ||  _  /   \\_ ");
            menu.AlignText("   \\    |  |  |  |  |  .  |     |  " +
                "  |   |   |  |  |  |  ||  ||  |  \\     | ");
            menu.AlignText("    \\___|__|__|__|__|__|\\_|_____|  " +
                "  |___|___|__|__|__|__|____|__|__|\\____| ");
            Thread.Sleep(500);
            Console.Clear();
            menu.AlignText(" (   \\_|  _  |  o  |  ' / /  [_   " +
                "  | _   _ |  o  |  _  ||  ||  o  | /  / ");
            menu.AlignText("  \\__  |  |  |     |    \\|    _]    | " +
                " \\_/  |     |  |  ||  ||     |/  /  ");
            menu.AlignText("  /  \\ |  |  |  _  |     |   [_     |   | " +
                "  |  _  |  |  ||  ||  _  /   \\_ ");
            menu.AlignText("   \\    |  |  |  |  |  .  |     |    |   |  " +
                " |  |  |  |  ||  ||  |  \\     | ");
            menu.AlignText("    \\___|__|__|__|__|__|\\_|_____|    |___|__" +
                "_|__|__|__|__|____|__|__|\\____| ");
            Thread.Sleep(500);
            Console.Clear();
            menu.AlignText("  / ___/    \\ /    |  |/ ] /  _]    |   | " +
                "  |/    |    \\|    |/    |  /  ]");
            menu.AlignText(" (   \\_|  _  |  o  |  ' / /  [_     | _  " +
                " _ |  o  |  _  ||  ||  o  | /  / ");
            menu.AlignText("  \\__  |  |  |     |    \\|    _]    |  \\_/" +
                "  |     |  |  ||  ||     |/  /  ");
            menu.AlignText("  /  \\ |  |  |  _  |     |   [_     |   |  " +
                " |  _  |  |  ||  ||  _  /   \\_ ");
            menu.AlignText("   \\    |  |  |  |  |  .  |     |    |   |" +
                "   |  |  |  |  ||  ||  |  \\     | ");
            menu.AlignText("    \\___|__|__|__|__|__|\\_|_____|    |___|_" +
                "__|__|__|__|__|____|__|__|\\____| ");
            Thread.Sleep(500);
            Console.Clear();
            menu.AlignText("   _________   ____ __  _   ___      ___ ___" +
                "  ____ ____  ____  ____    __ ");
            menu.AlignText("  / ___/    \\ /    |  |/ ] /  _]    |   |  " +
                " |/    |    \\|    |/    |  /  ]");
            menu.AlignText(" (   \\_|  _  |  o  |  ' / /  [_     | _   _ " +
                "|  o  |  _  ||  ||  o  | /  / ");
            menu.AlignText("  \\__  |  |  |     |    \\|    _]    |  \\_/ " +
                " |     |  |  ||  ||     |/  /  ");
            menu.AlignText("  /  \\ |  |  |  _  |     |   [_     |   |   " +
                "|  _  |  |  ||  ||  _  /   \\_ ");
            menu.AlignText("   \\    |  |  |  |  |  .  |     |    |   |  " +
                " |  |  |  |  ||  ||  |  \\     | ");
            menu.AlignText("    \\___|__|__|__|__|__|\\_|_____|    |___|__" +
                "_|__|__|__|__|____|__|__|\\____| ");
            Thread.Sleep(500);
        }
    }
}
