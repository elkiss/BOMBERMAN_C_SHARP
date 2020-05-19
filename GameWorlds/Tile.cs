using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using BOMBERMAN.GameObj;

namespace BOMBERMAN.GameWorlds
{
    [Serializable]
    public class Tile : GameObjets
    {
        public bool IsDestoyable { get; set; }
        public bool IsFree { get; set; }
        public bool Occupied { get; set; }
        public bool Fire { get; set; }
        public Bonus bonus = null;
        public Bombe bomb = null;
        public int FireTime { get; set;}

        [NonSerialized]
        static Random aleanb;

        public Tile(Point pos, int dim) 
            :base(pos,dim,dim,1)
        {
            Occupied = false;
            Fire = false;
            aleanb = new Random();
            FireTime = 500;          
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
                if(Pencil == null)
                    Pencil = new Pen(new SolidBrush(Color.Transparent), 0);

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


            int line = CasePosition[0];
            int col = CasePosition[1];

            if (aleanb == null)
                aleanb = new Random();

            int nb = aleanb.Next(1, 100);


            switch (nb)
            {
                case int n when n < 10:
                    bonus = new Bonus(new int[] { col, line }, 44, 44, 1,Bonus.Bonustype.LIFE);
                    bonus.LoadSprites(Properties.Resources.B_LIFE);
                    break;
                case int n when n < 20:
                    bonus = new Bonus(new int[] { col, line }, 44, 44, 1,Bonus.Bonustype.SPEED);
                    bonus.LoadSprites(Properties.Resources.B_SPEED);
                    break;
                case int n when n < 40:
                    bonus = new Bonus(new int[] { col, line }, 44, 44, 1,Bonus.Bonustype.D_SPEED);
                    bonus.LoadSprites(Properties.Resources.B_DSPEED);
                    break;
                case int n when n < 60:
                    bonus = new Bonus(new int[] { col, line }, 44, 44, 1, Bonus.Bonustype.EFFECT);
                    bonus.LoadSprites(Properties.Resources.B_EFFECT);
                    break;
                case int n when n < 80:
                    bonus = new Bonus(new int[] { col, line }, 44, 44, 1, Bonus.Bonustype.D_EFFET);
                    bonus.LoadSprites(Properties.Resources.B_DEFFECT);
                    break;

                default:
                    break;
            }
        }

    }
}
