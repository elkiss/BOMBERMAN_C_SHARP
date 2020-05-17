using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BOMBERMAN.GameWorlds;
using BOMBERMAN.GameObj;

namespace BOMBERMAN
{
    public partial class Sc_game : Form
    {
        private BufferedGraphics bufferG = null;
        private Graphics gr;
        private Game game;
        public Sc_game()
        {
            InitializeComponent();
            pan_arena.Size = new Size(590, 590);

            bufferG = BufferedGraphicsManager.Current.Allocate(pan_arena.CreateGraphics(), pan_arena.DisplayRectangle);
            gr = bufferG.Graphics;
            game = new Game(pan_arena.ClientRectangle,1);
            DoubleBuffered = true;

        }

        private void Sc_game_Load(object sender, EventArgs e)
        {
            int x, y;
            x = (ClientSize.Width - pan_arena.Size.Width)/ 2;
            y = (ClientSize.Height - pan_arena.Height) / 2;
            pan_arena.Location = new Point(x, y);
            //pan_arena.BackColor = Color.White;
            game.DrawMap(gr);
            game.Map.LoadPlayerOnMap(gr);



        }

        private void pan_arena_Paint(object sender, PaintEventArgs e)
        {
            //ControlPaint.DrawBorder(e.Graphics, pan_arena.ClientRectangle, Color.Gray, 20, ButtonBorderStyle.Outset,
            //    Color.Gray, 20, ButtonBorderStyle.Outset,
            //    Color.Gray, 20, ButtonBorderStyle.Outset,
            //    Color.Gray, 20, ButtonBorderStyle.Outset);
            //game.DrawMap(e.Graphics);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gr.Clear(pan_arena.BackColor);

            ControlPaint.DrawBorder(gr, pan_arena.ClientRectangle, Color.Gray, 20, ButtonBorderStyle.Outset,
                Color.Gray, 20, ButtonBorderStyle.Outset,
                Color.Gray, 20, ButtonBorderStyle.Outset,
                Color.Gray, 20, ButtonBorderStyle.Outset);
            game.DrawMap(gr);
            game.Map.LoadPlayerOnMap(gr);
            bufferG.Render();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gr.Clear(pan_arena.BackColor);

            ControlPaint.DrawBorder(gr, pan_arena.ClientRectangle, Color.Gray, 20, ButtonBorderStyle.Inset,
                Color.Gray, 20, ButtonBorderStyle.Inset,
                Color.Gray, 20, ButtonBorderStyle.Inset,
                Color.Gray, 20, ButtonBorderStyle.Inset);

            game.Interraction();
            game.BombeLogic();
            game.BonusLogic();
            game.PlayersLogic();
            game.Map.RefreshMap(gr);
            game.DrawMap(gr);

            if (game.BombInGame.Count >= 0)
            {
                foreach (Bombe item in game.BombInGame)
                {
                    item.DrawObject(gr);
                }
            }
            

            bufferG.Render();
        }

        private void Sc_game_KeyDown(object sender, KeyEventArgs e)
        {
            game.KeyDownAction(e.KeyCode);
            //textBox1.Text = game.NextCase(e.KeyCode);
        }

        private void Sc_game_KeyUp(object sender, KeyEventArgs e)
        {
            game.KeyUpAction(e.KeyCode);
            
        }

        private void Sc_game_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            e.IsInputKey = true;

        }

        private void Sc_game_Paint(object sender, PaintEventArgs e)
        {
            //Rectangle rectangle1 = new Rectangle(50, 50, 50, 50);
            //Rectangle rectangle2 = new Rectangle(99, 50, 50, 50);
            //Rectangle rectangle3 = new Rectangle();

            //e.Graphics.DrawRectangle(Pens.Black, rectangle1);
            //e.Graphics.DrawRectangle(Pens.Red, rectangle2);



            //if (rectangle1.IntersectsWith(rectangle2))
            //{
            //    rectangle3 = Rectangle.Intersect(rectangle1, rectangle2);
            //    if (!rectangle3.IsEmpty)
            //    {
            //        e.Graphics.FillRectangle(Brushes.Green, rectangle3);
            //    }
            //}
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
