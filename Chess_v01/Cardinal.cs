using System.Drawing;

namespace Chess_v01
{
    internal class Cardinal : Piece
    {
        public Cardinal(string name, Color color, int player, (int, int) position, int value, string imageURL) : base(name, color, player, position, value, imageURL)
        {
        }
    }
}