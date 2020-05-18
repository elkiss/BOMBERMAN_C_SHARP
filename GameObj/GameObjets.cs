using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOMBERMAN.GameObj
{
    class GameObjets
    {
        private Rectangle source;


        private Image sprite;


        private int frameMax;

        private int indexFrame;

        private float frameSpeed;

        private int totalElapsedTime;

        private int[] casePosition;

        protected Pen Pencil { get; set; }



        #region accessors

        public Rectangle Source { get => source; set => source = value; }
        public Image Sprite { get => sprite; set => sprite = value; }
        public Point PosUpdate { get => source.Location; set => source.Location=value; }
        public int IndexFrame { get => indexFrame; set => indexFrame = value; }

        public int[] CasePosition { get => casePosition; 
            set 
            {
                casePosition = value;

            } 
        }

        public int FrameMax { get => frameMax; set => frameMax = value; }
        public float FrameSpeed { get => frameSpeed; set => frameSpeed = value; }

        #endregion

        public GameObjets(Point ObjLocation,int objSizeH,int objSizeW,int frameMax)
        {
            source = new Rectangle(ObjLocation, new Size(objSizeH, objSizeW));
            Pencil = new Pen(new SolidBrush(Color.Transparent), 2);
            indexFrame = 0;
            casePosition = new int[2] { 0, 0 };
            this.frameMax = frameMax;
            frameSpeed = 100000;


        }
        
        public GameObjets(int[] casePos,int objSizeH,int objSizeW,int frameMax)
        {

            int x = (casePos[1] * 60);
            int y = (casePos[0] * 60);

            source = new Rectangle(new Point(x+25,y+25), new Size(objSizeH, objSizeW));
            Pencil = new Pen(new SolidBrush(Color.Black), 2);
            indexFrame = 0;
            casePosition = casePos;
            this.frameMax = frameMax;
            frameSpeed = 100;
        }

        public GameObjets()
        {
            
        }

        public void LoadSprites(Image spr)
        {
            sprite = spr;
        }

        public void UnloadSprite()
        {
            sprite = null;
        }

        public virtual  void DrawObject(Graphics gr)
        {
            if(sprite != null)
            {
                gr.DrawImage(Sprite, source, source.Width*indexFrame,0,source.Width,source.Height, GraphicsUnit.Pixel);
                gr.DrawString("" + CasePosition[0] + " " + CasePosition[1], new Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular), new SolidBrush(Color.Red), Source);
                gr.DrawRectangle(Pencil, source);

            }
            else
            {
                gr.DrawRectangle(Pencil, source);

            }
        }

        public void UpdateFrame(int elapsedtime)
        {
            totalElapsedTime += elapsedtime;

            if(totalElapsedTime >= frameSpeed)
            {
                totalElapsedTime = 0;
               
                    indexFrame++;

                if (indexFrame >= frameMax)
                    indexFrame = 0;
            }
        }

        public virtual void MoveObject(int mX,int mY)
        {
            source.X += mX;
            source.Y += mY;
        }
        

  

       
    }
}
