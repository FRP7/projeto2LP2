﻿namespace Projeto2LP2
{
    /// <summary>
    /// Class of one of the Snake's parts.
    /// </summary>
    public class SnakePart
    {
        /// <summary>
        /// Gets or sets cord x of the Snake's part.
        /// </summary>
        public int CordX { get; set; }

        /// <summary>
        /// Gets or sets cord y of the Snake's part.
        /// </summary>
        public int CordY { get; set; }

        /// <summary>
        /// Gets or sets the char to be shown of the Snake's part.
        /// </summary>
        public char Part { get; set; }

        /// <summary>
        /// Initialize the properties.
        /// </summary>
        /// <param name="x"> Cord X of the Snake's part.</param>
        /// <param name="y"> Cord Y of the Snake's part.</param>
        /// <param name="part"> Char or the Snake's part.</param>
        public SnakePart(int x, int y, char part) {
            CordX = x;
            CordY = y;
            Part = part;
        }
    }
}
