using System.Collections.Generic;
using System.Drawing;

namespace Chess_v01
{
    internal abstract class Piece
    {

        public (int, int) position;

        public int player; // cine detine piesa
        public Color color = new Color();

        public int value;
        public List<(int, int)> validMoves = new List<(int, int)>();
        Image poza;
        abstract void Show();

    }
}