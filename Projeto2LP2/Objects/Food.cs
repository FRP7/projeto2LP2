using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Struct dos stats da comida.
    /// </summary>
    public struct Food
    {
        /// <summary>
        /// Gets or sets coordenada x da comida.
        /// </summary>
        public int CordX { get; set; }

        /// <summary>
        /// Gets or sets coordenada y da comida.
        /// </summary>
        public int CordY { get; set; }

        /// <summary>
        /// Gets or sets caracter da comida.
        /// </summary>
        public char FoodChar { get; set; }

        /// <summary>
        /// Inicializar propiedades e variáveis.
        /// </summary>
        /// <param name="x"> Coordenada X da comida. </param>
        /// <param name="y"> Coordenada Y da comida. </param>
        /// <param name="food"> Caracter da comida. </param>
        public Food(int x, int y, char food)
        {
            CordX = x;
            CordY = y;
            FoodChar = food;
        }
    }
}
