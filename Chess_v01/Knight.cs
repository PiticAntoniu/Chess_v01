using System.Drawing;

namespace Chess_v01
{
    internal class Knight : Piece
    {
        public Knight(string name, Color color, int player, (int x, int y) position, int value, string imageURL)
            : base(name, color, player, position, value, imageURL)
        {
            validMoves.Clear();
            validMoves.Add((position.x + 2, position.y - 1));
            validMoves.Add((position.x + 2, position.y + 1));

        }

        
    }
}