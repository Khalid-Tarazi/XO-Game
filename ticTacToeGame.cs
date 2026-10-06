using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XO_Game
{
    public partial class TicTacToeGame : Form
    {
        public TicTacToeGame()
        {
            InitializeComponent();
        }

        private void TicTacToeGame_Load(object sender, EventArgs e)
        {

        }

        private void TicTacToeGame_Paint(object sender, PaintEventArgs e)
        {
            using (Pen pen = new Pen(Color.White))
            {
                pen.Width = 10;
                pen.StartCap = System.Drawing.Drawing2D.LineCap.Round;
                pen.EndCap = System.Drawing.Drawing2D.LineCap.Round;

                // Draws a vertical line from (100, 100) down to (100, 200)
                e.Graphics.DrawLine(pen, 100, 100, 100, 200);
            }

        }
    }
}
