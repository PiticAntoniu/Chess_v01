using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess_v01
{
    public partial class Form1 : Form
    {
        Chess chess = new Chess();
        BoardView b;
        public Form1()
        {
            InitializeComponent();
        
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            b = new BoardView(this);
            b.Show();
        }

        private void addPiecesButton_Click(object sender, EventArgs e)
        {

            for (int i = 1; i < 11; i++)
            {
                chess.pieces.Add(
              new Pawn
              (
                  "Pawn",
                  Color.White,
                  1,
                  (2, i),
                  1,
                  @".\Chess_Pieces\Chess_White_Pawn.png"
              )

              );
            }

            for (int i = 1; i < 11; i++)
            {
                chess.pieces.Add(
              new Pawn
              (
                  "Pawn",
                  Color.Black,
                  2,
                  (9, i),
                  1,
                  @".\Chess_Pieces\Chess_Black_Pawn.png"
              )

              );
            }

            chess.pieces.Add(
            new Knight
            (
                "Knight",
                Color.Black,
                2,
                (10,2),
                3,
                @".\Chess_Pieces\Chess_Black_Knight.png"
            )

            );

            chess.pieces.Add(
            new Knight
            (
                "Knight",
                Color.White,
                1,
                (1,2),
                3,
                @".\Chess_Pieces\Chess_White_Knight.png"
            )

            );

            chess.pieces.Add(
            new Knight
            (
                "Knight",
                Color.Black,
                2,
                (10, 9),
                3,
                @".\Chess_Pieces\Chess_Black_Knight.png"
            )

            );

            chess.pieces.Add(
            new Knight
            (
                "Knight",
                Color.White,
                1,
                (1, 9),
                3,
                @".\Chess_Pieces\Chess_White_Knight.png"
            )

            );

            chess.pieces.Add(
            new Rook
            (
                "Rook",
                Color.Black,
                2,
                (10,1),
                4,
                @".\Chess_Pieces\Chess_Black_Rook.png"
            )

            );


            chess.pieces.Add(
            new Rook
            (
                "Rook",
                Color.White,
                1,
                (1,1),
                4,
                @".\Chess_Pieces\Chess_White_Rook.png"
            )

            );

            chess.pieces.Add(
            new Rook
            (
                "Rook",
                Color.Black,
                2,
                (10, 10),
                4,
                @".\Chess_Pieces\Chess_Black_Rook.png"
            )

            );

            chess.pieces.Add(
            new Rook
            (
                "Rook",
                Color.White,
                1,
                (1, 10),
                4,
                @".\Chess_Pieces\Chess_White_Rook.png"
            )

            );

            chess.pieces.Add(
            new Bishop
            (
                "BiShop",
                Color.Black,
                2,
                (10, 3),
                3,
                @".\Chess_Pieces\Chess_Black_Bishop.png"
            )

            );

            chess.pieces.Add(
            new Bishop
            (
                "Bishop",
                Color.White,
                1,
                (1, 3),
                3,
                @".\Chess_Pieces\Chess_White_Bishop.png"
            )

            );

            chess.pieces.Add(
            new Bishop
            (
                "Bishop",
                Color.Black,
                2,
                (10, 8),
                3,
                @".\Chess_Pieces\Chess_Black_Bishop.png"
            )

            );

            chess.pieces.Add(
            new Bishop
            (
                "Bishop",
                Color.White,
                1,
                (1, 8),
                3,
                @".\Chess_Pieces\Chess_White_Bishop.png"
            )

            );


            ///

            chess.pieces.Add(
            new Queen
            (
                "Queen",
                Color.Black,
                2,
                (10, 7),
                3,
                @".\Chess_Pieces\Chess_Black_Queen.png"
            )

            );

            chess.pieces.Add(
            new Queen
            (
                "Queen",
                Color.White,
                1,
                (1, 7),
                3,
                @".\Chess_Pieces\Chess_White_Queen.png"
            )

            );

            ////

            chess.pieces.Add(
            new King
            (
                "King",
                Color.Black,
                2,
                (10, 6),
                3,
                @".\Chess_Pieces\Chess_Black_King.png"
            )

            );

            chess.pieces.Add(
            new King
            (
                "King",
                Color.White,
                1,
                (1, 6),
                3,
                @".\Chess_Pieces\Chess_White_King.png"
            )

            );

            ///

           chess.pieces.Add(
           new Marshall
           (
               "Marshall",
               Color.Black,
               2,
               (10, 5),
               3,
               @".\Chess_Pieces\Chess_Black_Marshall.png"
           )

           );

            chess.pieces.Add(
            new Marshall
            (
                "Marshall",
                Color.White,
                1,
                (1, 5),
                3,
                @".\Chess_Pieces\Chess_White_Marshall.png"
            )

            );


           chess.pieces.Add(
           new Cardinal
           (
               "Cardinal",
               Color.Black,
               2,
               (10, 4),
               3,
               @".\Chess_Pieces\Chess_Black_Cardinal.png"
           )

           );

            chess.pieces.Add(
            new Cardinal
            (
                "Cardinal",
                Color.White,
                1,
                (1, 4),
                3,
                @".\Chess_Pieces\Chess_White_Cardinal.png"
            )

            );


            Helper.SaveToJson(chess, @"InitialBoard.json");

        }

        private void button1_Click(object sender, EventArgs e) //test button
        {
            //chess.board.Show(this.CreateGraphics());
            //pictureBox1.BringToFront();

            chess = Helper.LoadFromJson(@"InitialBoard.json");

            //chess.ShowPieces(panel1);

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
