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
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addPiecesButton_Click(object sender, EventArgs e)
        {
            chess.pieces.Add(
                new Pawn
                (
                    "Pawn",
                    Color.White,
                    1,
                    (1,2),
                    1,
                    @"C:\Temp\white_pawn.png"
                )
                
                );

            chess.pieces.Add(
                new Pawn
                (
                    "Pawn",
                    Color.White,
                    1,
                    (2, 2),
                    1,
                    @"C:\Temp\white_pawn.png"
                )

                );
            chess.pieces.Add(
               new Pawn
               (
                   "Pawn",
                   Color.White,
                   1,
                   (2, 5),
                   1,
                   @"C:\Temp\white_pawn.png"
               )

               );

            chess.pieces.Add(
    new Knight
    (
        "Knight",
        Color.White,
        1,
        (2, 1),
        3,
        @"C:\Temp\white_knight.png"
    )

    );

            Helper.SaveToJson(chess, @"InitialBoard.json");

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //chess.board.Show(this.CreateGraphics());
            //pictureBox1.BringToFront();

            chess = Helper.LoadFromJson(@"InitialBoard.json");

            chess.ShowPieces(panel1);
        }
    }
}
