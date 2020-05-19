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
    public partial class PauseGame : UserControl
    {
        private Sc_game gameW;

        public PauseGame(Sc_game gameSc)
        {
            InitializeComponent();

            int x, y;

            x = (gameSc.Width - Size.Width) / 2;
            y = (gameSc.Height - Size.Height) / 2;
            Location = new Point(x, y);

            gameW = gameSc;

            #region Button
            btn_resume.MouseHover += new EventHandler(ButtonHover);
            btn_exit.MouseHover += new EventHandler(ButtonHover);
            btn_save.MouseHover += new EventHandler(ButtonHover);

            btn_resume.MouseHover += new EventHandler(ButtonHover);
            btn_exit.MouseHover += new EventHandler(ButtonHover);
            btn_save.MouseHover += new EventHandler(ButtonHover);

            btn_resume.Click += new EventHandler(ButtonClick);
            btn_exit.Click += new EventHandler(ButtonClick);
            btn_save.Click += new EventHandler(ButtonClick);

            btn_resume.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_exit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_save.FlatAppearance.MouseOverBackColor = Color.Transparent;

            btn_resume.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_exit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_save.FlatAppearance.MouseOverBackColor = Color.Transparent;

            btn_resume.MouseLeave += new EventHandler(ButtonLeave);
            btn_exit.MouseLeave += new EventHandler(ButtonLeave);
            btn_save.MouseLeave += new EventHandler(ButtonLeave);
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

            if (bouton.Name.Equals(btn_resume.Name))
            {
                gameW.timer1.Start();
                gameW.MyGame.PauseGame = false;
                gameW.pan_arena.Visible = true;
                this.Dispose();
            }
            else if (bouton.Name.Equals(btn_save.Name))
            {
                gameW.MyGame.SaveGame();
                gameW.Close();
            }
            else
            {
                gameW.Close();
            }
        }
    }
}
