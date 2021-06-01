using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Chess_v01
{
    public class Piece
    {
        public string name;

        public (int x, int y) position;

        public int player; // cine detine piesa
        public Color color = new Color();

        public int value;
        public List<(int, int)> validMoves = new List<(int, int)>();
        //public PictureBox poza;
        public string imageURL;

        public Piece(string name, Color color, int player, (int, int) position, int value, string imageURL)
        {
            this.name = name;
            this.color = color;
            this.player = player;
            this.position = position;
            this.value = value;
            //this.poza = new PictureBox();
            //poza.Load(imageURL);
            this.imageURL = imageURL;
        }

     //   public PictureBox Poza { get => poza; set => poza = value; }

        public void Show(Panel p)
        {
            PictureBox poza = new PictureBox();
            poza.Load(imageURL);
            poza.Height = 70;
            poza.Width = 70;
            poza.Top = 31 * (20 - position.x * 2);
            poza.Left = 34 * (20 - (position.y * 2));
            poza.BackColor = Color.Transparent;
            poza.SizeMode = PictureBoxSizeMode.Zoom;


            p.Controls.Add(poza);
            poza.BringToFront();
            p.Refresh();
        }
        
    }
}