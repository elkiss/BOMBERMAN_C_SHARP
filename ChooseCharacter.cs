using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Transitions;
using System.Collections.ObjectModel;

namespace BOMBERMAN
{
    public partial class ChooseCharacter : UserControl
    {
        private List<Image> character;
        private List<string> characterName;
        private int indexch = 0;
        public MainWindow gParam;
        public ChooseCharacter(MainWindow mainForm)
        {
            InitializeComponent();
            int x, y;
            x = (mainForm.Width - Size.Width) / 2;
            y = (mainForm.Height - Size.Height) / 2;
            Location = new Point(x, y);
            //mainForm.Size = Size;

            #region Character Added
            character = new List<Image>()
            {
                { Properties.Resources.WB },
                { Properties.Resources.BB },
                { Properties.Resources.BLB },
                { Properties.Resources.MB }
            };

            characterName = new List<string>()
            {
                {"WHITE"},
                {"BLACK"},
                {"BLUE"},
                {"MAROON"}
            };
            #endregion

            gParam = mainForm;
              
            ActivePanel(true,1);
            lb_p1.Text = characterName[0];
            lb_p2.Text = characterName[0];

            #region button
            btn_Cp1.MouseHover += new EventHandler(ButtonHover);
            btn_Cp2.MouseHover += new EventHandler(ButtonHover);
            btn_Vp1.MouseHover += new EventHandler(ButtonHover);
            btn_Vp2.MouseHover += new EventHandler(ButtonHover);
            btn_nextP1.MouseHover += new EventHandler(ButtonHover);
            btn_nextP2.MouseHover += new EventHandler(ButtonHover);
            btn_prevP1.MouseHover += new EventHandler(ButtonHover);
            btn_prevP2.MouseHover += new EventHandler(ButtonHover);

            btn_Cp1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Cp2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Vp1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_Vp2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_nextP1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_nextP2.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_prevP1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_prevP2.FlatAppearance.MouseOverBackColor = Color.Transparent;



            btn_Cp1.MouseLeave += new EventHandler(ButtonLeave);
            btn_Cp2.MouseLeave += new EventHandler(ButtonLeave);
            btn_Vp1.MouseLeave += new EventHandler(ButtonLeave);
            btn_Vp2.MouseLeave += new EventHandler(ButtonLeave);
            btn_nextP1.MouseLeave += new EventHandler(ButtonLeave);
            btn_nextP2.MouseLeave += new EventHandler(ButtonLeave);
            btn_prevP1.MouseLeave += new EventHandler(ButtonLeave);
            btn_prevP2.MouseLeave += new EventHandler(ButtonLeave);

            btn_Cp1.Click += new EventHandler(ButtonClick);
            btn_Cp2.Click += new EventHandler(ButtonClick);
            btn_Vp1.Click += new EventHandler(ButtonClick);
            btn_Vp2.Click += new EventHandler(ButtonClick);
            btn_nextP1.Click += new EventHandler(ButtonClick);
            btn_nextP2.Click += new EventHandler(ButtonClick);
            btn_prevP1.Click += new EventHandler(ButtonClick);
            btn_prevP2.Click += new EventHandler(ButtonClick);
            #endregion


        }

        public ChooseCharacter()
        {

        }

        private void ChooseCharacter_Load(object sender, EventArgs e)
        {
        }

        public void ButtonHover(object o, EventArgs e)
        {
            Button bouton = o as Button;
            if (bouton.Text.Equals("VALIDER") || bouton.Text.Equals("ANNULER"))
                bouton.BackgroundImage = Properties.Resources.btn_hover;
            else if (bouton.Name.Equals("btn_nextP1") || bouton.Name.Equals("btn_nextP2"))
                bouton.BackgroundImage = Properties.Resources.nexthover;
            else
                bouton.BackgroundImage = Properties.Resources.lasthover;
        }
        
