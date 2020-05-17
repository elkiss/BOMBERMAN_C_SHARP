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
        private MainWindow gParam;
        public bool confirm;
        public GameMode(MainWindow mainForm)
        {
            InitializeComponent();

            int x, y;

            x = (mainForm.Width -Size.Width)/2;
            y = (mainForm.Height-Size.Height)/2;
            Location = new Point(x, y);

            gParam = mainForm;
            #region Button
            btn_solo.MouseHover += new EventHandler(ButtonHover);
            btn_multi.MouseHover += new EventHandler(ButtonHover);
            btn_c.MouseHover += new EventHandler(ButtonHover);

            btn_solo.MouseHover += new EventHandler(ButtonHover);
            btn_multi.MouseHover += new EventHandler(ButtonHover);
            btn_c.MouseHover += new EventHandler(ButtonHover); 
            
            btn_solo.Click += new EventHandler(ButtonClick);
            btn_multi.Click += new EventHandler(ButtonClick);
            btn_c.Click += new EventHandler(ButtonClick);

            btn_solo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_multi.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_c.FlatAppearance.MouseOverBackColor = Color.Transparent;

            btn_solo.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_multi.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btn_c.FlatAppearance.MouseOverBackColor = Color.Transparent;

            btn_solo.MouseLeave += new EventHandler(ButtonLeave);
            btn_multi.MouseLeave += new EventHandler(ButtonLeave);
            btn_c.MouseLeave += new EventHandler(ButtonLeave);
            #endregion
        }

        private void GameMode_Load(object sender, EventArgs e)
        {

        }


        public void ButtonHover(object o, EventArgs e)
        {
            Button b = o as Button;
            b.Cursor = Cursors.Hand;
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

            if (bouton.Name.Equals(btn_solo.Name))
            {
                gParam.gameParam.gameMode = 1;
                gParam.CacherControl(2);
            }
            else if (bouton.Name.Equals(btn_multi.Name))
            {
                gParam.gameParam.gameMode = 2;
                gParam.CacherControl(2);

            }
            else
            {
                gParam.CacherControl(3);
            }
        }

        private void GameMode_Paint(object sender, PaintEventArgs e)
        {
            confirm = false;
        }
    }
}
