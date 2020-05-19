using BOMBERMAN.GameWorlds;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public Gameparam gameParam;
        public Sc_game GameScreen = null;

        public MainWindow()
        {
            InitializeComponent();

            CharacterWindow = new ChooseCharacter(this);
            Controls.Add(CharacterWindow);
            CharacterWindow.Visible =false;

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
                    CacherControl(2);
                    break;
                case "CHARGER PARTIE":
                    {
                        GameState sauvegarde;
                        using (OpenFileDialog file = new OpenFileDialog())
                        {
                            if (file.ShowDialog() == DialogResult.OK)
                            {
                                string path = file.FileName;

                                System.Runtime.Serialization.IFormatter formatter = new BinaryFormatter();
                                System.IO.FileStream filestream = new System.IO.FileStream(path, System.IO.FileMode.Open);
                                try
                                {
                                    sauvegarde = (GameState)formatter.Deserialize(filestream);
                                    MessageBox.Show("Test ");

                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show("An error has occured : " + ex.Message);
                                    return;
                                }
                                GameScreen = new Sc_game(this, sauvegarde);
                                GameScreen.ShowDialog(this);
                                filestream.Close();

                            }
                        }


                    }
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
            }
            else if(dialog == 2)
            {
                pan_Main.Visible = false;
                CharacterWindow.Visible = !pan_Main.Visible;
            }
            else if(dialog == 3)
            {
                CharacterWindow.Visible = false;
                pan_Main.Visible = !CharacterWindow.Visible;
            }
        }

        private void MainWindow_VisibleChanged(object sender, EventArgs e)
        {
            if(this.Visible == false && GameScreen == null)
            {
                GameScreen = new Sc_game(this,null);
                GameScreen.ShowDialog(this);
            }
        }
    }
}