        public void ButtonLeave(object o, EventArgs e)
        {
            Button bouton = o as Button;
            if (bouton.Text.Equals("VALIDER") || bouton.Text.Equals("ANNULER"))
                bouton.BackgroundImage = Properties.Resources.btn_not_hover;
            else if (bouton.Name.Equals("btn_nextP1") || bouton.Name.Equals("btn_nextP2"))
                bouton.BackgroundImage = Properties.Resources.nextleave;
            else
                bouton.BackgroundImage = Properties.Resources.lastleave;
        }
        
        public void ButtonClick(object o, EventArgs e)
        {
            Button bouton = o as Button;

            if (bouton.Name.Equals(btn_Vp1.Name))
            {
                if(gParam.gameParam.gameMode == 2)
                {
                    ActivePanel(false,1);
                    gParam.gameParam.nameP1 = lb_p1.Text;
                }
                else
                {
                    gParam.gameParam.nameP1 = lb_p1.Text;
                    ActivePanel(false, 2);
                    switch (MessageBox.Show("COMMENCER LA PARTIE \n\nCANCEL POUR CHOISIR UN JOUEUR", "confirmation", MessageBoxButtons.YesNoCancel))
                    {
                        case DialogResult.Cancel:

                            break;
                        case DialogResult.Yes:
                            gParam.CacherControl(3);
                            break;
                        case DialogResult.No:
                            gParam.CacherControl(3);
                            break;
                        default:
                            break;
                    }
                }
            }
            else if (bouton.Name.Equals(btn_Cp1.Name))
            {
                ActivePanel(true, 2);
            }
            else if (bouton.Name.Equals(btn_Vp2.Name))
            {
                if(lb_p1.Text.Equals(lb_p2.Text))
                {
                    MessageBox.Show(lb_p1.Text+" déjà Choisis ");
                }
                else
                {
                    ActivePanel(false, 3);
                    gParam.gameParam.nameP2 = lb_p2.Text;
                    switch (MessageBox.Show("COMMENCER LA PARTIE /CANCEL POUR CHOISIR UN JOUEUR", "confirmation", MessageBoxButtons.YesNoCancel))
                    {
                        case DialogResult.Cancel:

                            break;                     
                        case DialogResult.Yes:
                            this.Hide();
                            break;
                        case DialogResult.No:
                            this.Hide();
                            break;
                        default:
                            break;
                    }
                    
                }
            }
            else if (bouton.Name.Equals(btn_Cp2.Name))
            {
                ActivePanel(true, 3);
            }
            else if (bouton.Name.Equals(btn_nextP1.Name))
            {
                if(indexch > character.Count - 1)
                {
                    indexch = 0;
                }
                lb_p1.Text = characterName[indexch];
                pb_p1.BackgroundImage = character[indexch];
                indexch++;
               
            }
            else if (bouton.Name.Equals(btn_prevP1.Name))
            {
                if(indexch > 0)
                {
                    indexch--;
                    lb_p1.Text = characterName[indexch];
                    pb_p1.BackgroundImage = character[indexch];
                }
                else
                {
                    indexch = characterName.Count - 1;
                }
               
            } 
            else if (bouton.Name.Equals(btn_nextP2.Name))
            {
                if(indexch > character.Count - 1)
                {
                    indexch = 0;
                }
                lb_p2.Text = characterName[indexch];
                pb_p2.BackgroundImage = character[indexch];
                indexch++;
               
            }
            else if (bouton.Name.Equals(btn_prevP2.Name))
            {
                if(indexch > 0)
                {
                    indexch--;
                    lb_p2.Text = characterName[indexch];
                    pb_p2.BackgroundImage = character[indexch];
                }
                else
                {
                    indexch = characterName.Count - 1;
                }
               
            }

        }

        public void ActivePanel(bool active,int panel)
        {
            switch (panel)
            {
                case 1:
                    pan_p1.Enabled = btn_Vp1.Enabled = active;
                    pan_p2.Enabled = btn_Vp2.Enabled = btn_Cp2.Enabled = !pan_p1.Enabled;
                    break;
                case 2:
                    pan_p1.Enabled = btn_Vp1.Enabled = active;
                    break;
                case 3:
                    pan_p2.Enabled = btn_Vp2.Enabled = active;
                    break;
                default:
                    break;
            }
        }

        private void pan_p1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void splitter1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }
    }
}
