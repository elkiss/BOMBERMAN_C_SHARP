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
            BLUE,
            MAROON,
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

        public Player(Point playerPos,int playerH,int playerW,int frameMax,int life)
            :base(playerPos,playerH,playerW,frameMax,life)
        {
            Vitesse = 10;
            nbBombe = 1;
            Bonusplayer = Bonus.Bonustype.NONE;
            Pencil.Color = Color.Black;
            bombeEffect = 1;
        }
        
        public Player(int[] casePos,int playerH,int playerW,int frameMax,int life)
            :base(casePos,playerW,playerH,frameMax,life)
        {
            Vitesse = 10;
            nbBombe = 1;
            Bonusplayer = Bonus.Bonustype.NONE;
            Pencil.Color = Color.Black;
            bombeEffect = 1;
        }

        public void Load(Image[] Sprites, string pCharacter)
        {
            PlayerSprites = new Dictionary<Direction, Image>
            {
                { Direction.RIGHT, Sprites[0]},
                { Direction.LEFT, Sprites[1] },
                { Direction.UP, Sprites[2] },
                { Direction.DOWN, Sprites[3] },
                { Direction.DEAD, Sprites[4]},
                { Direction.WIN, Sprites[5] },
            };

            switch (pCharacter)
            {
                case "WHITE":
                    ChPlayer = Character.WHITE;
                    break;
                case "BLACK":
                    ChPlayer = Character.BLACK;
                    break;
                case "BLUE":
                    ChPlayer = Character.BLUE;
                    break;
                case "MAROON":
                    ChPlayer = Character.MAROON;
                    break;
                default:
                    break;
            }

            LoadSprites(PlayerSprites[Direction.DOWN]);
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
