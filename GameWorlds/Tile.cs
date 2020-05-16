using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using BOMBERMAN.GameObj;

namespace BOMBERMAN.GameWorlds
{
    class Tile : GameObjets
    {
        public bool IsDestoyable { get; set; }
        public bool IsFree { get; set; }
        public bool Occupied { get; set; }
        public bool Fire { get; set; }
        public Bonus bonus = null;
        public Bombe bomb = null;
        public int FireTime { get; set; }

        public Tile(Point pos, int dim) 
            :base(pos,dim,dim,1)
        {
            Occupied = false;
            Fire = false;
            FireTime = 300;          
        }

        public Tile()
        {

        }

        public override void DrawObject(Graphics gr)
        {
            if(Sprite != null)
            {
                gr.DrawImage(Sprite, Source, Source.Width*IndexFrame,0,Source.Width,Source.Height, GraphicsUnit.Pixel);
                if(!Fire && bonus == null && bomb == null)
                {
                    ControlPaint.DrawBorder(gr, Source, Color.LightGray, 5, ButtonBorderStyle.Inset,
                    Color.LightGray, 5, ButtonBorderStyle.Inset,
                    Color.LightGray, 5, ButtonBorderStyle.Inset,
                    Color.LightGray, 5, ButtonBorderStyle.Inset);
                }
                
            }
            else
            {
                gr.DrawRectangle(Pencil, Source);

                //gr.DrawString("L =" + CasePosition[0]+
                //    "C= " +CasePosition[1] , 
                //    new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular),
                //    new SolidBrush(Color.Black), Source);
                
                //gr.DrawString("O= " +Occupied +
                //    "S= " +IsFree+"D= "+IsDestoyable , 
                //    new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular),
                //    new SolidBrush(Color.Black), Source);
            }



        }


        public void GenBonus()
        {
            Random nbAlea = new Random();


            int line = CasePosition[0];
            int col = CasePosition[1];
            int nb = nbAlea.Next(1, 100);


            switch (nb)
            {
                case int n when n < 10:
                    bonus = new Bonus(new int[] { col, line }, 44, 44, 1,Bonus.Bonustype.LIFE);
                    bonus.LoadSprites(Properties.Resources.B_LIFE);
                    break;
                case int n when n < 50:
                    bonus = new Bonus(new int[] { col, line }, 44, 44, 1,Bonus.Bonustype.SPEED);
                    bonus.LoadSprites(Properties.Resources.B_SPEED);
                    break;
                case int n when n < 70:
                    bonus = new Bonus(new int[] { col, line }, 44, 44, 1,Bonus.Bonustype.D_SPEED);
                    bonus.LoadSprites(Properties.Resources.B_DSPEED);
                    break;

                default:
                    break;
            }
        }

    }
}
