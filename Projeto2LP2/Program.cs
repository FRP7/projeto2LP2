namespace Projeto2LP2
{
    /// <summary>
    /// Class where game begins.
    /// </summary>
    public static class Program
    {
        /// <summary>
        /// Start the game.
        /// </summary>
        private static void Main() {
            Menu menu = new Menu();
            menu.MainMenu(true, true);
        }
    }
}
