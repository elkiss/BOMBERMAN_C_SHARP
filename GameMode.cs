using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOMBERMAN
{
    public partial class GameMode : UserControl
    {

        private Sc_game scG;
        private MainWindow.Gameparam Gameparam;

        public GameMode(Sc_game gameSc, MainWindow.Gameparam gameparam)
        {
            InitializeComponent();

            int x, y;

            x = (gameSc.Width -Size.Width)/2;
            y = (gameSc.Height-Size.Height)/2;
            Location = new Point(x, y);

            scG = gameSc;


            this.Gameparam = gameparam;



            if (scG.MyGame.Map.Player1.IsAlive)
            {
                pb_winner.BackgroundImage = scG.pb_icP1.BackgroundImage;
                lb_winner.Text = scG.lb_p1.Text;
            }
            else
            {
                pb_winner.BackgroundImage = scG.pb_icP2.BackgroundImage;
                lb_winner.Text = scG.lb_p2.Text;
            }

            #region Button
            btn_newGame.MouseHover += new EventHandler(ButtonHover);
            btn_exit.MouseHover += new EventHandler(ButtonHover);

            btn_newGame.MouseHover += new EventHandler(ButtonHover);
            btn_exit.MouseHover += new EventHandler(ButtonHover);
            
            btn_newGame.Click += new EventHandler(ButtonClick);
            btn_exit.Click += new EventHandler(ButtonClick);

            btn_newGame.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_exit.FlatAppearance.MouseOverBackColor = Color.Transparent;

            btn_newGame.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_exit.FlatAppearance.MouseOverBackColor = Color.Transparent;

            btn_newGame.MouseLeave += new EventHandler(ButtonLeave);
            btn_exit.MouseLeave += new EventHandler(ButtonLeave);
            #endregion
        }

        public void ButtonHover(object o, EventArgs e)
        {
            Button b = o as Button;
            b.BackgroundImage = Properties.Resources.btn_hover;
        }

        public void ButtonLeave(object o, EventArgs e)
        {
            Button b = o as Button;
            b.BackgroundImage = Properties.Resources.btn_not_hover;
        }

        public void ButtonClick(object o, EventArgs e)
        {
            Button bouton = o as Button;

            if (bouton.Name.Equals(btn_newGame.Name))
            {
                scG.LoadGameParam(this.Gameparam,null);
                scG.pan_arena.Visible = true;
                this.Dispose();
            }
            else if (bouton.Name.Equals(btn_exit.Name))
            {
                scG.Close();
            }
        }

    }
}
