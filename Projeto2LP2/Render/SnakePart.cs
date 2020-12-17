using System;

namespace Projeto2LP2
{
    class SnakePart
    {
        public int CordX { get; set; }
        public int CordY { get; set; }
        public char Part { get; set; }

        public SnakePart(int x, int y, char part) {
            CordX = x;
            CordY = y;
            Part = part;
        }
    }
}
