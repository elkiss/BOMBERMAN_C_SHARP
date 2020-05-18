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
        private List<string> playerCharacter;
        private List<Image[]> playerSprites;
        private List<Image> iconOnGame;
        private MainWindow mainWin;

        public Sc_game(MainWindow mainW)
        {
            InitializeComponent();

            pan_arena.Size = new Size(590, 590);
            
            bufferG = BufferedGraphicsManager.Current.Allocate(pan_arena.CreateGraphics(), pan_arena.DisplayRectangle);
            gr = bufferG.Graphics;
            DoubleBuffered = true;

            playerCharacter = new List<string>() 
            { 
                { "WHITE"},
                { "BLACK"},
                { "BLUE"},
                { "MAROON"},
             };

            playerSprites = new List<Image[]>()
            {
               new Image[]{Properties.Resources.WB_RIGHT,
                   Properties.Resources.WB_LEFT, 
                   Properties.Resources.WB_UP,
                   Properties.Resources.WB_DOWN,
                   Properties.Resources.WB_WIN,
                   Properties.Resources.WB_DEAD
               },
                
                new Image[]{Properties.Resources.WBBLA_RIGHT,
                   Properties.Resources.WBBLA_LEFT, 
                   Properties.Resources.WBBLA_UP,
                   Properties.Resources.WBBLA_DOWN,
                   Properties.Resources.WBBLA_WIN,
                   Properties.Resources.WBBLA_DEAD
               },
                
                new Image[]{Properties.Resources.WBBL_RIGHT,
                   Properties.Resources.WBBL_LEFT, 
                   Properties.Resources.WBBL_UP,
                   Properties.Resources.WBBL_DOWN,
                   Properties.Resources.WBBL_WIN,
                   Properties.Resources.WBBL_DEAD
               }, 
                
                new Image[]{Properties.Resources.WBM_RIGHT,
                   Properties.Resources.WBM_LEFT, 
                   Properties.Resources.WBM_UP,
                   Properties.Resources.WBM_DOWN,
                   Properties.Resources.WBM_WIN,
                   Properties.Resources.WBM_DEAD
               },
            };

            iconOnGame = new List<Image>()
            {
                {Properties.Resources.INT_WB },
                {Properties.Resources.INT_WBBLA },
                {Properties.Resources.INT_WBBL },
                {Properties.Resources.INT_WBM },
            };

            LoadGameParam(mainW.gameParam);

            mainWin = mainW;

        }

        private void Sc_game_Load(object sender, EventArgs e)
        {
            
            int x, y;
            mainWin.Hide();
            x = (ClientSize.Width - pan_arena.Size.Width)/ 2;
            y = (ClientSize.Height - pan_arena.Height) / 2;
            pan_arena.Location = new Point(x, y);
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
            game.PlayersLogic();
            game.BombeLogic();
            game.BonusLogic();
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
            game.KeyDownActionPlayer1(e.KeyCode);

            if(game.Map.Player2 != null)
            {
                game.KeyDownActionPlayer2(e.KeyCode);
            }
        }

        private void Sc_game_KeyUp(object sender, KeyEventArgs e)
        {
            game.KeyUpActionPlayer1(e.KeyCode);

            if(game.Map.Player2 != null)
            {
                game.KeyUpActionPlayer2(e.KeyCode);
            }
            
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

        private void LoadGameParam(MainWindow.Gameparam gameparam)
        {
            if(gameparam.gameMode == 2)
            {
                int indexP1 = playerCharacter.IndexOf(gameparam.nameP1);
                int indexP2 = playerCharacter.IndexOf(gameparam.nameP2);

                game = new Game(pan_arena.ClientRectangle,playerSprites[indexP1],playerSprites[indexP2],gameparam);
            }
            else
            {
                int indexP1 = playerCharacter.IndexOf(gameparam.nameP1);
                game = new Game(pan_arena.ClientRectangle, playerSprites[indexP1],null, gameparam);
            }
        }
    }
}
