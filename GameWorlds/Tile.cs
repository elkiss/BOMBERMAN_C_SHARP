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
using System.range

namespace BOMBERMAN.GameWorlds
{
    class Tile : GameObjets
    {
        public bool IsDestoyable { get; set; }
        public bool IsSolid { get; set; }
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
            FireTime = 500;          
        }

        public Tile()
        {

        }

        public override void DrawObject(Graphics gr)
        {
            if(Sprite != null)
            {
                gr.DrawImage(Sprite, Source, Source.Width*IndexFrame,0,Source.Width,Source.Height, GraphicsUnit.Pixel);
                if(!Fire)
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
                
                gr.DrawString("O= " +Occupied +
                    "S= " +IsSolid+"D= "+IsDestoyable , 
                    new Font(FontFamily.GenericSansSerif, 7, FontStyle.Regular),
                    new SolidBrush(Color.Black), Source);
            }



        }


        public void GenBonus()
        {
            Random nbAlea = new Random();

            

            int nb = nbAlea.Next(1, 100);

            switch (nb)
            {
                case 1...10:
                    bonus = new Bonus(CasePosition, 44, 44, 1,Bonus.Bonustype.LIFE);
                    bonus.LoadSprites(Properties.Resources.B_LIFE);
                    break;
                case 10 - 30:
                    bonus = new Bonus(CasePosition, 44, 44, 1,Bonus.Bonustype.LAUNCH);
                    bonus.LoadSprites(Properties.Resources.B_LAUNCH);
                    break;
                case 30 - 40:
                    bonus = new Bonus(CasePosition, 44, 44, 1,Bonus.Bonustype.KICK);
                    bonus.LoadSprites(Properties.Resources.B_KICK);
                    break;
                case 40 - 70:
                    bonus = new Bonus(CasePosition, 44, 44, 1,Bonus.Bonustype.D_SPEED);
                    bonus.LoadSprites(Properties.Resources.B_DSPEED);
                    break;
                case 70 - 110:
                    bonus = new Bonus(CasePosition, 44, 44, 1,Bonus.Bonustype.EFFECT);
                    bonus.LoadSprites(Properties.Resources.B_BOMB);
                    break;
                case 120 - 180:
                    bonus = new Bonus(CasePosition, 44, 44, 1,Bonus.Bonustype.SPEED);
                    bonus.LoadSprites(Properties.Resources.B_SPEED);
                    break;
                case 190 - 240:
                    bonus = new Bonus(CasePosition, 44, 44, 1,Bonus.Bonustype.KICK);
                    bonus.LoadSprites(Properties.Resources.B_KICK);
                    break;
                case 250 - 350:
                    bonus = new Bonus(CasePosition, 44, 44, 1,Bonus.Bonustype.DISAMORCE);
                    bonus.LoadSprites(Properties.Resources.B_DISM);
                    break;

                default:
                    break;
            }
        }

    }
}
