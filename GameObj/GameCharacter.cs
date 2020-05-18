using BOMBERMAN.GameWorlds;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOMBERMAN.GameObj
{
    class GameCharacter:GameObjets
    {
        private int vitesse;

        public int Life { get; set; }

        public bool IsAlive { get; set; }


        public enum Direction
        {
            RIGHT,
            LEFT,
            UP,
            DOWN,
            DEAD,
            WIN,
            NONE
        }


        public Direction mvnttDirection;

        private IDictionary<Direction, Image> playerSprites;//a modifier

        #region Accessors

        public int Vitesse { get => vitesse; set => vitesse = value; }
        internal IDictionary<Direction, Image> PlayerSprites { get => playerSprites; set => playerSprites = value; }

        #endregion

        public GameCharacter(Point playerPos, int playerH, int playerW, int frameMax, int life)
            : base(playerPos, playerW, playerH, frameMax)
        {
          
            mvnttDirection = Direction.NONE;
            this.Life = life;
            IsAlive = true;
            Pencil.Color = Color.Transparent;
        }

        public GameCharacter(int[] casePos, int playerH, int playerW, int frameMax, int life)
            : base(casePos, playerW, playerH, frameMax)
        {

            mvnttDirection = Direction.NONE;
            this.Life = life;
            IsAlive = true;
        }

        public void CheckLocation(int tileSize)
        {
            CasePosition[1] = (((Source.X + Source.Width) - 50) / tileSize); //colonne
            CasePosition[0] = (((Source.Y + Source.Height) - 50) / tileSize);//ligne

            if (CasePosition[1] > 8)
                CasePosition[1] = 8;
            if (CasePosition[0] > 8)
                CasePosition[0] = 8;

        }

        public void MoveToDirection()
        {
            switch (mvnttDirection)
            {
                case Direction.RIGHT:
                    MoveRigth();
                    break;
                case Direction.LEFT:
                    MoveLeft();
                    break;
                case Direction.UP:
                    MoveUp();
                    break;
                case Direction.DOWN:
                    MoveDown();
                    break;
                case Direction.NONE:
                    break;
                default:
                    break;
            }
        }

        public void MoveRigth()
        {
            MoveObject(vitesse, 0);
        }

        public void MoveLeft()
        {
            MoveObject(-vitesse, 0);
        }

        public void MoveUp()
        {
            MoveObject(0, -vitesse);
        }

        public void MoveDown()
        {
            MoveObject(0, vitesse);
        }



    }
}
