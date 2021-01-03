using System;

namespace Projeto2LP2
{
    /// <summary>
    /// Classe das uma partes da cobra.
    /// </summary>
    public class SnakePart
    {
        /// <summary>
        /// Gets or sets coordenada x da parte da cobra.
        /// </summary>
        public int CordX { get; set; }

        /// <summary>
        /// Gets or sets coordenada y da parte da cobra.
        /// </summary>
        public int CordY { get; set; }

        /// <summary>
        /// Gets or sets caracter da parte.
        /// </summary>
        public char Part { get; set; }

        /// <summary>
        /// Inicializar propriedades e variáveis.
        /// </summary>
        /// <param name="x"> Coordenada X.</param>
        /// <param name="y"> Coordenada Y.</param>
        /// <param name="part"> Caracter da parte.</param>
        public SnakePart(int x, int y, char part) {
            CordX = x;
            CordY = y;
            Part = part;
        }
    }
}
