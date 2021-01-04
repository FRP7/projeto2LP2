using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Struct of the Food's stats.
    /// </summary>
    public struct Food
    {
        /// <summary>
        /// Gets or sets cord x of the Food.
        /// </summary>
        public int CordX { get; set; }

        /// <summary>
        /// Gets or sets cord y of the Food.
        /// </summary>
        public int CordY { get; set; }

        /// <summary>
        /// Gets or sets the char of the Food to be shown.
        /// </summary>
        public char FoodChar { get; set; }

        /// <summary>
        /// Initialize the properties.
        /// </summary>
        /// <param name="x"> Cord X of the Food. </param>
        /// <param name="y"> Coord Y of the Food. </param>
        /// <param name="food"> Char of the Food. </param>
        public Food(int x, int y, char food)
        {
            CordX = x;
            CordY = y;
            FoodChar = food;
        }
    }
}
