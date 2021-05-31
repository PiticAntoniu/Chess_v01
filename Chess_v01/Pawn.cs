using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chess_v01
{
    public class Pawn : Piece
    {

        public Pawn(string name, Color color, int player, (int x, int y) position, int value, string imageURL):
            base(name, color, player, position, value, imageURL)
        {
            validMoves.Clear();
            validMoves.Add((position.x + 1, position.y));
            validMoves.Add((position.x + 2, position.y));
        }


    }
}
