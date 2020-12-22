using System;

namespace Projeto2LP2
{
    class Food
    {
        // Coordenadas.
        public int CordX { get; set; }
        public int CordY { get; set; }
        // Caracter da comida..
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
