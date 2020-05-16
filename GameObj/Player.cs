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
    class Player:GameCharacter
    {

        private int nbBombe;

        private int bombeEffect;

        public enum Character
        {
            WHITE,
            BLACK,
            RED,
            PINK,
        }

        private Character chPlayer;

        public Bonus.Bonustype Bonusplayer;

        #region Accessors

        public int NbBombe { get => nbBombe; set => nbBombe = value; }
        internal Character ChPlayer { get => chPlayer; set => chPlayer = value; }
        public int BombeEffect { get => bombeEffect; set => bombeEffect = value; }

        #endregion

        public Player(string pName,Point playerPos,int playerH,int playerW,int frameMax,int life)
            :base(playerPos,playerH,playerW,frameMax,life)
        {
            Vitesse = 10;
            PlayerSprites = new Dictionary<Direction, Image>
            {
                { Direction.UP, Properties.Resources.WB_UP },
                { Direction.DOWN, Properties.Resources.WB_DOWN },
                { Direction.RIGHT, Properties.Resources.WB_RIGHT },
                { Direction.LEFT, Properties.Resources.WB_LEFT }
            };

            PlayerName = pName;
            nbBombe = 1;
            Bonusplayer = Bonus.Bonustype.NONE;
            chPlayer = Character.BLACK;
            Pencil.Color = Color.Transparent;
            bombeEffect = 1;
        }
        
        public Player(string pName,int[] casePos,int playerH,int playerW,int frameMax,int life)
            :base(casePos,playerW,playerH,frameMax,life)
        {
            Vitesse = 10;
            PlayerSprites = new Dictionary<Direction, Image>
            {
                { Direction.UP, Properties.Resources.WB_UP },
                { Direction.DOWN, Properties.Resources.WB_DOWN },
                { Direction.RIGHT, Properties.Resources.WB_RIGHT },
                { Direction.LEFT, Properties.Resources.WB_LEFT }
            };
            nbBombe = 1;
            chPlayer = Character.BLACK;
            Bonusplayer = Bonus.Bonustype.NONE;
            Pencil.Color = Color.Transparent;
            bombeEffect = 1;
        }


        #region Player Actions

        public void DropBomb(List<Bombe> bombOnMap,Tile[,]tileMap)
        {
            int col = CasePosition[1]; 
            int line = CasePosition[0];

            if(nbBombe>0)
            {
                if(tileMap[col,line].IsFree)
                {
                    tileMap[col, line].bomb = new Bombe(new int[] { line, col }, 60,59,16,ChPlayer);
                    tileMap[col, line].IsFree = false;
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
