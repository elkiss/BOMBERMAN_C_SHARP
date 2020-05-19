using BOMBERMAN.GameObj;
using System;
using System.Drawing;

namespace BOMBERMAN.GameWorlds
{
    [Serializable]
    public class World
    {
        private Tile[,] mapMatrice;
        private Player player1, player2;

        internal Tile[,] MapMatrice { get => mapMatrice; set => mapMatrice = value; }
        internal Player Player1 { get => player1; set => player1 = value; }
        internal Player Player2 { get => player2; set => player2 = value; }

        public World(Image[] p1Sprites, Image[] p2Sprites, MainWindow.Gameparam gameparam)
        {
            mapMatrice = new Tile[9, 9];

            player1 = new Player(new int[] { 0, 0 }, 27, 40, 3, 0);
            player1.Load(p1Sprites, gameparam.nameP1);


            player2 = new Player(new int[] { 8, 8 }, 27, 40, 3, 0);
            Player2.Load(p2Sprites, gameparam.nameP2);
            
        }

        public World(Image[] p1Sprites, Image[] p2Sprites, GameState access)
        {
            mapMatrice = access.timap;
            player1 = access.p1;
            player1.LoadSavedState(p1Sprites, access.p1.ChPlayer, GameCharacter.Direction.NONE);
            player2 = access.p2;
            player2.LoadSavedState(p2Sprites, access.p2.ChPlayer, GameCharacter.Direction.NONE);
        }

        public void LoadTiles()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (mapMatrice[i, j].IsDestoyable)
                    {
                        mapMatrice[i, j].LoadSprites(Properties.Resources.brickDest);
                    }
                    else if(!mapMatrice[i, j].IsDestoyable)
                    {
                        mapMatrice[i, j].LoadSprites(Properties.Resources.briqueSolid);
                    }
                    else if (mapMatrice[i, j].Fire)
                    {
                        mapMatrice[i, j].LoadSprites(Properties.Resources.FIRE);
                    }
                    else
                    {
                        mapMatrice[i, j].UnloadSprite();
                    }

