using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess_v01
{
    class Chess
    {
        public Board board = new Board(Const.H,Const.W);
        public List<Piece> pieces = new List<Piece>();

        internal void ShowPieces(Panel p)
        {
            foreach (Piece piece in pieces)
            {
                piece.Show(p);
            }
        }
    }
}
