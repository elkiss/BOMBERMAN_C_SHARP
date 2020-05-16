using BOMBERMAN.GameObj;
using BOMBERMAN.GameWorlds;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BOMBERMAN
{
    class Game
    {
        private World map;

        private Rectangle gameArea;

        internal World Map { get => map; set => map = value; }
        internal List<Bombe> BombInGame { get => bombInGame; set => bombInGame = value; }

        private List<Bombe> bombInGame;

        public Game(Rectangle area, int playerNumber)
        {
            map = new World();
            map.CreateTiles(Properties.Resources.brickDest, Properties.Resources.briqueSolid, 60);
            gameArea = area;
            bombInGame = new List<Bombe>();
        }


        public void DrawMap(Graphics gr)
        {
            map.DrawWorldsTiles(gr);
            map.RefreshMap(gr);
        }

        public void KeyDownAction(Keys touch)
        {
            
                switch (touch)
                {
                    case Keys.Z:
                        map.Player1.mvnttDirection = Player.Direction.UP;
                        map.Player1.Sprite = map.Player1.PlayerSprites[Player.Direction.UP];
                        break;
                    case Keys.W:
                        map.Player1.mvnttDirection = Player.Direction.DOWN;
                        map.Player1.Sprite = map.Player1.PlayerSprites[Player.Direction.DOWN];
                    break;
                    case Keys.S:
                        map.Player1.mvnttDirection = Player.Direction.RIGHT;
                        map.Player1.Sprite = map.Player1.PlayerSprites[Player.Direction.RIGHT];
                    break;
                    case Keys.Q:
                        map.Player1.mvnttDirection = Player.Direction.LEFT;
                        map.Player1.Sprite = map.Player1.PlayerSprites[Player.Direction.LEFT];
                    break;
                case Keys.Space:
                    map.Player1.DropBomb(bombInGame, map.MapMatrice);
                    break;
                    case Keys.Up:
                        map.Player2.mvnttDirection = Player.Direction.UP;
                        map.Player2.Sprite = map.Player2.PlayerSprites[Player.Direction.UP];
                        break;
                    case Keys.Down:
                        map.Player2.mvnttDirection = Player.Direction.DOWN;
                        map.Player2.Sprite = map.Player2.PlayerSprites[Player.Direction.DOWN];
                    break;
                    case Keys.Right:
                        map.Player2.mvnttDirection = Player.Direction.RIGHT;
                        map.Player2.Sprite = map.Player2.PlayerSprites[Player.Direction.RIGHT];
                    break;
                    case Keys.Left:
                        map.Player2.mvnttDirection = Player.Direction.LEFT;
                        map.Player2.Sprite = map.Player2.PlayerSprites[Player.Direction.LEFT];
                    break;
                    default:
                        break;
            }
        }

        public void KeyUpAction(Keys touch)
        {
            switch (touch)
            {
                case Keys.S:
                    map.Player1.IndexFrame = 0;
                    map.Player1.mvnttDirection = Player.Direction.NONE;
                    break;
                case Keys.Q:
                    map.Player1.IndexFrame = 0;
                    map.Player1.mvnttDirection = Player.Direction.NONE;
                    break;
                case Keys.Z:
                    map.Player1.IndexFrame = 0;
                    map.Player1.mvnttDirection = Player.Direction.NONE; Z:
                    break;
                case Keys.W:
                    map.Player1.IndexFrame = 0;
                    map.Player1.mvnttDirection = Player.Direction.NONE;
                    break;
                case Keys.Right:
                    map.Player2.IndexFrame = 0;
                    map.Player2.mvnttDirection = Player.Direction.NONE;
                    break;
                case Keys.Left:
                    map.Player2.IndexFrame = 0;
                    map.Player2.mvnttDirection = Player.Direction.NONE;
                    break;
                case Keys.Up:
                    map.Player2.IndexFrame = 0;
                    map.Player2.mvnttDirection = Player.Direction.NONE;
                    break;
                case Keys.Down:
                    map.Player2.IndexFrame = 0;
                    map.Player2.mvnttDirection = Player.Direction.NONE;
                    break;
                default:
                    break;
            }

        }

        //gestion des déplacement des joueurs et de leurs collision avec les box
        public bool checkCollisionPlayer(Player player1,Player player2,Tile[,] tileMap,Player.Direction playerDirection)
        {
            int line = player1.CasePosition[0];
            int col =  player1.CasePosition[1];

            switch (playerDirection)
            {
                case Player.Direction.RIGHT:

                    Rectangle rect = new Rectangle(
                        player1.Source.X + player1.Vitesse,
                        player1.Source.Y,
                        player1.Source.Width,
                        player1.Source.Height);


                    if ((player1.Source.X + player1.Source.Width) >= gameArea.Width - 25)
                        return true;

                   

                    if (col < 8)
                    {
                        if (tileMap[col + 1, line].IsSolid)
                            if (CollisionBetweenRectagle(rect, tileMap[col + 1, line].Source))
                                return true;

                        if (line > 0)
                            if (CollisionBetweenRectagle(rect, tileMap[col + 1, line - 1].Source) && CollisionBetweenRectagle(rect, tileMap[col + 1, line].Source))
                                if (tileMap[col + 1, line - 1].IsSolid || tileMap[col + 1, line].IsSolid)
                                    return true;

                        if (tileMap[col + 1, line].Occupied && CollisionBetweenRectagle(rect,tileMap[col+1,line].Source))
                            return true;
                    }
                      

                    return false;

                case Player.Direction.LEFT:

                   rect = new Rectangle(
                       player1.Source.X-player1.Vitesse,
                       player1.Source.Y,
                       player1.Source.Width,
                       player1.Source.Height);

                    if (player1.Source.X <= 25)
                        return true;

                 

                    if (col <= 0)
                        return false;

                    if (tileMap[col - 1, line].Occupied && CollisionBetweenRectagle(rect, tileMap[col - 1, line].Source))
                        return true;

                    if (line > 0)
                        if (CollisionBetweenRectagle(rect, tileMap[col-1, line - 1].Source) && !tileMap[col -1, line].IsSolid)
                            return true;

                    if (tileMap[col-1, line].IsSolid)
                        if (CollisionBetweenRectagle(rect, tileMap[col-1, line].Source))
                            return true;

                    return false;

                case Player.Direction.DOWN:

                    rect = new Rectangle(
                       player1.Source.X,
                       player1.Source.Y + player1.Vitesse,
                       player1.Source.Width,
                       player1.Source.Height);

                    if (player1.Source.Y + player1.Source.Height >= gameArea.Height - 25)
                        return true;
                  

                    if (line >= 8)
                        return false;

                    if(line < 8)
                    {
                        if (tileMap[col, line + 1].Occupied && CollisionBetweenRectagle(rect, tileMap[col, line + 1].Source))
                            return true;

                        if (col <= 0)
                            if (CollisionBetweenRectagle(rect, tileMap[col, line + 1].Source) && tileMap[col, line + 1].IsSolid)
                                return true;

                        if (tileMap[col, line + 1].IsSolid)
                            if (CollisionBetweenRectagle(rect, tileMap[col, line + 1].Source))
                                return true;

                        if (col > 0)
                            if (CollisionBetweenRectagle(rect, tileMap[col - 1, line + 1].Source) && CollisionBetweenRectagle(rect, tileMap[col, line + 1].Source))
                                if (tileMap[col - 1, line + 1].IsSolid || tileMap[col, line + 1].IsSolid)
                                    return true;

                    }


                    return false;

                case Player.Direction.UP:

                    rect = new Rectangle(
                       player1.Source.X,
                       player1.Source.Y-player1.Vitesse,
                       player1.Source.Width,
                       player1.Source.Height);

                    if (player1.Source.Y <= 25)
                        return true;

                  

                    if (line > 0)
                    {
                        if (tileMap[col, line - 1].IsSolid)
                            if (CollisionBetweenRectagle(rect, tileMap[col, line - 1].Source))
                                return true;
                        if(col > 0)
                            if (CollisionBetweenRectagle(rect, tileMap[col - 1, line - 1].Source) && CollisionBetweenRectagle(rect, tileMap[col, line - 1].Source))
                                if (tileMap[col - 1, line - 1].IsSolid || tileMap[col, line - 1].IsSolid)
                                    return true;

                        if (tileMap[col, line - 1].Occupied && CollisionBetweenRectagle(rect, tileMap[col, line -1].Source))
                            return true;
                    }

                    return false;

                case Player.Direction.NONE:
                    return false;
                default:
                    return false;

            }
        }

        public bool CollisionBetweenRectagle(Rectangle rect1,Rectangle rect2)
        {
            if (rect1.IntersectsWith(rect2))
                return true;
            else
                return false;
        }

        public void PlayersLogic()
        {
            map.Player1.CheckLocation(60);
            map.Player2.CheckLocation(60);

            if(map.Player1.mvnttDirection != Player.Direction.NONE)
            {
                if (!checkCollisionPlayer(map.Player1, null, map.MapMatrice, map.Player1.mvnttDirection))
                {
                    map.Player1.MoveToDirection();
                }
                map.Player1.UpdateFrame(50);

                //map.Player2.IndexFrame = 1;
            } 
            
            if(map.Player2.mvnttDirection != Player.Direction.NONE)
            {
                if (!checkCollisionPlayer(map.Player2, null, map.MapMatrice, map.Player2.mvnttDirection))
                {
                    map.Player2.MoveToDirection();
                }
                map.Player2.UpdateFrame(50);

                //map.Player2.IndexFrame = 1;
            }
        }

        public void BombeLogic()
        {
            List<Bombe> toRemove = new List<Bombe>();
            foreach (Bombe bombe in bombInGame)
            {
                bombe.UpdateFrame(50);
                bombe.ExplosionTiming(20);

                if(bombe.IsExplosed)
                {
                    bombe.Propagation(map.Player1, map.Player2, map.MapMatrice);
                    toRemove.Add(bombe);

                }

            }

            for (int i = 0; i < toRemove.Count; i++)
            {
                if (toRemove[i].DetonTime <= 0 && toRemove[i].IsExplosed)
                    bombInGame.Remove(toRemove[i]);
            }

        }

        public void Interraction()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if(map.MapMatrice[i,j].Fire)
                    {
                        map.MapMatrice[i, j].Occupied = false;
                        if (CollisionBetweenRectagle(map.Player1.Source, map.MapMatrice[i,j].Source))
                        {
                            if(!map.Player1.Bonusplayer.Contains (Bonus.Bonustype.ARMOR))
                            {
                                map.Player1.IsAlive = false;
                                //map.MapMatrice[i, j].Fire = false;
                                //load bood sprite
                            }
                        }
                        else if(CollisionBetweenRectagle(map.Player2.Source, map.MapMatrice[i, j].Source))
                        {
                            if (!map.Player2.Bonusplayer.Contains(Bonus.Bonustype.ARMOR))
                            {
                                map.Player2.IsAlive = false;
                                //load bood sprite
                            }
                        }
                        else if(map.MapMatrice[i,j].FireTime <= 0)
                        {
                            map.MapMatrice[i, j].FireTime = 300;// à revoire avec temp timer
                            map.MapMatrice[i, j].Fire = false;
                            map.MapMatrice[i, j].IndexFrame = 0;
                        }
                        else
                        {
                            map.MapMatrice[i, j].FireTime -= 100;
                        }
                        map.MapMatrice[i, j].UpdateFrame(50);
                    }
                }
            }
        }
        
        public void BonusLogic()
        {

        }
        
        
        
        
        
        
        
        
        
        
        
        
        
        //ftn test
        public string NextCase(Keys touch)
        {
            switch (touch)
            {
                case Keys.Z:
                    map.Player2.mvnttDirection = Player.Direction.UP;
                    return "line: " + map.Player2.CasePosition[1] + " col: " + (map.Player2.CasePosition[0] - 1);
                case Keys.W:
                    map.Player2.mvnttDirection = Player.Direction.DOWN;
                    return "line: " + map.Player2.CasePosition[1] + " col: " + (map.Player2.CasePosition[0] + 1);
                case Keys.S:
                    map.Player2.mvnttDirection = Player.Direction.RIGHT;
                    return "line: " + (map.Player2.CasePosition[1] ) + " col: " + (map.Player2.CasePosition[0]+1);
                case Keys.Q:
                    map.Player2.mvnttDirection = Player.Direction.LEFT;
                    return "line: " + (map.Player2.CasePosition[1]) + " col: " + (map.Player2.CasePosition[0]-1);
                default:
                    return "";
            }
        }
    }
}
