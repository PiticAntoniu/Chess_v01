using System.Drawing;

namespace Chess_v01
{
    internal class Board
    {
        public Square[,] squares;
        public int rowCount;
        public int columnCount;

        public Board(int boardRowCount, int boardColumnCount)
        {
            squares = new Square[boardRowCount + 1, boardColumnCount + 1];
            this.rowCount = boardRowCount;
            this.columnCount = boardColumnCount;
            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= columnCount; j++)
                {
                    if ((i + j) % 2 == 0)
                        squares[i, j] = new Square { color = Color.LightCoral, piece = null };
                    else
                        squares[i, j] = new Square { color = Color.LawnGreen, piece = null };

                }
            }
        }
        public void Show(Graphics g)
        {
            int dim = 50;
            for (int i = 1; i <= rowCount; i++)
            {
                for (int j = 1; j <= columnCount; j++)
                {
                    g.FillRectangle(new SolidBrush(squares[i, j].color), j * dim, i * dim, dim - 2, dim - 2);
                }
            }
        }
    }
}