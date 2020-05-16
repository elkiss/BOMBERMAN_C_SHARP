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
    class Player:GameObjets
    {
        private int vitesse;

        public string PlayerName { get; set; }

        public int Life { get; set; }

        public bool IsAlive { get; set; }

        private int nbBombe;

        private int bonusMax;

        private int bombeEffect;

        public enum Character
        {
            WHITE,
            BLACK,
            RED,
            PINK,
        }

        private Character chPlayer;

        public enum Direction
        {
            RIGHT,
            LEFT,
            UP,
            DOWN,
            NONE
        }

        public Bonus.Bonustype Bonusplayer;

        public Direction mvnttDirection;

        private IDictionary<Direction, Image> playerSprites;

        #region Accessors

        public int Vitesse { get => vitesse; set => vitesse = value; }
        internal IDictionary<Direction, Image> PlayerSprites { get => playerSprites; set => playerSprites = value; }
        public int NbBombe { get => nbBombe; set => nbBombe = value; }
        internal Character ChPlayer { get => chPlayer; set => chPlayer = value; }
        public int BombeEffect { get => bombeEffect; set => bombeEffect = value; }
        public int BonusMax { get => bonusMax; set => bonusMax = value; }

        #endregion

        public Player(string pName,Point playerPos,int playerH,int playerW,int frameMax,int life)
            :base(playerPos,playerH,playerW,frameMax)
        {
            vitesse = 10;
            playerSprites = new Dictionary<Direction, Image>
            {
                { Direction.UP, Properties.Resources.WB_UP },
                { Direction.DOWN, Properties.Resources.WB_DOWN },
                { Direction.RIGHT, Properties.Resources.WB_RIGHT },
                { Direction.LEFT, Properties.Resources.WB_LEFT }
            };
            mvnttDirection = Direction.NONE;
            this.Life = life;
            IsAlive = true;
            PlayerName = pName;
            nbBombe = 1;
            Bonusplayer = Bonus.Bonustype.NONE;
            chPlayer = Character.BLACK;
            Pencil.Color = Color.Transparent;
            bombeEffect = 1;
            bonusMax = 1;
        }
        
        public Player(string pName,int[] casePos,int playerH,int playerW,int frameMax,int life)
            :base(casePos,playerH,playerW,frameMax)
        {
            vitesse = 10;
            playerSprites = new Dictionary<Direction, Image>
            {
                { Direction.UP, Properties.Resources.WB_UP },
                { Direction.DOWN, Properties.Resources.WB_DOWN },
                { Direction.RIGHT, Properties.Resources.WB_RIGHT },
                { Direction.LEFT, Properties.Resources.WB_LEFT }
            };
            mvnttDirection = Direction.NONE;
            this.Life = life;
            IsAlive = true;
            nbBombe = 1;
            chPlayer = Character.BLACK;
            Bonusplayer = Bonus.Bonustype.NONE;
            Pencil.Color = Color.Transparent;
            bombeEffect = 1;
            bonusMax = 1;
            //Bonusplayer = new List<Bonus>();
        }

        public void CheckLocation(int tileSize)
        {
            CasePosition[1] = (((Source.X + Source.Width)-35)/tileSize); //colonne
            CasePosition[0] = (((Source.Y + Source.Height)-35)/tileSize);//ligne

            //CasePosition[1] = Source.Y/ tileSize;
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


        #region Player Actions

        public void DropBomb(List<Bombe> bombOnMap,Tile[,]tileMap)
        {
            int col = CasePosition[1]; 
            int line = CasePosition[0];

            if(nbBombe>0)
            {
                if(!tileMap[col,line].Occupied)
                {
                    tileMap[col, line].bomb = new Bombe(new int[] { line, col }, 60,59,16,ChPlayer);
                    tileMap[col, line].bomb.actived = true;
                    tileMap[col, line].Occupied = true;
                    tileMap[col, line].bomb.LoadSprites(Properties.Resources.Bombe);
                    tileMap[col, line].bomb.FrameMax = 16;
                    tileMap[col, line].bomb.FrameSpeed = 50;
                    bombOnMap.Add(tileMap[col, line].bomb);
                    nbBombe--;
                }
            }
        }
            
        #endregion
    }
}
