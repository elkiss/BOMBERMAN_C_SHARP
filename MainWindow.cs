using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Cursors = System.Windows.Forms.Cursors;

namespace BOMBERMAN
{
    public partial class MainWindow : Form
    {
        public struct Gameparam
        {
            public int gameMode;
            public String nameP1;
            public string nameP2;

        }

       public ChooseCharacter CharacterWindow;
       public GameMode gameModeWindow;

        public Gameparam gameParam;

        public MainWindow()
        {
            InitializeComponent();
            gameParam.gameMode = 1;
            CharacterWindow = new ChooseCharacter(this);
            gameModeWindow = new GameMode(this);
            Controls.Add(CharacterWindow);
            Controls.Add(gameModeWindow);
            CharacterWindow.Visible = gameModeWindow.Visible = false;

            #region Buttons

            btn_newGame.MouseHover += new EventHandler(ButtonHover);
            btn_LoadGame.MouseHover += new EventHandler(ButtonHover);
            btn_exit.MouseHover += new EventHandler(ButtonHover);
            btn_newGame.MouseLeave += new EventHandler(ButtonLeave);
            btn_LoadGame.MouseLeave += new EventHandler(ButtonLeave);
            btn_exit.MouseLeave += new EventHandler(ButtonLeave);

            btn_exit.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_LoadGame.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_newGame.FlatAppearance.MouseOverBackColor = Color.Transparent;
            

            btn_newGame.Click += new EventHandler(ButtonClik);
            btn_LoadGame.Click += new EventHandler(ButtonClik);
            btn_exit.Click += new EventHandler(ButtonClik);

            #endregion
        }

        private void MainWindow_Load(object sender, EventArgs e)
        {

        }

        private void ButtonHover(object o,EventArgs e)
        {
            Button b = o as Button;
            b.Cursor = Cursors.Hand;
            b.BackgroundImage = Properties.Resources.btn_hover;
        }
        
        private void ButtonLeave(object o,EventArgs e)
        {
            Button b = o as Button;
            b.BackgroundImage = Properties.Resources.btn_not_hover;
        }

        private void ButtonClik(object o, EventArgs e)
        {
            Button bouton = o as Button;

            bouton.BackgroundImage = Properties.Resources.btn_not_hover;

            switch (bouton.Text)
            {
                case "NOUVELLE PARTIE":
                    CacherControl(1);
                    break;
                case "CHARGER PARTIE":
                    break;
                case "QUITTER":
                    if (MessageBox.Show("VOULEZ VOUS QUITTER LE JEU ?", "QUITTER", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        Application.Exit();
                    break;
                default:
                    break;
            }
        }

        public void CacherControl(int dialog)
        {
            if(dialog == 1)
            {
                pan_Main.Visible = CharacterWindow.Visible = false;
                gameModeWindow.Visible = !pan_Main.Visible;               
            }
            else if(dialog == 2)
            {
                pan_Main.Visible = gameModeWindow.Visible = false;
                CharacterWindow.Visible = !pan_Main.Visible;
            }
            else if(dialog == 3)
            {
                gameModeWindow.Visible = CharacterWindow.Visible = false;
                pan_Main.Visible = !gameModeWindow.Visible;
            }

        }
    }
}
