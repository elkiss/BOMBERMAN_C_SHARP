using BOMBERMAN.GameWorlds;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BOMBERMAN.GameObj
{
    class Bombe : GameObjets, IDisposable    
    {
        private int detonTime;

        private int effect;

        public bool IsExplosed { get; set; }

        public bool Disamorced { get; set; }


        public int DetonTime { get => detonTime; set => detonTime = value; }
        internal Player.Character Who { get => who; set => who = value; }

        private Player.Character who;

        public Bombe(int[] casePos,int fHeigth,int fWidth,int nbframe,Player.Character who)
            :base(casePos,fWidth,fHeigth,nbframe)
        {
            IsExplosed = false;
            Disamorced = false;
            detonTime = 3000;
            this.who = who;
            effect = 1;
            Pencil.Color = Color.Transparent;
            Pencil.Width = 5;
      
        }

        public void ExplosionTiming(int timeElapsed)
        {
            if (detonTime <= 0)
            {
                IsExplosed = true;
            }
            else
                detonTime -= timeElapsed;

        }

        public void Propagation(Player p1, Player p2,Tile[,] tileMap)
        {
            int line = CasePosition[0];
            int col =  CasePosition[1];

            bool pUP, pDown, PLeft, pRight;

            pUP = pDown = PLeft = pRight = true;

            if (col <= 0)
                PLeft = false;
            if (col >= 8)
                pRight = false;
            if (line <= 0)
                pUP = false;
            if (line >= 8)
                pDown = false;

            if(p1 != null)
                if (who == p1.ChPlayer)
                {
                    p1.NbBombe++;
                    effect = p1.BombeEffect;
                }
            if (p2 != null)
                if (who == p2.ChPlayer)
                {
                    p2.NbBombe++;
                    effect = p2.BombeEffect;
                }

            if (PLeft)
            {
                for (int i = 1; i <= effect; i++)
                {
                    if(col - i >= 0)
                    {

                        if(!tileMap[col - i,line].IsDestoyable && !tileMap[col - i,line].IsFree)
                        {
                            break;
                        }
                        if(tileMap[col - i,line].IsDestoyable)
                        {
                            tileMap[col - i, line].Fire = true;
                            tileMap[col - i, line].bomb = null;
                            tileMap[col - i, line].IsDestoyable = false;
                            tileMap[col - i, line].IsFree = true;
                            tileMap[col - i, line].Occupied = false;//?
                            tileMap[col - i, line].GenBonus();

                        }
                        else if (tileMap[col - i, line].IsFree)
                        {
                            tileMap[col - i, line].Fire = true;
                        }
                    }
                }
            } 
            
            if (pRight)
            {
                for (int i = 1; i <= effect; i++)
                {
                    if(col + i <= 8)
                    {
                        if(!tileMap[col + i,line].IsDestoyable && !tileMap[col + i, line].IsFree)
                        {
                            break;
                        }
                        if (tileMap[col + i, line].IsDestoyable)
                        {
                            tileMap[col + i, line].Fire = true;
                            tileMap[col + i, line].bomb = null;
                            tileMap[col + i, line].IsDestoyable = false;
                            tileMap[col + i, line].IsFree = true;
                            tileMap[col + i, line].Occupied = false;//?
                            tileMap[col + i, line].GenBonus();
                        }
                        else if(tileMap[col + i, line].IsFree)
                        {
                            tileMap[col + i, line].Fire = true;
                        }
                    }
                }

            }
            
            if (pUP)
            {
                for (int i = 1; i <= effect; i++)
                {
                    if(line - i >= 0)
                    {
                        if(!tileMap[col,line - i].IsDestoyable && !tileMap[col, line - i].IsFree)
                        {
                            break;
                        }
                        if (tileMap[col, line - i].IsDestoyable)
                        {
                            tileMap[col, line - i].Fire = true;
                            tileMap[col, line - i].bomb = null;
                            tileMap[col, line - i].IsDestoyable = false;
                            tileMap[col, line - i].IsFree = true;
                            tileMap[col, line - i].Occupied = false;//?
                            tileMap[col, line - i].GenBonus();
                        }
                        else if(tileMap[col, line - i].IsFree)
                        {
                            tileMap[col, line - i].Fire = true;

                        }
                    }
                }

            }
            
            if (pDown)
            {
                for (int i = 1; i <= effect; i++)
                {
                    if(line + i <= 8)
                    {
                        if(!tileMap[col, line + i].IsDestoyable && !tileMap[col, line + i].IsFree)
                        {
                            break;
                        }
                        if (tileMap[col, line + i].IsDestoyable)
                        {
                            tileMap[col, line + i].Fire = true;
                            tileMap[col, line + i].bomb = null;
                            tileMap[col, line + i].IsDestoyable = false;
                            tileMap[col, line + i].IsFree = true;
                            tileMap[col, line + i].Occupied = false;//?
                            tileMap[col, line + i].GenBonus();
                        }
                        else if (tileMap[col, line + i].IsFree)
                        {
                            tileMap[col, line + i].Fire = true;
                        }
                    }
                }
            }


            tileMap[col, line].bomb = null;
            tileMap[col, line].IsFree = true;
            tileMap[col, line].Fire = true;
        }
        #region IDisposable Support
        private bool disposedValue = false; // Pour détecter les appels redondants

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    // TODO: supprimer l'état managé (objets managés).
                    Sprite = null;
                     
                }

                // TODO: libérer les ressources non managées (objets non managés) et remplacer un finaliseur ci-dessous.
                // TODO: définir les champs de grande taille avec la valeur Null.

                disposedValue = true;
            }
        }

        // TODO: remplacer un finaliseur seulement si la fonction Dispose(bool disposing) ci-dessus a du code pour libérer les ressources non managées.
        // ~Bombe()
        // {
        //   // Ne modifiez pas ce code. Placez le code de nettoyage dans Dispose(bool disposing) ci-dessus.
        //   Dispose(false);
        // }

        // Ce code est ajouté pour implémenter correctement le modèle supprimable.
        public void Dispose()
        {
            // Ne modifiez pas ce code. Placez le code de nettoyage dans Dispose(bool disposing) ci-dessus.
            Dispose(true);
            // TODO: supprimer les marques de commentaire pour la ligne suivante si le finaliseur est remplacé ci-dessus.
            // GC.SuppressFinalize(this);
        }
        #endregion


    }
}
