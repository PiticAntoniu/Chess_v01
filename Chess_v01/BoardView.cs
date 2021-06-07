using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chess_v01
{
    class BoardView
    {
        Panel[,] panels = new Panel[Const.H, Const.W];
        public BoardView(Form f)
        {
            panels = new Panel[Const.H + 1, Const.W + 1];

            for (int i = 1; i <= Const.H; i++)
            {
                for (int j = 1; j <= Const.W; j++)
                {
                    Color curentColor;
                    if ((i + j) % 2 == 0)
                        curentColor = Const.WhiteColor;
                    else
                        curentColor = Const.BlackColor;

                    panels[i, j] = new Panel();
                    panels[i, j].Top = i * Const.dim;
                    panels[i, j].Left = j * Const.dim;
                    panels[i, j].BackColor = curentColor;
                    panels[i, j].Height = Const.dim;
                    panels[i, j].Width = Const.dim;



                    f.Controls.Add(panels[i, j]);

                }
            }
        }

        internal void Show()
        {
            //throw new NotImplementedException();
        }
    }
}
