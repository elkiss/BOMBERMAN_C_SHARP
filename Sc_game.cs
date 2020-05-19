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
        private Game myGame;
        private List<string> playerCharacter;
        private List<Image[]> playerSprites;
        private List<Image> iconOnGame;
        private MainWindow mainWin;

        internal Game MyGame { get => myGame; set => myGame = value; }

        public Sc_game(MainWindow mainW,GameState sauv)
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

            mainWin = mainW;

            LoadGameParam(mainW.gameParam, sauv);
                
          

        }

        private void Sc_game_Load(object sender, EventArgs e)
        {
            
            int x, y;
            mainWin.Hide();
            x = (ClientSize.Width - pan_arena.Size.Width)/ 2;
            y = (ClientSize.Height - pan_arena.Height) / 2;
            pan_arena.Location = new Point(x, y);

        }

        private void pan_arena_Paint(object sender, PaintEventArgs e)
        {


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            gr.Clear(pan_arena.BackColor);

            ControlPaint.DrawBorder(gr, pan_arena.ClientRectangle, Color.Gray, 20, ButtonBorderStyle.Inset,
                Color.Gray, 20, ButtonBorderStyle.Inset,
                Color.Gray, 20, ButtonBorderStyle.Inset,
                Color.Gray, 20, ButtonBorderStyle.Inset);

            lb_beffectP1.Text = MyGame.Map.Player1.BombeEffect.ToString();
            lb_nbBp1.Text = MyGame.Map.Player1.NbBombe.ToString();
            lb_speedP1.Text = MyGame.Map.Player1.Vitesse.ToString();
            lb_lifeP1.Text = MyGame.Map.Player1.Life.ToString();

            lb_BeffectP2.Text = MyGame.Map.Player2.BombeEffect.ToString();
            lb_nbBp2.Text = MyGame.Map.Player2.NbBombe.ToString();
            lb_SpeedP2.Text = MyGame.Map.Player2.Vitesse.ToString();
            lb_lifeP2.Text = MyGame.Map.Player2.Life.ToString();


            if (MyGame.GameOver())
            {
                timer1.Stop();
                GameMode dialog = new GameMode(this, mainWin.gameParam);
                this.pan_arena.Visible = false;
                this.Controls.Add(dialog);
            }
            else if (myGame.PauseGame)
            {
                timer1.Stop();
                PauseGame dialog = new PauseGame(this);
                pan_arena.Visible = false;
                this.Controls.Add(dialog);
            }


            MyGame.GameLogic(gr);

            bufferG.Render();
        }

        private void Sc_game_KeyDown(object sender, KeyEventArgs e)
        {
            MyGame.KeyDownActionPlayer1(e.KeyCode);
            MyGame.KeyDownActionPlayer2(e.KeyCode);
        }

        private void Sc_game_KeyUp(object sender, KeyEventArgs e)
        {
            MyGame.KeyUpActionPlayer1(e.KeyCode);
            MyGame.KeyUpActionPlayer2(e.KeyCode);

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

        public void LoadGameParam(MainWindow.Gameparam gameparam, GameState access)
        {
            if(access == null)
            {

                int indexP1 = playerCharacter.IndexOf(gameparam.nameP1);
                int indexP2 = playerCharacter.IndexOf(gameparam.nameP2);
                pb_icP1.BackgroundImage = iconOnGame[indexP1];
                pb_icP2.BackgroundImage = iconOnGame[indexP2];
                MyGame = new Game(pan_arena.ClientRectangle, playerSprites[indexP1], playerSprites[indexP2], gameparam);
                pan_p2.Visible = true;

                MyGame.LoadGame(gr);

                timer1.Start();

            }
            else
            {
                mainWin.gameParam.nameP1 = playerCharacter[(int)access.p1.ChPlayer];
                mainWin.gameParam.nameP2 = playerCharacter[(int)access.p2.ChPlayer];
                pb_icP1.BackgroundImage = iconOnGame[(int)access.p1.ChPlayer];
                pb_icP2.BackgroundImage = iconOnGame[(int)access.p2.ChPlayer];
                MyGame = new Game(pan_arena.ClientRectangle, playerSprites[(int)access.p1.ChPlayer], playerSprites[(int)access.p2.ChPlayer],access);
                pan_p2.Visible = true;
                timer1.Start();

            }


        }

        private void Sc_game_FormClosing(object sender, FormClosingEventArgs e)
        {
            mainWin.Show();
            timer1.Stop();
        }

        private void resumeGame()
        {

        }
    }
}
