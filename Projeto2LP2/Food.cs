using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto2LP2
{
    class Food
    {
        // Coordenadas.
        public int CordX { get; set; }
        public int CordY { get; set; }
        // Caracter da parte.
        public char FoodChar { get; set; }

        /// <summary>
        /// Inicializar propriedades e variáveis.
        /// </summary>
        /// <param name="x"> Coordenada X.</param>
        /// <param name="y"> Coordenada Y.</param>
        /// <param name="food"> Caracter da parte.</param>
        public Food(int x, int y, char food)
        {
            CordX = x;
            CordY = y;
            FoodChar = food;
        }
    }
}