                    if (mapMatrice[i, j].bonus != null)
                    {
                        switch (mapMatrice[i, j].bonus.BonusTtype)
                        {
                            case Bonus.Bonustype.BOMBE:
                                mapMatrice[i, j].bonus.LoadSprites(Properties.Resources.B_BOMB);
                                break;
                            case Bonus.Bonustype.SPEED:
                                mapMatrice[i, j].bonus.LoadSprites(Properties.Resources.B_SPEED);
                               break;
                            case Bonus.Bonustype.D_SPEED:
                                mapMatrice[i, j].bonus.LoadSprites(Properties.Resources.B_DBOMB);
                                break;
                            case Bonus.Bonustype.LIFE:
                                mapMatrice[i, j].bonus.LoadSprites(Properties.Resources.B_LIFE);
                                break;
                            case Bonus.Bonustype.EFFECT:
                                mapMatrice[i, j].bonus.LoadSprites(Properties.Resources.B_EFFECT);
                                break;
                            case Bonus.Bonustype.D_EFFET:
                                mapMatrice[i, j].bonus.LoadSprites(Properties.Resources.B_DEFFECT);
                                break;
                            case Bonus.Bonustype.NONE:
                                break;
                            default:
                                break;
                        }
                    }

                }
            }
        }

        public void CreateTiles(Image tileDest, Image tileNotDest, int tilesSize)
        {
            Random nbalea = new Random();
            int t;
            int dTile = 20;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (j % 2 != 0 && i % 2 != 0)
                    {
                        mapMatrice[i, j] = new Tile(new Point(i * tilesSize + 25, j * tilesSize + 25), tilesSize);
                        mapMatrice[i, j].CasePosition = new int[] { i, j };
                        mapMatrice[i, j].LoadSprites(tileNotDest);
                        mapMatrice[i, j].IsDestoyable = false;
                        mapMatrice[i, j].IsFree = false;
                        mapMatrice[i, j].Occupied = true;//?

                    }
                    else
                    {
                        if (dTile > 0)
                        {
                            t = nbalea.Next(1, 5);
                            if (t % 2 == 0)
                            {
                                mapMatrice[i, j] = new Tile(new Point(i * tilesSize + 25, j * tilesSize + 25), tilesSize);
                                mapMatrice[i, j].UnloadSprite();
                                mapMatrice[i, j].IsDestoyable = false;
                                mapMatrice[i, j].IsFree = true;
                                mapMatrice[i, j].Occupied = false;//?
                                mapMatrice[i, j].CasePosition = new int[] { i, j };
                            }
                            else
                            {
                                mapMatrice[i, j] = new Tile(new Point(i * tilesSize + 25, j * tilesSize + 25), tilesSize);
                                mapMatrice[i, j].LoadSprites(tileDest);
                                mapMatrice[i, j].IsDestoyable = true;
                                mapMatrice[i, j].IsFree = false;
                                mapMatrice[i, j].Occupied = true;//?
                                mapMatrice[i, j].CasePosition = new int[] { i, j };
                                dTile--;
                            }

                        }
                        else
                        {
                            mapMatrice[i, j] = new Tile(new Point(i * tilesSize + 25, j * tilesSize + 25), tilesSize);
                            mapMatrice[i, j].UnloadSprite();
                            mapMatrice[i, j].IsDestoyable = false;
                            mapMatrice[i, j].IsFree = true;
                            mapMatrice[i, j].Occupied = false;//?
                            mapMatrice[i, j].CasePosition = new int[] { i, j };
                        }
                    }


                }
            }

        }

        public void DrawWorldsTiles(Graphics gr)
        {
            for (int i = 0; i < 9; i++)
                for (int j = 0; j < 9; j++)
                {
                    mapMatrice[i, j].DrawObject(gr);

                }
        }

        public void RefreshMap(Graphics gr)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (mapMatrice[i, j].Fire)
                    {
                        mapMatrice[i, j].LoadSprites(Properties.Resources.FIRE);
                    }
                    else if (mapMatrice[i, j].IsFree)
                    {
                        mapMatrice[i, j].UnloadSprite();
                    }
                    if (mapMatrice[i, j].bonus != null)
                    {
                        mapMatrice[i, j].bonus.DrawObject(gr);
                    }

                    mapMatrice[i, j].DrawObject(gr);

                }
            }

            DrawWorldsTiles(gr);

            player1.DrawObject(gr);

            if(player2 != null)
                player2.DrawObject(gr);
        }

        public void LoadPlayerOnMap(Graphics gr)
        {
            int line = player1.CasePosition[0];
            int col = player1.CasePosition[1];

            for (int i = 0; i < 4; i++)
            {
                mapMatrice[line, i].UnloadSprite();
                mapMatrice[line, i].IsFree = true;
                mapMatrice[line, i].Occupied = false;
                mapMatrice[line, i].IsDestoyable = false;
                mapMatrice[i, col].UnloadSprite();
                mapMatrice[i, col].IsFree = true;
                mapMatrice[i, col].Occupied = false;
                mapMatrice[i, col].IsDestoyable = false;
            }

            player1.DrawObject(gr);

            if (player2 != null)
            {
                for (int i = 4; i > 0; i--)
                {
                    mapMatrice[8, i].UnloadSprite();
                    mapMatrice[8, i].IsFree = true;
                    mapMatrice[8, i].Occupied = false;
                    mapMatrice[8, i].IsDestoyable = false;
                    mapMatrice[i, 8].UnloadSprite();
                    mapMatrice[i, 8].IsFree = true;
                    mapMatrice[i, 8].Occupied = false;
                    mapMatrice[i, 8].IsDestoyable = false;

                }

                player2.DrawObject(gr);
            }
           
           
        }


    }
}
